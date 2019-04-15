using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 身份证信息管理系统
{
    public partial class MainForm : Form
    {
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
        private string Acc1;
        public string acc1
        {
            get { return Acc1; }
            set { Acc1 = value; }
        }
        DataTable dt = new DataTable();
        public MainForm(string acc)
        {
            InitializeComponent();
            acc1 = acc;
            reFresh();
        }
        internal void setDATSizeMode() //设置DataGridView控件列尺寸以适应数据
        {
            DAT.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DAT.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DAT.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DAT.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DAT.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DAT.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }
        internal void reFresh()
        {
            ac.Text = "当前用户为" + acc1;
            if (acc1 == "admin")
            {
                ac.Text += "，为超级管理员";
            }
            else
            {
                button2.Enabled = false;
                button3.Enabled = false;
                ac.Text += "，为普通用户，无法使用删改功能";
            }
            var BLL = new MainBLL();
            DAT.DataSource = BLL.Refresh();
            setDATSizeMode();
            label2.Text = "有" + DAT.RowCount + "条记录";
        }
        private void 刷新ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reFresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add add = new Add();
            add.ShowDialog();
            bool flag = true;
            while (add.IsDisposed == true && flag == true)
            {
                flag = false;
                reFresh();
            }
        }
        private static DataSet ds2;
        public static void DoSomething(DataSet ds1)
        {
            ds2 = ds1;
        }
        private static bool dsflag;
        public static void DoSomething1(bool dsflag1)
        {
            dsflag = dsflag1;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Select s = new Select();
            s.ShowDialog(this);
            bool flag1 = true;
            while (s.IsDisposed == true && flag1 == true && dsflag == true)
            {
                flag1 = false;
                dsflag = false;
                dt = ds2.Tables[0];
                DAT.DataSource = dt;
                setDATSizeMode();
                label2.Text = "有" + dt.Rows.Count + "条记录";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Delete d = new Delete();
            d.ShowDialog();
            bool flag = true;
            while (d.IsDisposed == true && flag == true)
            {
                flag = false;
                reFresh();
            }
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("确定退出？", "提示", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
                Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Update u = new Update();
            u.ShowDialog();
            bool flag = true;
            while (u.IsDisposed == true && flag == true)
            {
                flag = false;
                reFresh();
            }
        }

        private void 关于本系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 a = new AboutBox1();
            a.ShowDialog();
        }

        private void 帮助ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help h = new Help();
            h.ShowDialog();
        }
    }

}