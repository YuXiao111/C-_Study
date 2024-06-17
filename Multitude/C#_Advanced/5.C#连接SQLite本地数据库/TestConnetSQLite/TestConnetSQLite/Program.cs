using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConnetSQLite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //生成数据库
            //SQLiteConnection.CreateFile("Test.db");

            //生成数据库
            SQLiteConnectionStringBuilder builder = new SQLiteConnectionStringBuilder();
            builder.DataSource = "test.db";
            string connStr=builder.ToString();
            SQLiteConnection conn=new SQLiteConnection(connStr);
            conn.Open();
            //conn.ChangePassword("123456");

            Console.WriteLine(conn.ServerVersion.ToString());
            Console.WriteLine(conn.DataSource.ToString());

            //打印Sqlite的所有表
            DataTable dataTable = conn.GetSchema("Tables");
            foreach (DataRow row in dataTable.Rows)
            {
                string name = row["Table_Name"].ToString();
                Console.WriteLine(name);
            }

            Console.ReadKey();
        }
    }
}
