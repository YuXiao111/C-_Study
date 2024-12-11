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
using System.Windows.Shapes;
using WpfAppToJson.Util;

namespace WpfAppToJson
{
    /// <summary>
    /// ReadAndWrite.xaml 的交互逻辑
    /// </summary>
    public partial class ReadAndWrite : Window
    {
        public ReadAndWrite()
        {
            InitializeComponent();
        }

        private void ReadBtn_Click(object sender, RoutedEventArgs e)
        {
            LoadConfig();
            
        }

        private void WhiteBtn_Click(object sender, RoutedEventArgs e)
        {
            SaveConfig();
        }

        /// <summary>
        /// 保存配置信息
        /// </summary>
        private void SaveConfig()
        {
            // 配置对象实例
            Configuration config = new Configuration();
            // 保存
            config.Add("1", NameText.Text);
            config.Add("2", AgeText.Text);
            config.Add("3", AddressText.Text);

            // 保存配置信息到磁盘中
            Configuration.Save(config, @"Config\default.json");
        }

        /// <summary>
        /// 加载配置信息
        /// </summary>
        private bool LoadConfig()
        {
            Configuration config = Configuration.Read(@"Config\default.json");
            if (config == null)
            {
                return false;
            }
            // 获取
            NameText.Text = config.GetString("1");
            AgeText.Text = config.GetString("2");
            AddressText.Text = config.GetString("3");
            return true;
        }
    }
}
