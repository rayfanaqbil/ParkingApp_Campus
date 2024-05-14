using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using MySql.Data.MySqlClient;
using ParkirApp.model;
using ParkirApp.controller;
namespace ParkirApp.view
{
    public partial class Camera : Form
    {
        public Camera()
        {
            InitializeComponent();
        }

        
    
        
        private FilterInfoCollection CaptureDevice;
        private VideoCaptureDevice FinalFrame;
       

        public string textcode
        {
            get { return this.textBox1.Text; }
            set { this.textBox1.Text = value; }
        }

        private void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            try
            {
                pictureBox2.Image = (Image)eventArgs.Frame.Clone();
            }
            catch (Exception ex) { }

        }
        private void LblClose_Click(object sender, EventArgs e)
        {
            
            CameraC.tutup(FinalFrame);
            
        }

        private void LblBatal_Click(object sender, EventArgs e)
        {
            
            CameraC.tutup(FinalFrame);
       
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btn_webcam_Click(object sender, EventArgs e)
        {
            FinalFrame = new VideoCaptureDevice(CaptureDevice[comboBox1.SelectedIndex].MonikerString);
            FinalFrame.NewFrame += new NewFrameEventHandler(FinalFrame_NewFrame);
            
            FinalFrame.Start();
            btn_webcam.Enabled = false;
            btn_scanner.Enabled = true;
        }

        private void btn_scanner_Click(object sender, EventArgs e)
        {
            timer1.Start();
            btn_scanner.Enabled = false;
            textBox1.Text = "";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                BarcodeReader Reader = new BarcodeReader();
                Result result = Reader.Decode((Bitmap)pictureBox2.Image);
                string decoded = result.ToString().Trim();
                textBox1.Text = decoded;
               


                if (CameraM.keluar(decoded).Rows.Count > 0)
                {
                    timer1.Stop();
                    CameraM.update(decoded);
                    textBox1.Text = decoded;
                    timer1.Start();

                }
                else
                {
                    timer1.Stop();
                    btn_scanner.Enabled = true;
                    textBox1.Text = decoded;
                    MessageBox.Show("error,no tidak ada dalam database");
                    
                }

            }
            catch (Exception ex)
            {

            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            CaptureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo Device in CaptureDevice)
            {
                comboBox1.Items.Add(Device.Name);
            }
            comboBox1.SelectedIndex = 0;
            FinalFrame = new VideoCaptureDevice();
        }
    }
}
