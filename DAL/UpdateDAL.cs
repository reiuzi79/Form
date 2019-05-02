using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 身份证信息管理系统
{
    public class UpdateDAL
    {
        public void Access(string Name, string ID, Information Infor, string Address, string Telephone, string Remark)
        {
            try
            {
                using (var db = new DataContext())
                {
                    var Result = db.Datas.Where(a => a.ID.Equals(ID)).SingleOrDefault();
                    Result.Name = Name;
                    Result.ID = ID;
                    Result.Region = Infor.Region;
                    Result.Gender = Infor.Gender;
                    Result.Age = Infor.Age;
                    Result.Birthday = Infor.Birthday;
                    Result.Phone = Telephone;
                    Result.Address = Address;
                    Result.Remark = Remark;
                    db.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
