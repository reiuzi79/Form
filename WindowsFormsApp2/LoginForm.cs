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
    public partial class LoginForm : Form
    {
        private string _acc;

        public LoginForm()
        {
            InitializeComponent();
            check.Text = CheckCode.Code();   //生成验证码
        }

        private void Check_Click(object sender, EventArgs e)
        {
            check.Text = CheckCode.Code();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Regist_Click(object sender, EventArgs e)
        {
            RegisterForm register = new RegisterForm();
            register.ShowDialog();
        }
        private void Login_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkcode.Text == check.Text)
                {
                    string Account = account.Text.Trim();
                    string Password = psw.Text.Trim();
                    LoginBLL BLL = new LoginBLL(); //扔给BLL处理
                    var Result = BLL.Validate(Account, Password);
                    MessageBox.Show("登录成功，欢迎" + Result.Nickname + "用户使用");
                    Acc = Account;
                    this.DialogResult = DialogResult.OK;  //告知Program.cs 启动主窗体
                }
                else
                {
                    MessageBox.Show("验证码错误");
                    checkcode.Text = "";
                    checkcode.Focus();
                    check.Text = CheckCode.Code();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("登录失败，错误信息：\n" + ex.Message);
            }
            finally
            {
                account.Text = "";
                psw.Text = "";
                checkcode.Text = "";
                account.Focus();
                check.Text = CheckCode.Code();
            }
        }




        Point mouseOff;//鼠标移动位置变量
        bool leftFlag;//标签是否为左键

        public string Acc { get => _acc; set => _acc = value; }

        private void LoginForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseOff = new Point(-e.X, -e.Y); //得到变量的值
                leftFlag = true;                  //点击左键按下时标注为true;
            }
        }

        private void LoginForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                Point mouseSet = Control.MousePosition;
                mouseSet.Offset(mouseOff.X, mouseOff.Y);  //设置移动后的位置
                Location = mouseSet;
            }
        }

        private void LoginForm_MouseUp(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                leftFlag = false;//释放鼠标后标注为false;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            UpdatePwd u = new UpdatePwd();
            u.ShowDialog();
        }

    }
}
