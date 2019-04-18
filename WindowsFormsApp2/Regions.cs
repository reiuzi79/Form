using SQLite.CodeFirst;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 身份证信息管理系统
{
    public class REGION
    {
        public int ID { get; set; }
        public string BM { get; set; }
        public string DQ { get; set; }
    }
    public class RegionsContext : DbContext
    {
        //定义属性，便于外部访问数据表
        public DbSet<REGION> REGION { get { return Set<REGION>(); } }

        public RegionsContext() : base("SQLiteConnect3")
        {

        }
    }
}
