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
    public partial class UpdatePwd : Form
    {
        public UpdatePwd()
        {
            InitializeComponent();
            checkpic.Text = CheckCode.Code();
        }
       

        private void checkpic_Click(object sender, EventArgs e)
        {
            checkpic.Text = CheckCode.Code();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (sure.Text.Trim() != newpwd.Text.Trim())
                {
                    MessageBox.Show("确认密码和新密码不一致");
                    checkpic.Text = CheckCode.Code();
                    return;
                }
                if (checkcode.Text.Trim() != checkpic.Text)
                {
                    MessageBox.Show("验证码错误");
                    checkpic.Text = CheckCode.Code();
                    return;
                }

                if (acc.Text.Trim() == "" || oldpwd.Text.Trim() == "" || newpwd.Text.Trim() == "" || sure.Text.Trim() == ""
                    || checkcode.Text.Trim() == "")
                {
                    MessageBox.Show("信息不完整");
                    checkpic.Text = CheckCode.Code();
                    return;
                }
                var BLL = new UpdatePwdBLL();
                switch(BLL.Access(acc.Text.Trim(), oldpwd.Text.Trim(), newpwd.Text.Trim()))
                {
                    case 0:
                        MessageBox.Show("修改成功");
                        this.Dispose();
                        this.Close();
                        break;
                    case 1:
                        MessageBox.Show("修改失败");
                        break;
                    case 2:
                        MessageBox.Show("用户名或原密码错误");
                        break;
                }
                checkpic.Text = CheckCode.Code();
            }
            catch (Exception ex)
            {
                MessageBox.Show("修改失败，错误信息：\n" + ex);
            }
        }


        Point mouseOff;//鼠标移动位置变量
        bool leftFlag;//标签是否为左键

        private void UpdatePwd_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseOff = new Point(-e.X, -e.Y); //得到变量的值
                leftFlag = true;                  //点击左键按下时标注为true;
            }
        }

        private void UpdatePwd_MouseMove(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                Point mouseSet = Control.MousePosition;
                mouseSet.Offset(mouseOff.X, mouseOff.Y);  //设置移动后的位置
                Location = mouseSet;
            }
        }

        private void UpdatePwd_MouseUp(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                leftFlag = false;//释放鼠标后标注为false;
            }
        }
    }
}
