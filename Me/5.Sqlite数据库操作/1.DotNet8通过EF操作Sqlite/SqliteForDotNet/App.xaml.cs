using Microsoft.EntityFrameworkCore.Query.Internal;
using SqliteForDotNet.Models;
using System.Configuration;
using System.Data;
using System.Windows;

namespace SqliteForDotNet
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        protected override void OnStartup(StartupEventArgs e)
        {
            InitSql();
        }

        void InitSql()
        {
            using (DataContext db = new DataContext("Data.db"))
            {
                db.Database.EnsureCreated();//自动创建数据库和表，如果存在，则不会做任何操作

                ////4.插入数据
                //for (int i = 0; i < 5; i++)
                //{
                //    db.Add(new Student
                //    {
                //        Guid = Guid.NewGuid().ToString().ToUpper(),
                //        Name = "Test" + i.ToString(),
                //        Age = 10 + i * 5
                //    });
                //}
                //db.SaveChanges();//保存到数据库


                ////5.查询数据
                //foreach (Student stu in db.Students)
                //{
                //    MessageBox.Show(stu.ToString());
                //}

                //6.修改数据
                //db.Students.Where(s => s.Name == "Test0").First().Age = 50;
                //db.SaveChanges();

                ////7.删除数据
                //Student student = db.Students.Where(s => s.Age == 50).FirstOrDefault();
                //if (student != null)
                //{
                //    db.Remove(student);
                //    db.SaveChanges();
                //}
                //else
                //{
                //    MessageBox.Show("没有需要删除的数据");
                //}
            }
        }
    }

}
