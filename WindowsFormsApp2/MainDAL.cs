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
        [StructLayout(LayoutKind.Sequential, Pack = 1, CharSet = CharSet.Auto)]
        public struct INFOR
        {
            public Int32 year;
            public Int32 month;
            public Int32 day;
            public Int32 age;
            public Int32 sex;
        };
        [DllImport("Data\\ID_ANALYSIS.dll", EntryPoint = "dllin", CallingConvention = CallingConvention.Cdecl)]
        public static extern INFOR dllin(string id);
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
                    var i = new INFOR();
                    var IDSet = db.Datas.Select(a => a.ID);
                    foreach(var ID in IDSet)
                    {
                        i = dllin(ID+"\0");  //调用身份证号分析DLL
                        var IDResult = db.Datas.Where(a => a.ID.Equals(ID)).FirstOrDefault();  //更新年龄
                        if(IDResult!=null)
                        {
                            IDResult.Age = (short)i.age;
                        }
                    }
                    db.SaveChanges();
                    return db.Datas.Select(a => a).ToList();
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
