namespace ParkirApp.view
{
    partial class LoginV
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginV));
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblClose = new System.Windows.Forms.Label();
            this.LblBatal = new System.Windows.Forms.Label();
            this.Btnlogin = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.TextboxPws = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.TextboxName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.panel1.Controls.Add(this.LblClose);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 20);
            this.panel1.TabIndex = 15;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            this.panel1.Move += new System.EventHandler(this.panel1_Move);
            // 
            // LblClose
            // 
            this.LblClose.AutoSize = true;
            this.LblClose.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblClose.ForeColor = System.Drawing.Color.White;
            this.LblClose.Location = new System.Drawing.Point(878, 2);
            this.LblClose.Name = "LblClose";
            this.LblClose.Size = new System.Drawing.Size(19, 18);
            this.LblClose.TabIndex = 0;
            this.LblClose.Text = "X";
            this.LblClose.Click += new System.EventHandler(this.LblClose_Click);
            // 
            // LblBatal
            // 
            this.LblBatal.AutoSize = true;
            this.LblBatal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblBatal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBatal.ForeColor = System.Drawing.Color.White;
            this.LblBatal.Location = new System.Drawing.Point(459, 482);
            this.LblBatal.Name = "LblBatal";
            this.LblBatal.Size = new System.Drawing.Size(35, 15);
            this.LblBatal.TabIndex = 3;
            this.LblBatal.Text = "Batal";
            this.LblBatal.Click += new System.EventHandler(this.LblBatal_Click);
            // 
            // Btnlogin
            // 
            this.Btnlogin.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Btnlogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Btnlogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btnlogin.BorderRadius = 0;
            this.Btnlogin.ButtonText = "Login";
            this.Btnlogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btnlogin.DisabledColor = System.Drawing.Color.Gray;
            this.Btnlogin.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnlogin.Iconcolor = System.Drawing.Color.Transparent;
            this.Btnlogin.Iconimage = null;
            this.Btnlogin.Iconimage_right = null;
            this.Btnlogin.Iconimage_right_Selected = null;
            this.Btnlogin.Iconimage_Selected = null;
            this.Btnlogin.IconMarginLeft = 0;
            this.Btnlogin.IconMarginRight = 0;
            this.Btnlogin.IconRightVisible = true;
            this.Btnlogin.IconRightZoom = 0D;
            this.Btnlogin.IconVisible = true;
            this.Btnlogin.IconZoom = 90D;
            this.Btnlogin.IsTab = false;
            this.Btnlogin.Location = new System.Drawing.Point(337, 433);
            this.Btnlogin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Btnlogin.Name = "Btnlogin";
            this.Btnlogin.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Btnlogin.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Btnlogin.OnHoverTextColor = System.Drawing.Color.White;
            this.Btnlogin.selected = false;
            this.Btnlogin.Size = new System.Drawing.Size(283, 32);
            this.Btnlogin.TabIndex = 2;
            this.Btnlogin.Text = "Login";
            this.Btnlogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btnlogin.Textcolor = System.Drawing.Color.White;
            this.Btnlogin.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnlogin.Click += new System.EventHandler(this.Btnlogin_Click);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(231, 396);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(83, 20);
            this.bunifuCustomLabel2.TabIndex = 12;
            this.bunifuCustomLabel2.Text = "Password";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(231, 340);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(87, 20);
            this.bunifuCustomLabel1.TabIndex = 11;
            this.bunifuCustomLabel1.Text = "Username";
            // 
            // TextboxPws
            // 
            this.TextboxPws.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.TextboxPws.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.TextboxPws.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.TextboxPws.BorderThickness = 3;
            this.TextboxPws.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextboxPws.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextboxPws.ForeColor = System.Drawing.Color.White;
            this.TextboxPws.isPassword = true;
            this.TextboxPws.Location = new System.Drawing.Point(337, 386);
            this.TextboxPws.Margin = new System.Windows.Forms.Padding(4);
            this.TextboxPws.Name = "TextboxPws";
            this.TextboxPws.Size = new System.Drawing.Size(283, 40);
            this.TextboxPws.TabIndex = 1;
            this.TextboxPws.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextboxPws.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyUp);
            // 
            // TextboxName
            // 
            this.TextboxName.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.TextboxName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.TextboxName.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.TextboxName.BorderThickness = 3;
            this.TextboxName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextboxName.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextboxName.ForeColor = System.Drawing.Color.White;
            this.TextboxName.isPassword = false;
            this.TextboxName.Location = new System.Drawing.Point(337, 329);
            this.TextboxName.Margin = new System.Windows.Forms.Padding(4);
            this.TextboxName.Name = "TextboxName";
            this.TextboxName.Size = new System.Drawing.Size(283, 40);
            this.TextboxName.TabIndex = 0;
            this.TextboxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextboxName.OnValueChanged += new System.EventHandler(this.TextboxName_OnValueChanged);
            this.TextboxName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtuser_KeyUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 20);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(897, 499);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // LoginV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(900, 520);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LblBatal);
            this.Controls.Add(this.Btnlogin);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.TextboxPws);
            this.Controls.Add(this.TextboxName);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LoginV";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblClose;
        private System.Windows.Forms.Label LblBatal;
        private Bunifu.Framework.UI.BunifuFlatButton Btnlogin;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuMetroTextbox TextboxPws;
        private Bunifu.Framework.UI.BunifuMetroTextbox TextboxName;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}