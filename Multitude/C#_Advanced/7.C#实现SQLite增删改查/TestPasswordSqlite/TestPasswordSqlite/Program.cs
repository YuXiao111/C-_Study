using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPasswordSqlite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //创建数据库
            SqliteConnectionStringBuilder builder = new SqliteConnectionStringBuilder();
            builder.DataSource = "test.db";
            builder.Mode = SqliteOpenMode.ReadWriteCreate;
            builder.Password = "123456";
            //builder.Password = "666333";
            SqliteConnection sqliteConnection = new SqliteConnection(builder.ConnectionString);

            sqliteConnection.Open();


            ////更改密码
            //SqliteCommand command = sqliteConnection.CreateCommand();
            //command.CommandText = "select quote ($newPassword);";
            //command.Parameters.AddWithValue("$newPassword", "123456");
            //string passStr = command.ExecuteScalar() as string;
            //SqliteCommand sqliteCommand = sqliteConnection.CreateCommand();
            //sqliteCommand.CommandText = "pragma rekey=" + passStr;
            //sqliteCommand.Parameters.Clear();
            //sqliteCommand.ExecuteNonQuery();

            //创建表
            SqliteCommand command = sqliteConnection.CreateCommand();
            command.CommandText = @"create table if not exists 'student'(Id Integer not null primary key autoIncrement,Name Text,Age Interger)";
            int ret = command.ExecuteNonQuery();
            sqliteConnection.Close();


            //添加数据
            sqliteConnection.Open();
            command = sqliteConnection.CreateCommand();
            command.CommandText = @"insert into student('Name','Age') values ('刘同学',18)";
            ret = command.ExecuteNonQuery();
            sqliteConnection.Close();

            //修改数据
            sqliteConnection.Open();
            command = sqliteConnection.CreateCommand();
            command.CommandText = @"update student set Name='陈同学' where Id=2";
            ret = command.ExecuteNonQuery();
            sqliteConnection.Close();


            //删除数据
            sqliteConnection.Open();
            command = sqliteConnection.CreateCommand();
            command.CommandText = @"delete from student where Id=4";
            ret = command.ExecuteNonQuery();
            sqliteConnection.Close();

            //查询数据
            sqliteConnection.Open();
            command = sqliteConnection.CreateCommand();
            command.CommandText = @"select*from student";
            SqliteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(reader["Id"]);
                Console.WriteLine(reader["Name"]);
                Console.WriteLine(reader["Age"]);
            }
            sqliteConnection.Close();



            Console.WriteLine(ret);
            Console.WriteLine(sqliteConnection.Database.ToString());
            Console.ReadKey();
        }
    }
}
