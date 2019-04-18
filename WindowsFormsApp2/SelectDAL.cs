using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 身份证信息管理系统
{
    public class SelectDAL
    {
        public List<Data> Access(string Selecting, int Type)
        {
            try
            {
                using (var db = new DataContext())
                {
                    var Result = new List<Data>();
                    switch(Type)
                    {
                        case 0:
                            Result = db.Datas.Where(a => a.Name.Equals(Selecting)).ToList(); 
                            break;
                        case 1:
                            Result = db.Datas.Where(a => a.ID.Equals(Selecting)).ToList();
                            break;
                        case 2:
                            Result = db.Datas.Where(a => a.Phone.Equals(Selecting)).ToList();
                            break;
                        case 3:
                            if (Selecting.Contains("-"))//检验“-”
                            {
                                string[] str = Selecting.Split(new char[] { '-' });
                                var Lower = short.Parse(str[0]);
                                var Higher = short.Parse(str[1]);
                                if(Lower>Higher)
                                {
                                    var Temp = Higher;
                                    Higher = Lower;
                                    Lower = Temp;
                                }
                                Result = db.Datas.Where(a => a.Age >= Lower && a.Age <= Higher).ToList(); //根据范围查询
                            }
                            else
                            {
                                var Age = short.Parse(Selecting);
                                Result = db.Datas.Where(a => a.Age == Age).ToList();
                            }
                            break;
                        case 4:
                            Result = db.Datas.Where(a => a.Birthday.Contains(Selecting)).ToList();
                            break;
                        case 5:
                            Result = db.Datas.Where(a => a.Gender.Equals(Selecting)).ToList();
                            break;
                    }
                    return Result;
                }
            }
            catch(Exception e)
            {
                throw e;
            }
        }
    }
}
