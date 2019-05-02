using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 身份证信息管理系统
{
    public class DeleteDAL
    {
        public int Access(string[] ID,int Type)
        {
            try
            {
                using (var db = new DataContext())
                {
                    if(Type == 0) //全删
                    {
                        var Result = db.Datas.Select(a => a);
                        db.Datas.RemoveRange(Result);
                        return db.SaveChanges(); //返回删除数
                    }
                    else
                    {
                        var Del = new List<Data>();
                        foreach(var IDTemp in ID)
                        {
                            Del.AddRange(db.Datas.Where(a => a.ID.Equals(IDTemp)));
                        }
                        db.Datas.RemoveRange(Del);
                        return db.SaveChanges();
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
