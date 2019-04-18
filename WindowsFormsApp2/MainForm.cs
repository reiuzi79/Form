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
        public string Acc1 { get; set; }
        public MainForm(string acc)
        {
            InitializeComponent();
            Acc1 = acc;
            ReFresh();
        }
        internal void SetDATSizeMode() //设置DataGridView控件列尺寸以适应数据
        {
            DAT.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DAT.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DAT.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DAT.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DAT.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DAT.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }
        internal void ReFresh()
        {
            try
            {
                ac.Text = "当前用户为" + Acc1;
                if (Acc1 == "admin")
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
                SetDATSizeMode();
                label2.Text = "有" + DAT.RowCount + "条记录";
            }
            catch(Exception e)
            {
                MessageBox.Show("出现异常，原因：\n" + e);
            }
        }
        private void 刷新ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReFresh();
        }

        private void Button1_Click(object sender, EventArgs e)   //添加数据
        {
            var BLL = new MainBLL();
            BLL.Add();
            ReFresh();
        }
        

        private void Button4_Click(object sender, EventArgs e)  //查询数据
        {
            var BLL = new MainBLL();
            var Result = BLL.Select();
            if (Result != null)  //查询到才更新显示控件
            {
                DAT.DataSource = Result;
                SetDATSizeMode();
                label2.Text = "有" + DAT.RowCount + "条记录";
            }
        }

        private void Button2_Click(object sender, EventArgs e)  //删除数据
        {
            var BLL = new MainBLL();
            BLL.Delete();
            ReFresh();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("确定退出？", "提示", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
                Application.Exit();
        }

        private void Button3_Click(object sender, EventArgs e)   //更改数据
        {
            var BLL = new MainBLL();
            BLL.Update();
            ReFresh();
        }

        private void 关于本系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox a = new AboutBox();
            a.ShowDialog();
        }

        private void 帮助ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help h = new Help();
            h.ShowDialog();
        }
    }

}