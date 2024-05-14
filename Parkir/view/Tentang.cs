using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParkirApp.controller;
using System.Windows.Forms;
using Parkir.controller;

namespace Parkir.view
{
    public partial class Tentang : Form
    {
        public Tentang()
        {
            InitializeComponent();
        }
        Bunifu.Framework.UI.Drag MoveFrom = new Bunifu.Framework.UI.Drag();
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            MoveFrom.Release();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            MoveFrom.Grab(this);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            MoveFrom.MoveObject();
        }

        private void LblClose_Click(object sender, EventArgs e)
        {
            AboutC.tutup();
        }

        private void BtnBatal_Click(object sender, EventArgs e)
        {
            AboutC.tutup();
        }
    }
}
