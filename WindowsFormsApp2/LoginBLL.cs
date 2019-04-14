using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 身份证信息管理系统
{
    public class LoginBLL //登录界面业务逻辑层
    {
        public class User
        {
            string _Account;
            string _Password;
            public static string Nickname="";
            public string Account { get => _Account; set => _Account = value; }
            public string Password { get => _Password; set => _Password = value; }
        }
        User user = new User();
        public LoginBLL() { }
        public LoginBLL(string Account,string Password)
        {
            user.Account = Account;
            user.Password = Password;
        }
        public bool Validate()
        {
            var DAL = new LoginDAL();
            if(DAL.Access(user.Account, user.Password)==true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

}
