using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace 身份证信息管理系统
{
    public class MainDAL
    {
        public List<Data> Refresh()
        {
            try
            {
                using (var db = new DataContext())
                {
                    var result = db.Datas.Where(a => a.Age > 150); //删除大于150岁
                    if (result != null)
                    {
                        db.Datas.RemoveRange(result);
                    }
                    var i = new InformationAnal();
                    var IDSet = db.Datas.Select(a => a.ID);
                    foreach (var ID in IDSet)
                    {
                        var Infor = i.Analysis(ID);  //身份证号分析
                        var IDResult = db.Datas.Where(a => a.ID.Equals(ID)).FirstOrDefault();  //更新年龄
                        if (Infor.Check == true)
                        {
                            if (IDResult != null)
                            {
                                IDResult.Age = Infor.Age;
                            }
                        }
                        else
                        {
                            db.Datas.Remove(IDResult);
                        }
                    }
                    db.SaveChanges();
                    return db.Datas.Select(a => a).ToList();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
