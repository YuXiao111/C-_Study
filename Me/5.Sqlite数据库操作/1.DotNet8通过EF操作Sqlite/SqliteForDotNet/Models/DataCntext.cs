using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqliteForDotNet.Models
{
    public class DataContext : DbContext
    {
        /// <summary>
        /// 声明一个DbSet<Student>属性，相当于数据源
        /// </summary>
        public DbSet<Student> Students { get; set; }
        public DbSet<Class> Classs { get; set; }
        public string ConnectionString { get; set; }

        public DataContext(string dbFile)
        {
            ConnectionString = "Data Source="+Path.Combine(Environment.CurrentDirectory,dbFile);
        }

        /// <summary>
        /// 重写OnCnfiguring方法，设置数据库连接（本例中设置为程序当前目录下的Data.db）
        /// </summary>
        /// <param name="optionsBuilder"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(ConnectionString);
        }
    }
}
