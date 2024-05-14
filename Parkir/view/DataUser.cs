using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ParkirApp.controller;
using ParkirApp.model;
namespace ParkirApp.view
{
    public partial class DataUser : Form
    {
        public DataUser()
        {
            InitializeComponent();
        }

        MySqlConnection connection = new MySqlConnection("datasource=localhost;Initial Catalog='db_parkir';port=3306;username=root;password=;");

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DataUser_Load(object sender, EventArgs e)
        {
            Data();

        }
        public void Data()
        {
            DataGridView1.DataSource = DataUserM.GetListData();


        }

        private void PrintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap objBmp = new Bitmap(this.DataGridView1.Width, this.DataGridView1.Height);
            DataGridView1.DrawToBitmap(objBmp, new Rectangle(0, 0, this.DataGridView1.Width, this.DataGridView1.Height));

            e.Graphics.DrawImage(objBmp, 120, 100);

            e.Graphics.DrawString(Label1.Text, new Font("Verdana", 30, FontStyle.Bold), Brushes.Black, new Point(300, 30));
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog1.Document = PrintDocument1;
            PrintPreviewDialog1.ShowDialog();
        }

        private void BtnBatal_Click(object sender, EventArgs e)
        {

            DataUserC.tutup();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {

            DataUserC.tutup();
        }

        Bunifu.Framework.UI.Drag MoveFrom = new Bunifu.Framework.UI.Drag();
        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            MoveFrom.Grab(this);
        }

        private void Panel1_MouseUp(object sender, MouseEventArgs e)
        {
            MoveFrom.Release();
        }

        private void Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            MoveFrom.MoveObject();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (DataGridView1.SelectedRows.Count > 0)
            {
                int selectedRowIndex = DataGridView1.SelectedRows[0].Index;
                string idPetugas = DataGridView1.Rows[selectedRowIndex].Cells["id_petugas"].Value.ToString();

                DialogResult result = MessageBox.Show("Anda yakin ingin menghapus data ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    DataUserM.HapusData(idPetugas);

                    Data();

                    MessageBox.Show("Data berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}

