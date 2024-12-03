using OfficeOpenXml;
using System.IO;
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

namespace RegistrationForm.Views
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

        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            //// 设定文件路径
            //var fileInfo = new FileInfo("Demo.xlsx");
            //ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            //// 创建Excel包
            //using (var package = new ExcelPackage(fileInfo))
            //{
            //    // 添加一个工作簿
            //    var worksheet = package.Workbook.Worksheets.Add("Sheet1");

            //    // 往工作簿中添加数据
            //    worksheet.Cells[1, 1].Value = "Hello";
            //    worksheet.Cells[1, 2].Value = "World";
            //    worksheet.Cells["A1"].Value = "通过单元格位置";
            //    worksheet.Cells[3, 4, 5, 6].Value = "填充";

            //    // 保存Excel包
            //    package.Save();
            //}
        }
    }
}