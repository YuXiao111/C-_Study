using SqliteForFramework.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
            SelectData();
        }
        /// <summary>
        /// 数据库的增删改查
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
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


            ////4.删除数据
            //Context content = new Context();
            //Student stu = content.Students.Where(s => s.Age == 10).FirstOrDefault();
            //if (stu != null)
            //{
            //    content.Students.Remove(stu);
            //    content.SaveChanges();
            //}
            //else
            //{
            //    MessageBox.Show("空值");
            //}
        }

        ////2.修改数据
        private void Update_Click(object sender, RoutedEventArgs e)
        {
            Context content = new Context();
            int i = -1;
            foreach (var item in content.Students)
            {
                i++;
                item.Grade = studentTables[i].grade;
            }
            content.SaveChanges();
        }

        private void Factory_Click(object sender, RoutedEventArgs e)
        {
            //先删除整张表
            Context content = new Context();
            foreach (var item in content.Students)
            {
                content.Students.Remove(item);
            }
            content.SaveChanges();


            studentTables.Clear();

            //将表复制过来
            foreach (var item in content.StudentFactories)
            {
                StudentTable T1 = new StudentTable { id = item.Id, age = item.Age, grade = item.Grade };
                studentTables.Add(T1);
            }

            Student sm = new Student();
            foreach (var item in studentTables)
            {
                sm.Age = item.age;
                sm.Grade = item.grade;
                content.Students.Add(sm);
                content.SaveChanges();
            }
            SelectData();
        }


        readonly ObservableCollection<StudentTable> studentTables = new ObservableCollection<StudentTable>();

        ////1.查询数据
        private void SelectData()
        {
            studentTables.Clear();
            Context content = new Context();
            foreach (var item in content.Students)
            {
                StudentTable T1 = new StudentTable { id = item.Id, age = item.Age, grade = item.Grade };
                studentTables.Add(T1);
            }
            dataGrid1.ItemsSource = studentTables;
        }

        private void Select_Click(object sender, RoutedEventArgs e)
        {
            Context content = new Context();
            Student stu = content.Students.Where(s => s.Id == 2).FirstOrDefault();
            MessageBox.Show(stu.Grade.ToString());
        }
    }
}
