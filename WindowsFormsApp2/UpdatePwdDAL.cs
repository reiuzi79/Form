using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 身份证信息管理系统
{
    public class UpdatePwdDAL
    {
        public bool Update(string Account, string Password, string newPassword)
        {
            try
            {
                using (var db = new UserContext())
                {
                    var b = db.Users.Count(a => a.Account.Equals(Account) && a.Password.Equals(Password));
                    if (b != 0) //查账号和原密码
                    {
                        var c = db.Users.Where(a => a.Account.Equals(Account));
                        c.FirstOrDefault().Password = newPassword;
                        db.SaveChanges();
                        return true;
                    }
                    return false;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
