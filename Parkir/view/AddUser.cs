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
using ParkirApp.controller;
namespace ParkirApp.view
{
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        MySqlConnection connection = new MySqlConnection("datasource=localhost;Initial Catalog='db_parkir';port=3306;username=root;password=;");

        private void AddUser_Load(object sender, EventArgs e)
        {

        }

        private void BtnSimpan_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(TxtboxUsername.Text) || string.IsNullOrWhiteSpace(TxtboxPassword.Text) || string.IsNullOrWhiteSpace(TxtboxNama.Text) || string.IsNullOrWhiteSpace(TxtboxAlamat.Text) ||
                string.IsNullOrWhiteSpace(TxtboxNoHp.Text) || string.IsNullOrWhiteSpace(comboBoxprivillage.Text))
            {
                MessageBox.Show("Periksa Textbox Kembali!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

            bool isSuccess = AddUserM.Insert(TxtboxUsername.Text, TxtboxPassword.Text, TxtboxNama.Text, TxtboxAlamat.Text, TxtboxNoHp.Text, comboBoxprivillage.Text);

            if (isSuccess)
            {
                MessageBox.Show("Data berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnBatal_Click(object sender, EventArgs e)
        {
            
            AddUserC.tutup();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            AddUserC.tutup();
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
    }
}
