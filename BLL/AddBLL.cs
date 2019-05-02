using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace 身份证信息管理系统
{
    
    public class AddBLL
    {
        public int Add(string Name, string ID, string Address, string Telephone, string Remark) 
        {
            try
            {
                var i = new InformationAnal();
                var Infor = i.Analysis(ID); //分析ID
                if (Infor.Check == true) //校验通过
                {
                    var DAL = new AddDAL();
                    if (DAL.Access(Name, ID, Infor, Address, Telephone, Remark) == true)
                    {
                        return 0;  //成功
                    }
                    else
                    {
                        return 2;  //ID已存在
                    }
                }
                else
                {
                    return 1;  //校验不通过
                }
            }
            catch(Exception e)
            {
                throw e;
            }
        }
    }
}
