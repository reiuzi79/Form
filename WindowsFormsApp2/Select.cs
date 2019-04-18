using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace 身份证信息管理系统
{
    public partial class Select : Form
    {
        public Select()
        {
            InitializeComponent();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                var Selecting = textBox1.Text.Trim();
                var Select = new SelectBLL();
                var Type = 0;
                if (name.Checked == true)
                {
                    Type = 0;
                }
                if (id.Checked == true)
                {
                    Type = 1;
                }
                if (tel.Checked == true)
                {
                    Type = 2;
                }
                if (age.Checked == true)
                {
                    Type = 3;
                }
                if (birth.Checked == true)
                {
                    Type = 4;
                }
                if (sex.Checked == true)
                {
                    Type = 5;
                }
                switch(Select.Select(Selecting, Type))
                {
                    case false:
                        MessageBox.Show("无查询结果");
                        break;
                    case true:
                        MessageBox.Show("查询完毕");
                        this.Dispose();
                        this.Close();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("查询异常，原因：\n" + ex);
            }
        }



        Point mouseOff;//鼠标移动位置变量
        bool leftFlag;//标签是否为左键
        private void Select_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseOff = new Point(-e.X, -e.Y); //得到变量的值
                leftFlag = true;                  //点击左键按下时标注为true;
            }
        }

        private void Select_MouseMove(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                Point mouseSet = Control.MousePosition;
                mouseSet.Offset(mouseOff.X, mouseOff.Y);  //设置移动后的位置
                Location = mouseSet;
            }
        }

        private void Select_MouseUp(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                leftFlag = false;//释放鼠标后标注为false;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
