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
using System.Runtime.InteropServices;

namespace 身份证信息管理系统
{
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
        }
        [StructLayout(LayoutKind.Sequential, Pack = 1, CharSet = CharSet.Auto)]
        public struct INFOR
        {
            public Int32 year;
            public Int32 month;
            public Int32 day;
            public Int32 age;
            public Int32 sex;
        };
        [DllImport("Data\\ID_ANALYSIS.dll", EntryPoint = "dllin", CallingConvention = CallingConvention.Cdecl)]
        public static extern INFOR dllin(string id);
        [DllImport("Data\\CHECKER.dll", EntryPoint = "checkdll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int checkdll(string id);
        public DataSet checkData = new DataSet();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string connStr = @"Data Source=" + @"Data\Data.db;Initial Catalog=sqlite;Integrated Security=True;Max Pool Size=10";
                string s = "SELECT * FROM admin WHERE ID = '" + selectid.Text.Trim() + "'";
                SQLiteConnection con = new SQLiteConnection(connStr);
                con.Open();
                SQLiteCommand checkCmd = con.CreateCommand();
                checkCmd.CommandText = s;
                SQLiteDataAdapter check = new SQLiteDataAdapter();
                check.SelectCommand = checkCmd;
                int n = check.Fill(checkData, "admin");
                if (n == 0)
                {
                    MessageBox.Show("无此身份证号");
                }
                else
                {
                    panel1.Enabled = false;
                    panel1.Visible = false;
                    panel2.Enabled = true;
                    panel2.Visible = true;
                    name.Text = checkData.Tables[0].Rows[0][0].ToString();
                    id.Text = checkData.Tables[0].Rows[0][3].ToString();
                    tel.Text = checkData.Tables[0].Rows[0][1].ToString();
                    address.Text = checkData.Tables[0].Rows[0][2].ToString();
                    remark.Text = checkData.Tables[0].Rows[0][8].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("操作失败，异常原因：\n" + ex);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (name.Text == "" || id.Text == "" || id.Text.Length != 18)
                {
                    MessageBox.Show("请正确填写带*号的信息框");
                }
                else
                {
                    string s = id.Text.Trim();
                    s += '\0';
                    int check = checkdll(s);
                    if (check == 1)
                    {
                        INFOR INFO = new INFOR();
                        INFO = dllin(s);
                        string bir = INFO.year.ToString() + "年" + INFO.month.ToString() + "月" + INFO.day.ToString() + "日";
                        string sex = INFO.sex == 1 ? "男" : "女";
                        string connStr = @"Data Source=" + @"Data\Data.db;Initial Catalog=sqlite;Integrated Security=True;Max Pool Size=10";
                        SQLiteConnection con = new SQLiteConnection(connStr);
                        con.Open();
                        SQLiteCommand checkCmd = con.CreateCommand();
                        string command = "SELECT ID FROM admin WHERE ID='" + id.Text + "\'";
                        checkCmd.CommandText = command;
                        SQLiteDataAdapter chk = new SQLiteDataAdapter();
                        chk.SelectCommand = checkCmd;
                        DataSet checkData = new DataSet();
                        int n = chk.Fill(checkData, "admin");
                        string connStr1 = @"Data Source=" + @"Data\Regions.db;Initial Catalog=sqlite;Integrated Security=True;Max Pool Size=10";
                        SQLiteConnection con1 = new SQLiteConnection(connStr1);
                        con1.Open();
                        string command1 = "select * from REGION where BM = '" + id.Text.Substring(0, 6) + "'";
                        SQLiteCommand command11 = new SQLiteCommand();
                        command11.Connection = con1;
                        command11.CommandText = string.Format(command1);
                        SQLiteDataReader reader = command11.ExecuteReader(CommandBehavior.CloseConnection);
                        string region = reader["DQ"].ToString();
                        command11 = null;
                        reader.Close();
                        con1.Close();
                        string s1 = "update admin set NAME='" + name.Text.Trim() + "',TEL='" + tel.Text.Trim() + "',[ADD]='"
                        + address.Text.Trim() + "',ID='" + id.Text.Trim() + "',REGION='" + region + "',BIR='" + bir + "',AGE='" + INFO.age + "',SEX='" + sex +
                        "',REMARK='" + remark.Text + "' where ID ='" + id.Text.Trim() + "'";
                        SQLiteCommand com = new SQLiteCommand(s1, con);
                        com.ExecuteNonQuery();
                        con.Close();
                        com = null;
                        MessageBox.Show("更改成功");
                        panel2.Enabled = false;
                        panel2.Visible = false;
                        panel1.Enabled = true;
                        panel1.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("身份证校验不正确，请检查");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("更改失败，错误信息：\n" + ex);
            }
        }
        Point mouseOff;//鼠标移动位置变量
        bool leftFlag;//标签是否为左键
        private void Update_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseOff = new Point(-e.X, -e.Y); //得到变量的值
                leftFlag = true;                  //点击左键按下时标注为true;
            }
        }

        private void Update_MouseMove(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                Point mouseSet = Control.MousePosition;
                mouseSet.Offset(mouseOff.X, mouseOff.Y);  //设置移动后的位置
                Location = mouseSet;
            }
        }

        private void Update_MouseUp(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                leftFlag = false;//释放鼠标后标注为false;
            }
        }
    }
}
