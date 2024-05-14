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
    public partial class DataMasuk : UserControl
    {
        public DataMasuk()
        {
            InitializeComponent();
        }

     
        private void DataMasuk_Load(object sender, EventArgs e)
        {
            Koneksi();
            Combo();
        }

        public void Koneksi()
        {
            Timer1.Start();
            LblDate.Text = DateTime.Now.ToString("dd-MM-yyyy").ToString();
            LblTime.Text = DateTime.Now.ToString("H:mm tt").ToString();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            LblTime.Text = DateTime.Now.ToLongTimeString();
            Timer1.Start();
        }

        void Combo()
        {
            try
            {
                List<BiayaParkirM> list = BiayaParkirM.GetBiayaParkir();

                ComboxJenisKendaraan.Items.Clear();
                foreach (BiayaParkirM biayaParkir in list)
                {
                    ComboxJenisKendaraan.Items.Add(biayaParkir.Id_Kendaraan + " " + biayaParkir.Jenis_Kendaraan);
                    ComboxJenisKendaraan.ValueMember = biayaParkir.Id_Kendaraan.ToString();
                    ComboxJenisKendaraan.DisplayMember = biayaParkir.Jenis_Kendaraan.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LblDate_Click(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnSimpan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ComboxJenisKendaraan.Text) || string.IsNullOrWhiteSpace(TextboxNo.Text))
            {
                MessageBox.Show("Harap isi semua kolom!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string[] idKendaraan = ComboxJenisKendaraan.Text.Split(' ');
            DataMasukM.simpan(TextboxNo.Text, idKendaraan[0]);
            Combo();
            printPreviewDialog1.ShowDialog();
            printDocument1.Print();
            
        }

      
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            e.Graphics.DrawString(DataMasukC.PrintOut, DataMasukC.Arial, DataMasukC.drawBrush, DataMasukC.drawPoint);

            e.Graphics.DrawString(DataMasukC.Nomasuk1.ToString(), DataMasukC.Barcode, DataMasukC.drawBrush, DataMasukC.drawPoint1);
          
        }

        private void noken(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                DataMasukM.simpan(TextboxNo.Text, ComboxJenisKendaraan.Text);

            }
        }

        public void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }
    }
}
