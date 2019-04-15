using SQLite.CodeFirst;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 身份证信息管理系统
{
    [Table("Datas")]
    public class Data
    {
        [Required]
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        [Key]
        public string ID { get; set; }
        public string Region { get; set; }
        public short Age { get; set; }
        public string Gender { get; set; }
        public string Remark { get; set; }
    }
    public class DataContext : DbContext
    {
        //定义属性，便于外部访问数据表
        public DbSet<Data> Datas { get { return Set<Data>(); } }

        public DataContext() : base("SQLiteConnect2")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            ModelConfiguration.Configure(modelBuilder);
            var init = new SqliteDropCreateDatabaseWhenModelChanges<DataContext>(modelBuilder);
            Database.SetInitializer(init);
        }
    }
}
