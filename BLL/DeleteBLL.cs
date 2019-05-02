using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 身份证信息管理系统
{
    public class DeleteBLL
    {
        public int Delete(string ID, int Type)
        {
            try
            {
                var DAL = new DeleteDAL();
                if(Type == 0)
                {
                    return DAL.Access(null, 0);
                }
                ID = ID.ToUpper(); //x→X
                if (ID.Contains(",") || ID.Contains("，"))  //分割成数组
                {
                    ID.Replace('，', ',');
                    string[] AllID = ID.Split(new char[] { ',' });
                    return DAL.Access(AllID, 1);
                }
                else
                {
                    return DAL.Access(new string[] { ID }, 1);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
