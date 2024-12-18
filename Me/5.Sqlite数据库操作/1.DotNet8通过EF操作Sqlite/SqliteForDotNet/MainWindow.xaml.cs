using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using SqliteForDotNet.Models;

namespace SqliteForDotNet
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        
        }
        /*
         1.安装NuGet包： Microsoft.EntityFrameworkCore.Sqlite
         2.创建一个数据表类Student
        设置表名、主键、非空
        重写ToString（）方法，方便输出查看

        3.创建一个操作数据库的类DataContext，继承自DbContext
        声明一个DbSet<Student>属性，相当于数据源
        重写OnCnfiguring方法，设置数据库连接（本例中设置为程序当前目录下的Data.db）

        4.插入数据
        5.查询数据
        6.修改数据
        7.删除数据

         */
       
    }
}