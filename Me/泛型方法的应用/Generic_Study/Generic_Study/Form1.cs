using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Generic_Study
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Form2 form2 = new Form2();
            //form2.Show();

            //方法1
            //Form2 form2 = Application.OpenForms.OfType<Form2>().FirstOrDefault();
            //if (form2 == null || form2.IsDisposed)
            //{
            //    form2 = new Form2();
            //    form2.Show();
            //}
            //else
            //{
            //    form2.Activate();
            //}

            //方法2
            OpenOrActivateForm<Form2>();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            //Form3 form3 = new Form3();
            //form3.Show();

            //Form3 form3 = Application.OpenForms.OfType<Form3>().FirstOrDefault();
            //if (form3 == null || form3.IsDisposed)
            //{
            //    form3 = new Form3();
            //    form3.Show();
            //}
            //else
            //{
            //    form3.Activate();
            //}

            //方法2
            OpenOrActivateForm<Form3>();
        }

        private void OpenOrActivateForm<T>() where T : Form, new()
        {
            T form = Application.OpenForms.OfType<T>().FirstOrDefault();
            if (form == null || form.IsDisposed)
            { 
                form = new T();
                form.Show();
            }
            else 
            {
                form.Activate(); 
            }
        }
    }
}
