using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;

namespace SQLite_idqm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SQLiteConnection constr = new SQLiteConnection("Data Source=" + Application.StartupPath + @"\sqlite.db;");

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "Create table basedata(user varchar(20),pwd varchar(20))";
            SQLiteCommand command = new SQLiteCommand();
            command.CommandText = sql;
            command.Connection = constr;
            command.ExecuteNonQuery();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            constr.Open();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            SQLiteConnection.CreateFile(Application.StartupPath + @"\sqlite.db");
        }

        private void button3_Click(object sender, EventArgs e)
        {

            listBox1.Items.Clear();
            string sql = "Select * from basedata";

            SQLiteDataReader command = new SQLiteCommand(sql,constr).ExecuteReader ();

            for (int i = 0; command.Read(); i++)
            {
                listBox1.Items.Add(command.GetString(0));
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string sql = "insert into basedata([user]) values('123');";

            SQLiteCommand command = new SQLiteCommand();
            command.Connection = constr;
            command.CommandText = sql;
            command.ExecuteNonQuery();
            listBox1.Items.Clear();
            button3_Click(null,null);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string sql = "delete from basedata where [user]='123';";
            SQLiteCommand command = new SQLiteCommand();
            command.Connection = constr;
            command.CommandText = sql;
            command.ExecuteNonQuery();
            listBox1.Items.Clear();
            button3_Click(null, null);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string sql = "update basedata set [user]='" + "888" + "' where [user]=" + "123" + ";";
            SQLiteCommand command = new SQLiteCommand();
            command.Connection = constr;
            command.CommandText = sql;
            command.ExecuteNonQuery();
            listBox1.Items.Clear();
            button3_Click(null, null);
        }
    }
}
