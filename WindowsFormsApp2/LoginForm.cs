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
        public LoginForm()
        {
            InitializeComponent();
            Random random = new Random();
            int minV = 12345, maxV = 98765;
            check.Text = random.Next(minV, maxV).ToString();

        }

        private void check_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int minV = 12345, maxV = 98765;
            check.Text = random.Next(minV, maxV).ToString();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void regist_Click(object sender, EventArgs e)
        {
            RegisterForm register = new RegisterForm();
            register.ShowDialog();
        }
        private string Acc;
        public string acc
        {
            get { return Acc; }
            set { Acc = value; }
        }
        private void login_Click(object sender, EventArgs e)
        {
            try
            {
                string userid = account.Text.Trim();
                string password = psw.Text.Trim();
                string connStr = @"Data Source=" + @"Data\Account.db;Initial Catalog=sqlite;Integrated Security=True;Max Pool Size=10";
                SQLiteConnection con = new SQLiteConnection(connStr);
                con.Open();
                SQLiteCommand checkCmd = con.CreateCommand();
                string s1 = "select Account,Password from Accounts where Account='" + userid + "' and Password='" + password + "'";
                checkCmd.CommandText = s1;
                SQLiteDataAdapter ada = new SQLiteDataAdapter();
                ada.SelectCommand = checkCmd;
                DataSet ds = new DataSet();
                int n = ada.Fill(ds, "Accounts");
                if (n != 0)
                {
                    if (checkcode.Text == check.Text)
                    {
                        string s2 = "select Nickname from Accounts where Account='" + userid + "'";
                        checkCmd.CommandText = s2;
                        ada.SelectCommand = checkCmd;
                        DataTable dt = new DataTable();
                        ada.Fill(dt);
                        string nickname = dt.Rows[0][0].ToString();
                        MessageBox.Show("登录成功，欢迎" + nickname + "用户使用");
                        acc = userid;
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("验证码错误");
                        checkcode.Text = "";
                        checkcode.Focus();
                        Random random = new Random();
                        int minV = 12345, maxV = 98765;
                        check.Text = random.Next(minV, maxV).ToString();
                    }
                }
                else
                {
                    MessageBox.Show("用户名或密码有错误!");
                    account.Text = "";
                    psw.Text = "";
                    account.Focus();
                    Random random = new Random();
                    int minV = 12345, maxV = 98765;
                    check.Text = random.Next(minV, maxV).ToString();
                    checkcode.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("登录失败，错误信息：\n" + ex);
            }
        }
        Point mouseOff;//鼠标移动位置变量
        bool leftFlag;//标签是否为左键

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

        private void button1_Click(object sender, EventArgs e)
        {
            UpdatePwd u = new UpdatePwd();
            u.ShowDialog();
        }

    }
}
