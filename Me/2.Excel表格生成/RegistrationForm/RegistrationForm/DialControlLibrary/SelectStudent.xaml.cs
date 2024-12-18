using RegistrationForm.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// SelectStudent.xaml 的交互逻辑
    /// </summary>
    public partial class SelectStudent : UserControl
    {
        public SelectStudent()
        {
            InitializeComponent();
        }


        readonly ObservableCollection<TTest> t = new ObservableCollection<TTest>();
        public class TTest
        {
            public string Name { get; set; }
            public string Name2 { get; set; }
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            int Count = DB_Helper.SelectCountStudent();
            //string Count=   DB_Helper.SelectCountStudent();
            if (Count == 0)
            {
                return;
            }
            else
            {
                MessageBox.Show(Convert.ToString(Count));

                for (int j = 0; j < Count; j++)
                {
                    TTest t1 = new TTest
                    {

                        Name = "t.Name",
                        Name2 = "t.Name2"

                    };
                    t.Add(t1);
                }

                dataGrid1.ItemsSource = t;
            }
            //GetRawData();

        }
    }
}
