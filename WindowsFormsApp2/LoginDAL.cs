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
            try
            {
                using (var db = new UserContext())
                {
                    var PasswordMD5 = MD5Creating.EncryptWithMD5(Password);
                    var b = db.Users.Where(a => a.Account.Equals(Account) && a.Password.Equals(PasswordMD5)).Select(a => a.Nickname).FirstOrDefault(); //选对应昵称
                    if (b != null)
                    {
                        //var c = db.Users.Where(a => a.Account.Equals(Account) && a.Password.Equals(Password)).Select(a => a.Nickname);
                        LoginBLL.User.Nickname = b;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
