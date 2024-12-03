using OfficeOpenXml;
using OfficeOpenXml.Style;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Packaging;
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
using Color = System.Drawing.Color;

namespace RegistrationForm.DialControlLibrary
{
    /// <summary>
    /// GraduateRegistrationForm.xaml 的交互逻辑
    /// </summary>
    public partial class GraduateRegistrationForm : UserControl
    {

        public GraduateRegistrationForm()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // 设定文件路径
            var fileInfo = new FileInfo($"{TableName_Text}.xlsx");
            // 设置许可
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            // 创建Excel包
            using (var package = new ExcelPackage(fileInfo))
            {
                // 添加一个工作簿，工作簿名称
                var worksheet = package.Workbook.Worksheets.Add($"{TableIteam_Text.Text}");

                // 往工作簿中添加数据
                worksheet.Cells[1, 1].Value = "Hello";
                worksheet.Cells[1, 2].Value = "World";
                worksheet.Cells["A1"].Value = "通过单元格位置";
                //worksheet.Cells[3, 4, 5, 6].Value = "填充";//添加多行数据




                #region 单元格合并
                //// 合并单元格，合并A1至B2范围内的单元格
                //worksheet.Cells["A1:B1"].Merge = true;
                //// 假设我们要设置A1单元格的内容居中
                //int row = 1;
                //int col = 1;
                //// 设置单元格的值
                //worksheet.Cells[row, col].Value = "Centered Text";
                //// 获取单元格的样式
                //var style = worksheet.Cells[row, col].Style;
                //// 设置水平居中
                //style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                //// 设置垂直居中（对于垂直居中，需要设置VerticalAlignment属性）
                //style.VerticalAlignment = ExcelVerticalAlignment.Center;
                #endregion


                //// 假设我们要合并从第2行第2列到第2行第4列的单元格（即B2:D2）
                //int startRow = 2;
                //int startCol = 2; // B列是第二列
                //int endRow = 2;
                //int endCol = 4; // D列是第四列

                //// 合并单元格
                //// worksheet.Merge(startRow, startCol, endRow, endCol);

                //// 可选：设置合并后单元格的样式
                //var mergedCell = worksheet.Cells[startRow, startCol];
                //mergedCell.Value = "Merged Cell";
                //mergedCell.Style.Font.Bold = true;
                //mergedCell.Style.Fill.PatternType = ExcelFillStyle.Solid;
                ////mergedCell.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightBlue);//单元格颜色

                // 保存Excel包
                package.Save();
            }
        }

        public void CreateExcelWithStyledIsMerged(string filePath, int Row, int Col, string value, ExcelHorizontalAlignment? horizontalAlignment = null, ExcelVerticalAlignment? verticalAlignment = null)
        {
            using (ExcelPackage package = new ExcelPackage())
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets.Add($"{TableIteam_Text.Text}");
                // 合并单元格，合并A1至B2范围内的单元格
                worksheet.Cells["A1:B1"].Merge = true;
                // 假设我们要设置A1单元格的内容居中
                int row = Row;
                int col = Col;
                // 设置单元格的值
                worksheet.Cells[row, col].Value = value;
                // 获取单元格的样式
                var style = worksheet.Cells[row, col].Style;
                //// 设置水平居中
                //style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                //// 设置垂直居中（对于垂直居中，需要设置VerticalAlignment属性）
                //style.VerticalAlignment = ExcelVerticalAlignment.Center;

                // 设置水平对齐（如果提供了值）
                if (horizontalAlignment.HasValue)
                {
                    style.HorizontalAlignment = horizontalAlignment.Value;
                }

                // 设置垂直对齐（如果提供了值）
                if (verticalAlignment.HasValue)
                {
                    style.VerticalAlignment = verticalAlignment.Value;
                }

                //// 保存Excel文件
                //FileInfo fi = new FileInfo(filePath);
                //package.SaveAs(fi);
            }
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
        

            //ExcelHelper helper = new ExcelHelper();
            string filePath = "styled_excel.xlsx";

            // 准备要写入的数据

            var data1 = new (int, int, string, double, Color, ExcelHorizontalAlignment, ExcelVerticalAlignment)[]
                {( 1,2,"Hello, World!", 14, Color.Red,ExcelHorizontalAlignment.Center, ExcelVerticalAlignment.Center),
                 ( 2,2,"Another Row",  12,Color.Blue, ExcelHorizontalAlignment.Center, ExcelVerticalAlignment.Center),
                 // ... 可以继续添加更多数据
                };
            // 调用方法创建并保存Excel文件
            CreateAndSaveExcel(filePath, data1);
            MessageBox.Show("保存成功!");
        }


        // 添加一个重载方法，接受一个行号参数
        public void CreateExcelWithStyledCell(ExcelPackage package, int row, int col, string value,
            double? fontSize = null, Color? fontColor = null,
            ExcelHorizontalAlignment? horizontalAlignment = null, ExcelVerticalAlignment? verticalAlignment = null)
        {
            ExcelWorksheet worksheet = package.Workbook.Worksheets[0]; // 假设始终操作第一个工作表

            // 设置单元格的值
            worksheet.Cells[row, col].Value = value;

            // 获取单元格的样式
            var style = worksheet.Cells[row, col].Style;

            // 设置字体大小（如果提供了值）
            if (fontSize.HasValue)
            {
                style.Font.Size = (float)fontSize.Value;
            }

            // 设置字体颜色（如果提供了值）
            if (fontColor.HasValue)
            {
                style.Font.Color.SetColor(fontColor.Value);
            }

            // 合并单元格（这里需要根据实际情况调整合并逻辑，可能不需要每次都合并）
            // if (isMerged.HasValue && isMerged.Value)
            // {
            //     // ...合并逻辑，注意这里可能不需要每次都合并
            // }

            // 注意：通常你不会为单个单元格调用合并，而是为一系列单元格调用。
            // 如果你确实需要合并，请确保合并逻辑正确，并且不会意外覆盖之前的合并。

            // 设置水平对齐（如果提供了值）
            if (horizontalAlignment.HasValue)
            {
                style.HorizontalAlignment = horizontalAlignment.Value;
            }

            // 设置垂直对齐（如果提供了值）
            if (verticalAlignment.HasValue)
            {
                style.VerticalAlignment = verticalAlignment.Value;
            }
        }

        // 提供一个方法来初始化Excel包和追踪行号
        public void CreateAndSaveExcel(string filePath, (int, int, string, double,  Color, ExcelHorizontalAlignment, ExcelVerticalAlignment)[] data)
        {
            // 设置许可
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (ExcelPackage package = new ExcelPackage())
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Sheet1");

                //int currentRow = 1; // 从第一行开始

                foreach (var item in data)
                {
                    CreateExcelWithStyledCell(package, item.Item1, item.Item2, item.Item3, item.Item4, item.Item5, horizontalAlignment: ExcelHorizontalAlignment.Center, verticalAlignment: ExcelVerticalAlignment.Center);
                    //currentRow++; // 递增行号以便下次调用时使用
                }

                // 保存Excel文件
                FileInfo fi = new FileInfo(filePath);
                package.SaveAs(fi);
            }
        }


    }
}
