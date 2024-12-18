using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace SQLiteView
{
    public partial class Form1 : Form
    {
        DataAccess dba;
        public Form1()
        {
            InitializeComponent();
            dba = new DataAccess();
        }
        //ˢ������Դ
        private void RefreshTable()
        {
            this.dataGridView1.DataSource = dba.ReadTable("testone");
        }
        //��������Դ
        private void UpdateTable(DataTable dt)
        {
            if (dt != null)
            {
                if (dba.UpdateTable(dt, "testone"))
                {
                    RefreshTable();
                    MessageBox.Show("OK");
                }
                else
                    MessageBox.Show("Failed");
            }
        }
        //���
        private void button1_Click(object sender, EventArgs e)
        {
            RefreshTable();
        }
        
        //�������޸�
        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt = this.dataGridView1.DataSource as DataTable;
            UpdateTable(dt);
        }
        
        //ɾ��
        private void button3_Click(object sender, EventArgs e)
        {
            DataTable dt = this.dataGridView1.DataSource as DataTable;
            DataRowView rowview = this.dataGridView1.CurrentRow.DataBoundItem as DataRowView;
            if (rowview != null)
            {
                rowview.Row.Delete();
                UpdateTable(dt);
            }
            
        }        
    }
}