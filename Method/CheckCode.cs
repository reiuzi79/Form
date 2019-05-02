using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 身份证信息管理系统
{
    public class CheckCode
    {
        public static string Code()
        {
            Random random = new Random();
            int minV = 12345, maxV = 98765;
            return random.Next(minV, maxV).ToString();
        }
    }
}
