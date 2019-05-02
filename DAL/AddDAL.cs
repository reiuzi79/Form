using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace 身份证信息管理系统
{
    public class AddDAL
    {

        public bool Access(string Name, string ID, Information Infor, string Address, string Telephone, string Remark)
        {
            try
            {
                using (var Datadb = new DataContext())
                {
                    if (Datadb.Datas.Count(a => a.ID.Equals(ID)) != 0)  //ID是否存在
                    {
                        return false;
                    }
                    else
                    {
                        var Data = new Data() { Name = Name, Phone = Telephone, Address = Address, ID = ID, Region = Infor.Region, Birthday = Infor.Birthday, Age = Infor.Age, Gender = Infor.Gender, Remark = Remark };
                        Datadb.Datas.AddRange(new List<Data>() { Data });
                        Datadb.SaveChanges();
                        return true;
                    }
                }
            }
            catch(Exception e)
            {
                throw e;
            }
        }
    }
}
