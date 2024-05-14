using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ParkirApp.model;
using ParkirApp.controller;

namespace ParkirApp.view
{
    public partial class DataKeluar : UserControl
    {
        public DataKeluar()
        {
            InitializeComponent();
        }

        private void DataKeluar_Load(object sender, EventArgs e)
        {
            DataGridView1.DataSource = DataKeluarM.GetListData();
            Timer1.Start();
            LblDate.Text = DateTime.Now.ToString("dd-MM-yyyy").ToString();
            LblTime.Text = DateTime.Now.ToString("H:mm tt").ToString();

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            LblTime.Text = DateTime.Now.ToLongTimeString();
            Timer1.Start();
        }

        private void BtnCari_Click(object sender, EventArgs e)
        {
          
            DataKeluarM.UpdateData4(TextboxNoMasuk.Text,TextboxNoKendaraan.Text);
            DataGridView1.DataSource = DataKeluarM.GetListData();

        }

        private void barcode_Click(object sender, EventArgs e)
        {
            DataKeluarC.barcode();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridView1.DataSource = DataKeluarM.GetListData();
        }

        private void noken2(object sender, EventArgs e)
        {
          
        }

        private void nosuk(object sender, KeyEventArgs e)
        {
            
        }
    }
}
