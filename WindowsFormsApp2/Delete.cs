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
    public partial class Delete : Form
    {
        public Delete()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("确定删除？", "提示", MessageBoxButtons.OKCancel);
                if (dr == DialogResult.OK)
                {
                    var BLL = new DeleteBLL();
                    MessageBox.Show("已删除" + BLL.Delete(textBox1.Text.Trim(), 1) + "条数据");
                    this.Dispose();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("删除失败，异常原因：\n" + ex);
            }
        }
        private void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("确定删除全部数据？", "提示", MessageBoxButtons.OKCancel);
                if (dr == DialogResult.OK)
                {
                    var BLL = new DeleteBLL();
                    MessageBox.Show("已删除" + BLL.Delete(null, 0) + "条数据");
                    this.Dispose();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("删除失败，异常原因：\n" + ex);
            }
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }




        Point mouseOff;//鼠标移动位置变量
        bool leftFlag;//标签是否为左键
        private void Delete_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseOff = new Point(-e.X, -e.Y); //得到变量的值
                leftFlag = true;                  //点击左键按下时标注为true;
            }
        }

        private void Delete_MouseMove(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                Point mouseSet = Control.MousePosition;
                mouseSet.Offset(mouseOff.X, mouseOff.Y);  //设置移动后的位置
                Location = mouseSet;
            }
        }

        private void Delete_MouseUp(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                leftFlag = false;//释放鼠标后标注为false;
            }
        }
    }

}
