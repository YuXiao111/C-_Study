using SqliteForFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SqliteForFramework
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            ////1.插入数据
            //Context content = new Context();
            //Student sm= new Student();
            //sm.Id = 1;
            //sm.Age = 10;
            //sm.Grade = 100;
            //content.Students.Add(sm);
            //content.SaveChanges();


            ////2.查询数据
            //Context content = new Context();
            //foreach (var item in content.Students)
            //{
            //    MessageBox.Show("\r\tID：" + item.Id + "\r\tAge：" + item.Age + "\r\tGrade：" + item.Grade);
            //}


            ////3.修改数据
            //Context content = new Context();
            //var Num = content.Students.Where(s => s.Age == 18).FirstOrDefault();
            //if (Num != null)
            //{
            //    Num.Age = 20;
            //    content.SaveChanges();
            //}
            //else 
            //{ 
            //    MessageBox.Show("空值");
            //}


            //4.删除数据
            Context content = new Context();
            Student stu = content.Students.Where(s => s.Age == 10).FirstOrDefault();
            if (stu != null)
            {
                content.Students.Remove(stu);
                content.SaveChanges();
            }
            else
            {
                MessageBox.Show("空值");
            }


        }
    }
}
