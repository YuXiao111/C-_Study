using System;
using System.Collections.Generic;
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

namespace MD5_Test
{
    /// <summary>
    /// Window1.xaml 的交互逻辑
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            Btn.Click += Btn_Click;

        }

        private void Btn_Click(object sender, RoutedEventArgs e)
        {

            // string str = "asdfghjkjll";
            //string str = TB_Text.Text;
            //MD5 mD5 = MD5.Create();
            //Byte[] bytes = mD5.ComputeHash(Encoding.Default.GetBytes(str));
            //string d5str = BitConverter.ToString(bytes);
            //d5str = d5str.Replace("-", "");
            //TB_Txt.Text = d5str;

            string str = TB_Text.Text;
            MD5CryptoServiceProvider cryptoServiceProvider = new MD5CryptoServiceProvider();
            Byte[] bytes = cryptoServiceProvider.ComputeHash(Encoding.Default.GetBytes(str));
            string d5str=BitConverter.ToString(bytes);
            d5str = d5str.Replace("-", "");
            TB_Txt.Text = d5str;
        }
    }
}
