using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
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

namespace WpfAppToJson
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Math_Btn_Click(object sender, RoutedEventArgs e)
        {
            double x = Convert.ToDouble(Resistance_Text.Text);
            if (x < 384.96 || x > 31543.93)
            {
                MessageBox.Show("输入的值不在范围内");
                return;
            }
            double[] a = new double[121] { 31543.93, 30059.92, 28650.3, 27311.26, 26039.18, 24830.65, 23682.38, 22591.27, 21554.4, 20568.96, 19632.31, 18741.93, 17895.44, 17090.57, 16325.19, 15597.26, 14904.86, 14246.16, 13619.42, 13023.02, 12455.39, 11915.07, 11400.65, 10910.83, 10444.34, 10000, 9576.68, 9173.33, 8788.94, 8422.54, 8073.23, 7740.16, 7422.51, 7119.51, 6830.43, 6554.59, 6291.32, 6040, 5800.05, 5570.9, 5352.03, 5142.94, 4943.14, 4752.2, 4569.67, 4395.16, 4228.28, 4068.66, 3915.95, 3769.84, 3630, 3496.14, 3367.97, 3245.24, 3127.68, 3015.06, 2907.14, 2803.71, 2704.56, 2609.5, 2518.33, 2430.89, 2347, 2266.5, 2189.24, 2115.07, 2043.86, 1975.47, 1909.78, 1846.67, 1779, 1719.28, 1662.11, 1607.35, 1554.86, 1504.51, 1456.18, 1409.77, 1365.16, 1322.27, 1281, 1241.27, 1203, 1166.11, 1130.55, 1096.24, 1063.13, 1031.15, 1000.26, 970.4, 941.54, 913.62, 886.6, 860.45, 835.13, 810.6, 786.83, 763.8, 741.47, 719.81, 698.8, 678.42, 658.64, 639.44, 620.79, 602.69, 585.11, 568.02, 551.43, 535.3, 519.63, 504.4, 489.59, 475.19, 461.2, 447.59, 434.35, 421.49, 408.97, 396.8, 384.96 };

            // 遍历数组a
            for (int i = 0; i < 120; i++)
            {
                // x位于a[i]和a[i+1]之间
                if (x <= a[i] && x >= a[i + 1])
                {

                    double x1 = a[i], x2 = a[i + 1];
                    double y1 = i;
                    double y = 0;
                    double k = 1 / (x2 - x1);
                    y = k * (x - x1) + y1;
                    double zhi = Math.Round(y, 1);
                    //// 记录到data数组中
                    //data[j - 1, t] = zhi;
                    //// t用于记录所在列
                    //t++;
                    //// 添加当前数据到builder中
                    //builder.Append(zhi.ToString() + ",");
                    //break;
                    Temperature_Text.Text = Convert.ToString(zhi);
                }
            }
        }
    }
}
