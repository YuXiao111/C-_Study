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
using Log日志框架.Util;

namespace Log日志框架
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


        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            LogHelper.WriteLog(typeof(MainWindow), "点击按钮1错误。", LogLevel.ALL);
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            LogHelper.WriteLog(typeof(MainWindow), "点击按钮2错误。", LogLevel.DEBUG);
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            LogHelper.WriteLog(typeof(MainWindow), "点击按钮3错误。", LogLevel.INFO);
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            LogHelper.WriteLog(typeof(MainWindow), "点击按钮4错误。", LogLevel.WARN);
        }
        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            LogHelper.WriteLog(typeof(MainWindow), "点击按钮5错误。", LogLevel.ERROR);
        }
        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            LogHelper.WriteLog(typeof(MainWindow), "点击按钮6错误。", LogLevel.FATAL);
        }
    }
}