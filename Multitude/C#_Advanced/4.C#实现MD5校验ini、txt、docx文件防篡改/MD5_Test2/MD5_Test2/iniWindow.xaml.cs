using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
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

namespace MD5_Test2
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class iniWindow : Window
    {
        static string iniPath = ".\\test.ini";
        static string iniMd5Path = ".\\ini.md5";

        [DllImport("kernel32")]
        private static extern bool WritePrivateProfileString(string section, string key, string data, string pash);
        public iniWindow()
        {
            InitializeComponent();


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            WritePrivateProfileString("Student", "Name", "张同学", iniPath);
            //WritePrivateProfileString("Student", "Age", "18", iniPath);
            WritePrivateProfileString("Student", "Age", "19", iniPath);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string inistr = File.ReadAllText(iniPath);
            MD5 mD5 = MD5.Create();
            Byte[] bytes = mD5.ComputeHash(Encoding.Default.GetBytes(inistr));
            string d5str = BitConverter.ToString(bytes);
            d5str = d5str.Replace("-", "");
            File.WriteAllText(iniMd5Path, d5str);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string tempiniStr = File.ReadAllText(iniPath);
            MD5 mD5 = MD5.Create();
            Byte[] bytes = mD5.ComputeHash(Encoding.Default.GetBytes(tempiniStr));
            string tempMd5Str = BitConverter.ToString(bytes);
            tempMd5Str = tempMd5Str.Replace("-", "");

            string md5verifystr = File.ReadAllText(iniMd5Path);
            if(tempMd5Str==md5verifystr)
            {
                MessageBox.Show("文件未被修改");
            }
            else
            {
                MessageBox.Show("文件被修改");
            }
        }
    }
}
