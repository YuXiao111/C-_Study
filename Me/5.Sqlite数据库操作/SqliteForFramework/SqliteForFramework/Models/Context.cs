using SQLite.CodeFirst;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqliteForFramework.Models
{
    public class Context:DbContext
    {
        public Context() : base("sqliteconn")
        {
        }
        //定义一个方法来操作数据库
        public DbSet<Student> Students { get; set; }

        /// <summary>
        /// 数据库创建的时候用
        /// </summary>
        /// <param name="modelBuilder">代码优先的模式</param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Database类:创建、删除和检查数据库的存在的类
            //SetInitializer:初始化数据库
            //SqliteCreateDatabaseIfNotExists:如果没有表就创建一个
            Database.SetInitializer(new SqliteCreateDatabaseIfNotExists<Context>(modelBuilder));
        }

    }
}
