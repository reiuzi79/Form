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

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(selectid.Text.Trim() == "")
                {
                    MessageBox.Show("请填写身份证号");
                    return;
                }
                var BLL = new UpdateBLL();
                var Result = BLL.Select(selectid.Text.Trim());
                if (Result.Count == 0)
                {
                    MessageBox.Show("无此身份证号");
                }
                else
                {
                    panel1.Enabled = false;  //启用另一组控件
                    panel1.Visible = false;
                    panel2.Enabled = true;
                    panel2.Visible = true;
                    name.Text = Result.Select(a => a.Name).FirstOrDefault();
                    id.Text = Result.Select(a => a.ID).FirstOrDefault();
                    tel.Text = Result.Select(a => a.Phone).FirstOrDefault();
                    address.Text = Result.Select(a => a.Address).FirstOrDefault();
                    remark.Text = Result.Select(a => a.Remark).FirstOrDefault();    //填充另一组控件文本框内容
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("操作失败，异常原因：\n" + ex);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }
        private void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (name.Text.Trim() == "" || id.Text.Trim() == "" || id.Text.Trim().Length != 18)
                {
                    MessageBox.Show("请正确填写带*号的信息框");
                }
                else
                {
                    var BLL = new UpdateBLL();
                    var Checked = BLL.Update(name.Text.Trim(), id.Text.Trim(), address.Text.Trim(), tel.Text.Trim(), remark.Text);
                    if(Checked)
                    { 
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
