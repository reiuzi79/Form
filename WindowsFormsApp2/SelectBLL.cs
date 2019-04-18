using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 身份证信息管理系统
{
    public class SelectBLL
    {
        public delegate void SelectedDatasHandler(List<Data> SelectedDatas);  //委托，与主窗体的业务逻辑层联动
        public bool Select(string Selecting,int Type)
        {
            try
            {
                var DAL = new SelectDAL();
                var Result = DAL.Access(Selecting, Type);
                if(Result == null)
                {
                    return false;
                }
                else
                {
                    var Return = new SelectedDatasHandler(MainBLL.SelectDelegate);
                    Return(Result);
                    return true;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
