using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 身份证信息管理系统
{
    public class LoginDAL //Data Access Layer of LoginForm
    {
        public User Access(string Account,string Password)
        {
            try
            {
                using (var db = new UserContext())
                {
                    var PasswordMD5 = MD5Creating.EncryptWithMD5(Password);
                    var b = db.Users.Where(a => a.Account.Equals(Account) && a.Password.Equals(PasswordMD5)).FirstOrDefault(); //选对应昵称
                    return b;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
