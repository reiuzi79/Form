using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using SQLite.CodeFirst;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace 身份证信息管理系统
{
    [Table("Users")]
    public class User
    {
        [Key]
        public string Account { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Nickname { get; set; }
    }
    public class UserContext : DbContext
    {
        //定义属性，便于外部访问数据表
        public DbSet<User> Users { get { return Set<User>(); }  }

        public UserContext() : base("SQLiteConnect1")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            ModelConfiguration.ConfigureUser(modelBuilder);
            var init = new SqliteDropCreateDatabaseWhenModelChanges<UserContext>(modelBuilder);
            Database.SetInitializer(init);
        }
    }

    public class ModelConfiguration
    {
        public static void ConfigureUser(DbModelBuilder modelBuilder)
        {
            ConfigureBookEntityUser(modelBuilder);
        }
        public static void ConfigureData(DbModelBuilder modelBuilder)
        {
            ConfigureBookEntityData(modelBuilder);
        }
        private static void ConfigureBookEntityUser(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>();
        }
        private static void ConfigureBookEntityData(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Data>();
        }
    }
}
