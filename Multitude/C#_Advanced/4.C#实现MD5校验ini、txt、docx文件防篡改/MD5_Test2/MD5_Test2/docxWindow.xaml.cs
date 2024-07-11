using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
using System.Windows.Shapes;
using Xceed.Words.NET;

namespace MD5_Test2
{
    /// <summary>
    /// txtWindow.xaml 的交互逻辑
    /// </summary>
    public partial class docxWindow : Window
    {
        public docxWindow()
        {
            InitializeComponent();
        }
        static string txtPath = ".\\test.docx";
        static string txtMd5Path = ".\\docx.md5";
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // 创建一个新的Word文档  
            var doc = DocX.Create(txtPath);

            // 添加一个段落  
            doc.InsertParagraph("123456");

            // 保存并关闭文档  
            doc.Save();
        }


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string inistr = File.ReadAllText(txtPath);
            MD5 mD5 = MD5.Create();
            Byte[] bytes = mD5.ComputeHash(Encoding.Default.GetBytes(inistr));
            string d5str = BitConverter.ToString(bytes);
            d5str = d5str.Replace("-", "");
            File.WriteAllText(txtMd5Path, d5str);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string tempiniStr = File.ReadAllText(txtPath);
            MD5 mD5 = MD5.Create();
            Byte[] bytes = mD5.ComputeHash(Encoding.Default.GetBytes(tempiniStr));
            string tempMd5Str = BitConverter.ToString(bytes);
            tempMd5Str = tempMd5Str.Replace("-", "");

            string md5verifystr = File.ReadAllText(txtMd5Path);
            if (tempMd5Str == md5verifystr)
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
