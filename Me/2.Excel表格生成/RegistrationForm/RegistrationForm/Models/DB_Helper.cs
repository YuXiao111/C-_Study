using Microsoft.Data.Sqlite;
using RegistrationForm.DialControlLibrary;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RegistrationForm.DialControlLibrary.SelectStudent;

namespace RegistrationForm.Models
{
    public class DB_Helper
    {
        private static SqliteConnectionStringBuilder builder = new SqliteConnectionStringBuilder();

        public static void OpenSql()
        {
            builder.DataSource = "RegistrationForm.db";
            builder.Mode = SqliteOpenMode.ReadWriteCreate;
            builder.Password = "123456";
        }
        public static void CreateSql()
        {
            //创建数据库
            OpenSql();
            SqliteConnection sqliteConnection = new SqliteConnection(builder.ConnectionString);
            sqliteConnection.Open();
            SqliteCommand command = sqliteConnection.CreateCommand();
            //创建表
            command.CommandText = @"create table if not exists 'StudentTable'(
                                        Id Integer not null primary key autoIncrement,
                                        Name Text,
                                        Sex Text,
                                        Name2 Text,
                                        Bithday DateTime,
                                        Minzu Text,
                                        Zz Text,
                                        Jiguan Text,
                                        Jk Text)";
            int ret = command.ExecuteNonQuery();
            sqliteConnection.Close();

        }
        /// <summary>
        /// 增删改
        /// </summary>
        public static void InsertSql(string sql)
        {
            OpenSql();
            SqliteConnection sqliteConnection = new SqliteConnection(builder.ConnectionString);
            //添加数据
            sqliteConnection.Open();
            SqliteCommand command = sqliteConnection.CreateCommand();
            command = sqliteConnection.CreateCommand();
            command.CommandText = sql;
            int ret = command.ExecuteNonQuery();
            sqliteConnection.Close();
        }

        /// <summary>
        /// 插入一组学生信息
        /// </summary>
        /// <param name="name"></param>
        /// <param name="sex"></param>
        /// <param name="name2"></param>
        /// <param name="bithday"></param>
        /// <param name="minzu"></param>
        /// <param name="zz"></param>
        /// <param name="jiguan"></param>
        /// <param name="jk"></param>
        public static void InsertStudent(string name, string sex, string name2, DateTime bithday, string minzu, string zz, string jiguan, string jk)
        {
            string Sql = @"insert into StudentTable('Name','Sex','Name2','Bithday','Minzu','Zz','Jiguan','Jk') values ('" + name + "','" + sex + "','" + name2 + "','" + bithday + "','" + minzu + "','" + zz + "','" + jiguan + "','" + jk + "')";
            InsertSql(Sql);
        }

        public static void SelectStudent()
        {
            OpenSql();
            SqliteConnection sqliteConnection = new SqliteConnection(builder.ConnectionString);
            //查询数据
            sqliteConnection.Open();
            SqliteCommand command = sqliteConnection.CreateCommand();
            command = sqliteConnection.CreateCommand();
            command.CommandText = @"select*from StudentTable";
            SqliteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(reader["Id"]);
                Console.WriteLine(reader["Name"]);
                Console.WriteLine(reader["Name2"]);
            }
            sqliteConnection.Close();
        }

        public static int SelectCountStudent()
        {
            //string Sql = @"select count(*) from StudentTable";
            //InsertSql(Sql);

            OpenSql();
            SqliteConnection sqliteConnection = new SqliteConnection(builder.ConnectionString);
            sqliteConnection.Open();
            SqliteCommand command = sqliteConnection.CreateCommand();
            command = sqliteConnection.CreateCommand();
            command.CommandText = @"select count(*) from StudentTable";
            SqliteDataReader reader = command.ExecuteReader();

            // string result = Convert.ToString(command.ExecuteScalar());
            int result = reader.FieldCount;
            sqliteConnection.Close();
            return result;

        }
    }
}
