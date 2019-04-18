using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 身份证信息管理系统
{
    public class MainBLL
    {

        public List<Data> Refresh()
        {
            try
            {
                var DAL = new MainDAL();
                return DAL.Refresh();
            }
            catch(Exception e)
            {
                throw e;
            }
        }
        private static List<Data> _SelectedDatas = null;
        public static List<Data> SelectedDatas { get => _SelectedDatas; set => _SelectedDatas = value; }
        public static void SelectDelegate(List<Data> SelectedDatas)
        {
            MainBLL.SelectedDatas = SelectedDatas;  //委托，回传查询结果
        }
        public void ClearDatas()
        {
            SelectedDatas = null;
        }
    }
}
