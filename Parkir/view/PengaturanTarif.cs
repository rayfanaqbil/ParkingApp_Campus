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
using ParkirApp.view;
using ParkirApp.model;

namespace ParkirApp.view
{
    public partial class PengaturanTarif : Form
    {
        public PengaturanTarif()
        {
            InitializeComponent();
        }
       

        private void BtnTutup_Click(object sender, EventArgs e)
        {
            this.Hide();
            var ss = new Parkir();
            ss.Closed += (s, args) => this.Close();
            ss.Close();
        }

        private void PengaturanTarif_Load(object sender, EventArgs e)
        {
            Data();
        }

        public void Data()
        {
            biayaParkirBindingSource.DataSource = BiayaParkir.GetListData();
            DataGridView1.DataSource = biayaParkirBindingSource;
            TxtJeniskendaraan.Enabled = true;
            TxtTarif.Enabled = true;
    
        }

        private void BtnSimpan_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtJeniskendaraan.Text) && !string.IsNullOrEmpty(TxtTarif.Text))
            {
                BiayaParkir.Insert(TxtJeniskendaraan.Text, int.Parse(TxtTarif.Text));
                Data();
            }
     
        }

        private void BtnHapus_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(LblID.Text))
            {
                BiayaParkir.Delete(int.Parse(LblID.Text));
                Data();
            }
  
        }

        private void BtnUbah_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(LblID.Text) && !string.IsNullOrEmpty(TxtJeniskendaraan.Text) && !string.IsNullOrEmpty(TxtTarif.Text))
            {
                BiayaParkir.Update(int.Parse(LblID.Text), TxtJeniskendaraan.Text, int.Parse(TxtTarif.Text));
                Data();
            }
          
        }

        private void DataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            LblID.Text = DataGridView1.CurrentRow.Cells[0].Value.ToString();
            TxtJeniskendaraan.Text = DataGridView1.CurrentRow.Cells[1].Value.ToString();
            TxtTarif.Text = DataGridView1.CurrentRow.Cells[2].Value.ToString();

            TxtJeniskendaraan.Enabled = false;
            TxtTarif.Enabled = false;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            var ss = new Parkir();
            ss.Closed += (s, args) => this.Close();
            ss.Close();
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

        private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGridView1.CurrentRow != null)
            {
                LblID.Text = DataGridView1.CurrentRow.Cells[0].Value.ToString();
                TxtJeniskendaraan.Text = DataGridView1.CurrentRow.Cells[1].Value.ToString();
                TxtTarif.Text = DataGridView1.CurrentRow.Cells[2].Value.ToString();
            }
            
        }

        private void btnBaru_Click(object sender, EventArgs e)
        {
            TxtJeniskendaraan.Enabled = true;
            TxtTarif.Enabled = true;
            TxtJeniskendaraan.Text = string.Empty;
            TxtTarif.Text = string.Empty;
        }
    }
}
