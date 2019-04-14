using System;
using System.Collections.Generic;
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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new LoginForm());
            LoginForm login = new LoginForm();

            //界面转换  
            login.ShowDialog();
            if (login.DialogResult == DialogResult.OK)
            {
                string acc = login.acc;
                login.Dispose();
                login.Close();
                MainForm m = new MainForm(acc);
                Application.Run(m);
            }
        }
    }
}
