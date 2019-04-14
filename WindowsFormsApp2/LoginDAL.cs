using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 身份证信息管理系统
{
    public class LoginDAL //Data Access Layer of LoginForm
    {
        public bool Access(string Account,string Password)
        {
            using (var db = new UserContext())
            {
                var b = db.Users.Count(a => a.Account.Equals(Account) && a.Password.Equals(Password));
                if(b==1)
                {
                    var c = db.Users.Where(a => a.Account.Equals(Account) && a.Password.Equals(Password)).Select(a => a.Nickname);
                    LoginBLL.User.Nickname = c.Single();
                    return true;
                }
                return false;
            }
        }
    }
}
