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
        static string s;
        public Select()
        {
            InitializeComponent();
            s = "SELECT account FROM Accounts WHERE Account='" + textBox1.Text.Trim() + "'";
        }

        public DataSet checkData = new DataSet();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DoSomethingEventHandler myDelegate = new DoSomethingEventHandler(MainForm.DoSomething);
                DoSomethingEventHandler1 myDelegate1 = new DoSomethingEventHandler1(MainForm.DoSomething1);
                myDelegate1(false);
                string connStr = @"Data Source=" + @"Data\Data.db;Initial Catalog=sqlite;Integrated Security=True;Max Pool Size=10";
                SQLiteConnection con = new SQLiteConnection(connStr);
                con.Open();
                SQLiteCommand checkCmd = con.CreateCommand();
                textBox1.Text = textBox1.Text.Trim();
                if (name.Checked == true)
                {
                    s = "SELECT * FROM admin WHERE NAME='" + textBox1.Text.Trim() + "'";
                }
                if (id.Checked == true)
                {
                    s = "SELECT * FROM admin WHERE ID='" + textBox1.Text.Trim() + "'";
                }
                if (tel.Checked == true)
                {
                    s = "SELECT * FROM admin WHERE TEL='" + textBox1.Text.Trim() + "'";
                }
                if (age.Checked == true)
                {
                    if (textBox1.Text.Contains("-"))//检验“-”
                    {
                        string[] str = textBox1.Text.Split(new char[] { '-' });
                        s = "SELECT * FROM admin WHERE AGE BETWEEN " + str[0] + " AND " + str[1];
                    }
                    else
                    {
                        s = "SELECT * FROM admin WHERE AGE = '" + textBox1.Text + "'";
                    }
                }
                if (birth.Checked == true)
                {
                    if (textBox1.Text.Contains("日"))
                    {
                        s = "SELECT * FROM admin WHERE BIR = '" + textBox1.Text.Trim() + "'";
                    }
                    else
                    {
                        s = "SELECT * FROM admin WHERE BIR LIKE '" + textBox1.Text.Trim() + "%'";
                    }
                }
                if (sex.Checked == true)
                {
                    s = "SELECT * FROM admin WHERE SEX = '" + textBox1.Text.Trim() + "'";
                }
                checkCmd.CommandText = s;
                SQLiteDataAdapter check = new SQLiteDataAdapter();
                check.SelectCommand = checkCmd;
                int n = check.Fill(checkData, "admin");
                if (n == 0)
                {
                    MessageBox.Show("无查询结果");
                }
                else
                {
                    MessageBox.Show("查询完毕");
                    myDelegate(checkData);
                    myDelegate1(true);
                    con.Close();
                    this.Dispose();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("查询异常，原因：\n" + ex);
            }
        }
        public delegate void DoSomethingEventHandler(DataSet ds2);
        public delegate void DoSomethingEventHandler1(bool dsflag);
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
