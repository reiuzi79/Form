using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 身份证信息管理系统
{
    public class UpdateBLL
    {
        public List<Data> Select(string ID)  //借用查询数据逻辑层
        {
            try
            {
                var SelectDAL = new SelectDAL();
                var Result = SelectDAL.Access(ID, 1);
                return Result;
            }
            catch(Exception e)
            {
                throw e;
            }
        }
        public bool Update(string name, string ID, string address, string phone, string remark)
        {
            try
            {
                var Anal = new InformationAnal();
                var Information = Anal.Analysis(ID);
                if(Information.Check == false)  //校验不过
                {
                    return false;
                }
                else
                {
                    var DAL = new UpdateDAL();
                    DAL.Access(name, ID, Information, address, phone, remark);
                    return true;
                }
            }
            catch(Exception e)
            {
                throw e;
            }
        }
    }
}
