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
            Random random = new Random();
            int minV = 12345, maxV = 98765;
            checkpic.Text = random.Next(minV, maxV).ToString();
        }

        private void check_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int minV = 12345, maxV = 98765;
            checkpic.Text = random.Next(minV, maxV).ToString();
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
                string userid = acc.Text.Trim();
                string connStr = @"Data Source=" + @"Data\Account.db;Initial Catalog=sqlite;Integrated Security=True;Max Pool Size=10";
                SQLiteConnection con = new SQLiteConnection(connStr);
                con.Open();
                SQLiteCommand checkCmd = con.CreateCommand();
                string s = "SELECT account FROM Accounts WHERE Account='" + userid + "'";
                checkCmd.CommandText = s;
                SQLiteDataAdapter check = new SQLiteDataAdapter();
                check.SelectCommand = checkCmd;
                DataSet checkData = new DataSet();
                int n = check.Fill(checkData, "Accounts");
                if (n != 0)
                {
                    MessageBox.Show("用户名存在");
                }
                if (surepwd.Text != pwd.Text)
                {
                    MessageBox.Show("确认密码和密码不一致");
                }
                if (checkcode.Text != checkpic.Text)
                {
                    MessageBox.Show("验证码错误");
                    Random random = new Random();
                    int minV = 12345, maxV = 98765;
                    checkpic.Text = random.Next(minV, maxV).ToString();
                }

                if (acc.Text == "" || pwd.Text == "" || nick.Text == "" || surepwd.Text == ""
                    || checkcode.Text == "")
                {
                    MessageBox.Show("信息不完整");
                }
                if ((acc.Text == "" || pwd.Text == "" || nick.Text == "" || surepwd.Text == ""
                    || checkcode.Text == "") == false && (checkcode.Text != checkpic.Text) == false && (surepwd.Text != pwd.Text) == false && n == 0)
                {
                    string s1 = "insert into Accounts(Account,Password,Nickname) values ('" + acc.Text + "','" + pwd.Text + "','"
                    + nick.Text + "')";
                    SQLiteCommand com = new SQLiteCommand(s1, con);
                    com.ExecuteNonQuery();
                    con.Close();
                    com = null;
                    con.Dispose();
                    MessageBox.Show("注册成功");
                    this.Dispose();
                    this.Close();
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
