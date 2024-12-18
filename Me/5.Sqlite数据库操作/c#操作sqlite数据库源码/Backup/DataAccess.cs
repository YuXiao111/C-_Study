using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;


//51aspx
namespace SQLiteView
{
    class DataAccess
    {
        SQLiteConnection con ;
        SQLiteCommand command;
        public DataAccess()
        {
            con = new SQLiteConnection("Data Source=test.db3");
            command = con.CreateCommand();
        }
        //读取数据表记录
        public DataTable ReadTable(string tableName)
        {
            command.CommandText = "SELECT * FROM " + tableName;
            SQLiteDataAdapter da = new SQLiteDataAdapter(command);
            DataTable dt = new DataTable(tableName);
            da.Fill(dt);
            return dt;//-5-1-a-s-p-x
        }
        //修改数据表记录
        public bool UpdateTable(DataTable srcTable, string tableName)
        {
            bool isok = false;//5~1~a~s~p~x//51aspx
            try
            {
                command.CommandText = "SELECT * FROM " + tableName;
                SQLiteDataAdapter oda = new SQLiteDataAdapter(command);
                SQLiteCommandBuilder ocb = new SQLiteCommandBuilder(oda);
                oda.InsertCommand = ocb.GetInsertCommand();
                oda.DeleteCommand = ocb.GetDeleteCommand();
                oda.UpdateCommand = ocb.GetUpdateCommand();
                oda.Update(srcTable);
                isok = true;
            }
            catch (Exception ex)
            {}
            return isok;
        }
    }
}

//---------------------------------51aspx----------------------------------------//