using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 身份证信息管理系统
{
    class RegisterDAL
    {
        public bool Insert(string Account, string Password, string Nickname) 
        {
            try
            {
                using (var db = new UserContext())
                {
                    if (db.Users.Count(a => a.Account.Equals(Account)) == 0) //判断账号是否存在
                    {
                        db.Users.AddRange(new List<User>() { new User() { Account = Account, Password = Password, Nickname = Nickname } });
                        db.SaveChanges();
                        return true;
                    }
                    return false;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
