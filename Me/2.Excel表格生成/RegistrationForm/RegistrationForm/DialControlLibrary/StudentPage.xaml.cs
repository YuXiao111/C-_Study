using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace RegistrationForm.DialControlLibrary
{
    /// <summary>
    /// StudentPage.xaml 的交互逻辑
    /// </summary>
    public partial class StudentPage : UserControl
    {
        public StudentPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if (string.IsNullOrEmpty(NameText.Text))
            {
                MessageBox.Show("姓名不能为空！");
                return;
            }
            try
            {
                // 获取当前执行目录
                string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
                // 设置Excel模板的路径
                string filePath = System.IO.Path.Combine(currentDirectory, "Template.xlsx");

                // 检查文件是否存在
                if (!File.Exists(filePath))
                {
                    MessageBox.Show("Excel模板文件不存在！");
                    return;
                }
                // 设置许可
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                // 使用FileInfo对象加载Excel文件
                FileInfo existingFile = new FileInfo(filePath);

                // 使用EPPlus打开Excel包
                using (ExcelPackage package = new ExcelPackage(existingFile))
                {
                    // 获取工作表（假设模板中只有一个工作表，或者你知道工作表的名称）
                    ExcelWorksheet worksheet = package.Workbook.Worksheets[0];

                    // 插入数据（例如，在A1单元格插入数据）
                    worksheet.Cells[2, 2].Value = NameText.Text;

                    if (Sex1.IsSelected)
                    {
                        worksheet.Cells[2, 4].Value = "男";
                    }
                    else
                    {
                        worksheet.Cells[2, 4].Value = "女";
                    }
                    // 插入更多数据（例如，在B2单元格插入数据）
                    worksheet.Cells[3, 2].Value = Name2Text.Text;
                    worksheet.Cells[3, 4].Value = BithdayText.Text;
                    worksheet.Cells[4, 2].Value = minzuText.Text;
                    worksheet.Cells[4, 4].Value = zzText.Text;
                    worksheet.Cells[5, 2].Value = jiguanText.Text;
                    worksheet.Cells[5, 4].Value = jkText.Text;

                    Models.DB_Helper.InsertStudent(NameText.Text, "男", Name2Text.Text,Convert.ToDateTime( BithdayText.Text), minzuText.Text, zzText.Text, jiguanText.Text, jkText.Text);
                    // 获取当前用户的桌面路径
                    string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                    DateTime DT = DateTime.Now;
                    string D1 = DT.ToString("yyyy-MM-dd");
                    string D2 = DT.ToString("HH-mm-ss");
                    // 保存修改后的Excel文件
                    string newFilePath = System.IO.Path.Combine(desktopPath, "安徽师范大学毕业生表格" + NameText.Text + "[" + D1 + "][" + D2 + "].xlsx");
                    FileInfo newFile = new FileInfo(newFilePath);
                    package.SaveAs(newFile);

                    MessageBox.Show("已在电脑桌面创建文件！");

                }
            }
            catch
            {
                MessageBox.Show("文件创建异常");
            }

        }
    }
}
