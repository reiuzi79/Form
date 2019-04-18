using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 身份证信息管理系统
{
    public class UpdatePwdBLL
    {
        public int Access(string Account, string Password, string newPassword)
        {
            try
            {
                var DAL = new UpdatePwdDAL();
                if (DAL.Update(Account, Password, newPassword) == true)
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
            catch
            {
                return 1;
            }
        }
    }
}
