using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace 身份证信息管理系统
{
    public class Information
    {
        private string birthday;
        private short age;
        private string gender;
        private bool check;
        private string region;
        public string Birthday { get => birthday; set => birthday = value; }
        public short Age { get => age; set => age = value; }
        public string Gender { get => gender; set => gender = value; }
        public bool Check { get => check; set => check = value; }
        public string Region { get => region; set => region = value; }
    }
    public class InformationAnal  //校验身份证号，返回出生日期，年龄，性别的类
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
        [DllImport("Data\\CHECKER.dll", EntryPoint = "checkdll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int checkdll(string id);

        public Information Analysis(string ID)
        {
            try
            {
                if(checkdll(ID + "\0") != 1)
                {
                    return new Information() { Check = false }; //校验不通过
                }
                var Infor = new INFOR();
                Infor = dllin(ID + '\0');
                var Info = new Information
                {
                    Check = true,
                    Birthday = Infor.year.ToString() + "年" + Infor.month.ToString() + "月" + Infor.day.ToString() + "日",
                    Gender = Infor.sex == 1 ? "男" : "女", //1是男，2是女
                    Age = (short)Infor.age
                };
                using (var db = new RegionsContext())
                {
                    var Region = db.REGION.Where(a => a.BM.Equals(ID.Substring(0, 6))).Select(a => a.DQ).FirstOrDefault();
                    if(Region == null)
                    {
                        Region = "未识别的地区";
                    }
                    Info.Region = Region;
                }
                return Info;
            }
            catch(Exception e)
            {
                throw e;
            }
        }
    }
}
