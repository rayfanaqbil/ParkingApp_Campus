﻿namespace ParkirApp.view
{
    partial class Laporan
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Laporan));
            this.Panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnTampilkan = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Datepicker2 = new Bunifu.Framework.UI.BunifuDatepicker();
            this.Datepicker1 = new Bunifu.Framework.UI.BunifuDatepicker();
            this.LblTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnPrint = new Bunifu.Framework.UI.BunifuFlatButton();
            this.PrintDocument1 = new System.Drawing.Printing.PrintDocument();
            this.PrintPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.btnExportExcel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Panel1.Controls.Add(this.label3);
            this.Panel1.Controls.Add(this.label2);
            this.Panel1.Controls.Add(this.BtnTampilkan);
            this.Panel1.Controls.Add(this.Datepicker2);
            this.Panel1.Controls.Add(this.Datepicker1);
            this.Panel1.Controls.Add(this.LblTime);
            this.Panel1.Controls.Add(this.label1);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(693, 130);
            this.Panel1.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(369, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Sampai tanggal :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(25, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Dari tanggal :";
            // 
            // BtnTampilkan
            // 
            this.BtnTampilkan.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BtnTampilkan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnTampilkan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BtnTampilkan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnTampilkan.BorderRadius = 0;
            this.BtnTampilkan.ButtonText = "TAMPILKAN";
            this.BtnTampilkan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnTampilkan.DisabledColor = System.Drawing.Color.Gray;
            this.BtnTampilkan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTampilkan.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnTampilkan.Iconimage = null;
            this.BtnTampilkan.Iconimage_right = null;
            this.BtnTampilkan.Iconimage_right_Selected = null;
            this.BtnTampilkan.Iconimage_Selected = null;
            this.BtnTampilkan.IconMarginLeft = 0;
            this.BtnTampilkan.IconMarginRight = 0;
            this.BtnTampilkan.IconRightVisible = true;
            this.BtnTampilkan.IconRightZoom = 0D;
            this.BtnTampilkan.IconVisible = true;
            this.BtnTampilkan.IconZoom = 90D;
            this.BtnTampilkan.IsTab = false;
            this.BtnTampilkan.Location = new System.Drawing.Point(544, 12);
            this.BtnTampilkan.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnTampilkan.Name = "BtnTampilkan";
            this.BtnTampilkan.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BtnTampilkan.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BtnTampilkan.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnTampilkan.selected = false;
            this.BtnTampilkan.Size = new System.Drawing.Size(131, 41);
            this.BtnTampilkan.TabIndex = 16;
            this.BtnTampilkan.Text = "TAMPILKAN";
            this.BtnTampilkan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnTampilkan.Textcolor = System.Drawing.Color.White;
            this.BtnTampilkan.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTampilkan.Click += new System.EventHandler(this.BtnTampilkan_Click);
            // 
            // Datepicker2
            // 
            this.Datepicker2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Datepicker2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Datepicker2.BorderRadius = 0;
            this.Datepicker2.ForeColor = System.Drawing.Color.White;
            this.Datepicker2.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.Datepicker2.FormatCustom = null;
            this.Datepicker2.Location = new System.Drawing.Point(372, 91);
            this.Datepicker2.Name = "Datepicker2";
            this.Datepicker2.Size = new System.Drawing.Size(303, 36);
            this.Datepicker2.TabIndex = 13;
            this.Datepicker2.Value = new System.DateTime(2017, 12, 2, 20, 3, 39, 491);
            // 
            // Datepicker1
            // 
            this.Datepicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Datepicker1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Datepicker1.BorderRadius = 0;
            this.Datepicker1.ForeColor = System.Drawing.Color.White;
            this.Datepicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.Datepicker1.FormatCustom = null;
            this.Datepicker1.Location = new System.Drawing.Point(28, 91);
            this.Datepicker1.Name = "Datepicker1";
            this.Datepicker1.Size = new System.Drawing.Size(303, 36);
            this.Datepicker1.TabIndex = 12;
            this.Datepicker1.Value = new System.DateTime(2017, 12, 2, 20, 3, 10, 292);
            // 
            // LblTime
            // 
            this.LblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblTime.AutoSize = true;
            this.LblTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.LblTime.Font = new System.Drawing.Font("Monotype Corsiva", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.LblTime.Location = new System.Drawing.Point(442, 12);
            this.LblTime.Name = "LblTime";
            this.LblTime.Size = new System.Drawing.Size(0, 79);
            this.LblTime.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(23, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 31);
            this.label1.TabIndex = 11;
            this.label1.Text = "Laporan Data Parkir";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 183);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(644, 347);
            this.dataGridView1.TabIndex = 18;
            // 
            // BtnPrint
            // 
            this.BtnPrint.Activecolor = System.Drawing.Color.Gainsboro;
            this.BtnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnPrint.BackColor = System.Drawing.Color.White;
            this.BtnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnPrint.BorderRadius = 0;
            this.BtnPrint.ButtonText = "      PDF";
            this.BtnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPrint.DisabledColor = System.Drawing.Color.Gray;
            this.BtnPrint.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnPrint.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnPrint.Iconimage")));
            this.BtnPrint.Iconimage_right = null;
            this.BtnPrint.Iconimage_right_Selected = null;
            this.BtnPrint.Iconimage_Selected = null;
            this.BtnPrint.IconMarginLeft = 30;
            this.BtnPrint.IconMarginRight = 0;
            this.BtnPrint.IconRightVisible = true;
            this.BtnPrint.IconRightZoom = 0D;
            this.BtnPrint.IconVisible = true;
            this.BtnPrint.IconZoom = 40D;
            this.BtnPrint.IsTab = true;
            this.BtnPrint.Location = new System.Drawing.Point(544, 141);
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.Normalcolor = System.Drawing.Color.White;
            this.BtnPrint.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.BtnPrint.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.BtnPrint.selected = false;
            this.BtnPrint.Size = new System.Drawing.Size(128, 36);
            this.BtnPrint.TabIndex = 21;
            this.BtnPrint.Text = "      PDF";
            this.BtnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPrint.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.BtnPrint.TextFont = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // PrintDocument1
            // 
            this.PrintDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument1_PrintPage);
            // 
            // PrintPreviewDialog1
            // 
            this.PrintPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.PrintPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.PrintPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.PrintPreviewDialog1.Enabled = true;
            this.PrintPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("PrintPreviewDialog1.Icon")));
            this.PrintPreviewDialog1.Name = "PrintPreviewDialog1";
            this.PrintPreviewDialog1.Visible = false;
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Activecolor = System.Drawing.Color.Gainsboro;
            this.btnExportExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportExcel.BackColor = System.Drawing.Color.White;
            this.btnExportExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExportExcel.BorderRadius = 0;
            this.btnExportExcel.ButtonText = "      Excel";
            this.btnExportExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportExcel.DisabledColor = System.Drawing.Color.Gray;
            this.btnExportExcel.Iconcolor = System.Drawing.Color.Transparent;
            this.btnExportExcel.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnExportExcel.Iconimage")));
            this.btnExportExcel.Iconimage_right = null;
            this.btnExportExcel.Iconimage_right_Selected = null;
            this.btnExportExcel.Iconimage_Selected = null;
            this.btnExportExcel.IconMarginLeft = 30;
            this.btnExportExcel.IconMarginRight = 0;
            this.btnExportExcel.IconRightVisible = true;
            this.btnExportExcel.IconRightZoom = 0D;
            this.btnExportExcel.IconVisible = true;
            this.btnExportExcel.IconZoom = 40D;
            this.btnExportExcel.IsTab = true;
            this.btnExportExcel.Location = new System.Drawing.Point(387, 141);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Normalcolor = System.Drawing.Color.White;
            this.btnExportExcel.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnExportExcel.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.btnExportExcel.selected = false;
            this.btnExportExcel.Size = new System.Drawing.Size(128, 36);
            this.btnExportExcel.TabIndex = 22;
            this.btnExportExcel.Text = "      Excel";
            this.btnExportExcel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportExcel.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.btnExportExcel.TextFont = new System.Drawing.Font("Segoe UI", 12F);
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // Laporan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnExportExcel);
            this.Controls.Add(this.BtnPrint);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Panel1);
            this.Name = "Laporan";
            this.Size = new System.Drawing.Size(693, 559);
            this.Load += new System.EventHandler(this.Laporan_Load);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.Label LblTime;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuDatepicker Datepicker2;
        private Bunifu.Framework.UI.BunifuDatepicker Datepicker1;
        private Bunifu.Framework.UI.BunifuFlatButton BtnTampilkan;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Bunifu.Framework.UI.BunifuFlatButton BtnPrint;
        private System.Drawing.Printing.PrintDocument PrintDocument1;
        private System.Windows.Forms.PrintPreviewDialog PrintPreviewDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuFlatButton btnExportExcel;
    }
}
