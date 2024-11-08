using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Principal;
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

namespace Document_Security
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        static string txtFile = ".\\test.txt";
        static string docxFile = ".\\test.docx";
        public MainWindow()
        {
            InitializeComponent();
            //FileSecurity fileSecurity=File.GetAccessControl(txtFile);

            FileSecurity fileSecurity = File.GetAccessControl(txtFile);
            AuthorizationRuleCollection rules = fileSecurity.GetAccessRules(true, true, typeof(NTAccount));
            WindowsIdentity currentUser = WindowsIdentity.GetCurrent();
            foreach (FileSystemAccessRule rule in rules)
            {
                if (currentUser.User.Equals(rule.IdentityReference))
                {
                    if ((rule.FileSystemRights & FileSystemRights.Read) == FileSystemRights.Read)
                    {
                        MessageBox.Show("Current user has read access to the file.");
                    }
                    break;
                }
            }
        }
    }
}
