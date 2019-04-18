using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 身份证信息管理系统
{
    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        internal static void Main()
        {
            try
            {
                using (var db = new UserContext())
                {
                    var b = db.Users.Count(a => a.Account.Equals("admin"));  //检查是否有管理员账户
                    if (b == 0)
                    {
                        var AdminMD5 = MD5Creating.EncryptWithMD5("admin");
                        db.Users.AddRange(new List<User>() { new User() { Account = "admin", Password = AdminMD5, Nickname = "admin" } }); //添加管理员账户
                        db.SaveChanges();
                    }
                }
            }
            catch(IOException ex)
            {
                MessageBox.Show("发生严重错误:"+ex);
                Application.Exit();
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LoginForm login = new LoginForm();

            //界面转换  
            login.ShowDialog();
            if (login.DialogResult == DialogResult.OK)
            {
                string Acc = login.Acc;
                login.Dispose();
                login.Close();
                MainForm m = new MainForm(Acc);
                Application.Run(m);
            }
        }
    }
}
