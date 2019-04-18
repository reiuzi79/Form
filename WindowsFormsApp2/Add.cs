using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SQLite;

namespace 身份证信息管理系统
{
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (name.Text.Trim() == "" || id.Text.Trim().Length != 18)
                {
                    MessageBox.Show("请正确填写带*号的信息框");
                }
                else
                {
                    var BLL = new AddBLL();
                    switch(BLL.Add(name.Text.Trim(), id.Text.Trim().ToUpper(), address.Text.Trim(), tel.Text.Trim(), remark.Text))
                    {
                        case 0:
                            DialogResult dr = MessageBox.Show("添加成功，是否继续添加？", "提示", MessageBoxButtons.OKCancel);
                            if (dr == DialogResult.OK)
                            {
                                name.Text = ""; id.Text = ""; tel.Text = ""; address.Text = ""; remark.Text = "";
                            }
                            else if (dr == DialogResult.Cancel)
                            {
                                this.Dispose();
                                this.Close();
                            }
                            break;
                        case 1:
                            MessageBox.Show("身份证校验不正确，请检查");
                            break;
                        case 2:
                            MessageBox.Show("身份证号存在");
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("添加失败，错误信息：\n" + ex);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        Point mouseOff;//鼠标移动位置变量
        bool leftFlag;//标签是否为左键
        private void Add_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseOff = new Point(-e.X, -e.Y); //得到变量的值
                leftFlag = true;                  //点击左键按下时标注为true;
            }
        }

        private void Add_MouseMove(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                Point mouseSet = Control.MousePosition;
                mouseSet.Offset(mouseOff.X, mouseOff.Y);  //设置移动后的位置
                Location = mouseSet;
            }
        }

        private void Add_MouseUp(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                leftFlag = false;//释放鼠标后标注为false;
            }
        }
    }
}
