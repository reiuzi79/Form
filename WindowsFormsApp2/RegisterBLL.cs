using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 身份证信息管理系统
{
    public class RegisterBLL
    {
        public int Access(string Account, string Password,string Nickname)
        {
            try
            {
                var DAL = new RegisterDAL();
                if(DAL.Insert(Account, Password, Nickname)==true) //插入成功则返回0
                {
                    return 0;
                }
                return 2;
            }
            catch
            {
                return 1;
            }
        }
    }
}
