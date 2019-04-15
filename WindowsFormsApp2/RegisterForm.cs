using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 身份证信息管理系统
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            checkpic.Text = CheckCode.Code();
        }

        private void check_Click(object sender, EventArgs e)
        {
            checkpic.Text = CheckCode.Code();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        private void regist_Click(object sender, EventArgs e)
        {
            try
            {
                if (surepwd.Text != pwd.Text)
                {
                    MessageBox.Show("确认密码和密码不一致");
                    checkpic.Text = CheckCode.Code();
                    return;
                }
                if (checkcode.Text != checkpic.Text)
                {
                    MessageBox.Show("验证码错误");
                    checkpic.Text = CheckCode.Code();
                    return;
                }
                if (acc.Text.Trim() == "" || pwd.Text.Trim() == "" || nick.Text.Trim() == "" || surepwd.Text == ""
                    || checkcode.Text == "")
                {
                    MessageBox.Show("信息不完整");
                    checkpic.Text = CheckCode.Code();
                    return;
                }
                var BLL = new RegisterBLL();
                switch(BLL.Access(acc.Text.Trim(), pwd.Text.Trim(), nick.Text.Trim()))
                {
                    case 0:
                        MessageBox.Show("注册成功");
                        this.Dispose();
                        this.Close();
                        break;
                    case 1:
                        MessageBox.Show("注册失败");
                        break;
                    case 2:
                        MessageBox.Show("用户名存在");
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("注册失败，错误信息：\n" + ex);
            }
        }

        private void okCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (okCheckbox.Checked == false)
            {
                regist.Enabled = false;
            }
            else if (okCheckbox.Checked == true)
            {
                regist.Enabled = true;
            }
        }

        //以下为拖动窗体用
        Point mouseOff;//鼠标移动位置变量
        bool leftFlag;//标签是否为左键

        private void RegisterForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseOff = new Point(-e.X, -e.Y); //得到变量的值
                leftFlag = true;                  //点击左键按下时标注为true;
            }
        }

        private void RegisterForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                Point mouseSet = Control.MousePosition;
                mouseSet.Offset(mouseOff.X, mouseOff.Y);  //设置移动后的位置
                Location = mouseSet;
            }
        }

        private void RegisterForm_MouseUp(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                leftFlag = false;//释放鼠标后标注为false;
            }
        }
    }
}
