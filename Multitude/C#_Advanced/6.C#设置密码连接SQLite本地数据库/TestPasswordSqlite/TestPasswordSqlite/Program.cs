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
            SqliteConnectionStringBuilder builder = new SqliteConnectionStringBuilder();
            builder.DataSource = "test.db";
            builder.Mode = SqliteOpenMode.ReadWriteCreate;
            //builder.Password = "123456";
            builder.Password = "666333";
            SqliteConnection sqliteConnection=new SqliteConnection(builder.ConnectionString);

            sqliteConnection.Open();
            Console.WriteLine(sqliteConnection.Database.ToString());

            //SqliteCommand command = sqliteConnection.CreateCommand();
            //command.CommandText = "select quote ($newPassword);";
            //command.Parameters.AddWithValue("$newPassword", "666333");
            //string passStr = command.ExecuteScalar() as string;
            //SqliteCommand sqliteCommand = sqliteConnection.CreateCommand();
            //sqliteCommand.CommandText = "pragma rekey=" + passStr;
            //sqliteCommand.Parameters.Clear();
            //sqliteCommand.ExecuteNonQuery();

            Console.ReadKey();
        }
    }
}
