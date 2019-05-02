using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 身份证信息管理系统
{
    public class LoginBLL //登录界面业务逻辑层
    {
        public User Validate(string Account, string Password)
        {
            try
            {
                var DAL = new LoginDAL();
                var Result = DAL.Access(Account, Password);
                if (Result != null)
                {
                    return Result;
                }
                else
                {
                    throw new Exception("用户名或密码错误");
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }

}
