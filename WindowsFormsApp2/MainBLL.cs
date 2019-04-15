using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 身份证信息管理系统
{
    public class MainBLL
    {

        public List<Data> Refresh()
        {
            var DAL = new MainDAL();
            return DAL.Refresh();
        }
    }
}
