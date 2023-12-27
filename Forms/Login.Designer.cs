namespace FInalLibrarySystem
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lnkLblSign = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbPass = new System.Windows.Forms.PictureBox();
            this.pbUser = new System.Windows.Forms.PictureBox();
            this.chkShow = new System.Windows.Forms.CheckBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(149, 21);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(179, 55);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Login";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(62, 136);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(315, 23);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(62, 205);
            this.txtPass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(315, 23);
            this.txtPass.TabIndex = 4;
            this.txtPass.TextChanged += new System.EventHandler(this.txtPass_TextChanged);
            // 
            // lblEmail
            // 
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(62, 116);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(196, 16);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Email";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblEmail.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblPass
            // 
            this.lblPass.ForeColor = System.Drawing.Color.White;
            this.lblPass.Location = new System.Drawing.Point(62, 178);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(175, 23);
            this.lblPass.TabIndex = 6;
            this.lblPass.Text = "Password";
            this.lblPass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPass.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // btnSubmit
            // 
            this.btnSubmit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(154, 250);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(154, 36);
            this.btnSubmit.TabIndex = 7;
            this.btnSubmit.Text = "Login";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.button1_Click);
            // 
            // lnkLblSign
            // 
            this.lnkLblSign.AutoSize = true;
            this.lnkLblSign.ForeColor = System.Drawing.Color.White;
            this.lnkLblSign.LinkColor = System.Drawing.Color.White;
            this.lnkLblSign.Location = new System.Drawing.Point(130, 301);
            this.lnkLblSign.Name = "lnkLblSign";
            this.lnkLblSign.Size = new System.Drawing.Size(198, 15);
            this.lnkLblSign.TabIndex = 9;
            this.lnkLblSign.TabStop = true;
            this.lnkLblSign.Text = "Don\'t Have an Account Yet? Sign Up";
            this.lnkLblSign.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1190, 44);
            this.panel1.TabIndex = 13;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 32);
            this.label1.TabIndex = 14;
            this.label1.Text = "Super Book LMS";
            this.label1.Click += new System.EventHandler(this.label1_Click_4);
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(1132, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 44);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.pbPass);
            this.panel2.Controls.Add(this.pbUser);
            this.panel2.Controls.Add(this.chkShow);
            this.panel2.Controls.Add(this.lblTitle);
            this.panel2.Controls.Add(this.lblEmail);
            this.panel2.Controls.Add(this.txtEmail);
            this.panel2.Controls.Add(this.txtPass);
            this.panel2.Controls.Add(this.lblPass);
            this.panel2.Controls.Add(this.lnkLblSign);
            this.panel2.Controls.Add(this.btnSubmit);
            this.panel2.Location = new System.Drawing.Point(384, 257);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(458, 393);
            this.panel2.TabIndex = 14;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pbPass
            // 
            this.pbPass.Image = ((System.Drawing.Image)(resources.GetObject("pbPass.Image")));
            this.pbPass.Location = new System.Drawing.Point(26, 197);
            this.pbPass.Name = "pbPass";
            this.pbPass.Size = new System.Drawing.Size(30, 31);
            this.pbPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPass.TabIndex = 14;
            this.pbPass.TabStop = false;
            // 
            // pbUser
            // 
            this.pbUser.Image = ((System.Drawing.Image)(resources.GetObject("pbUser.Image")));
            this.pbUser.Location = new System.Drawing.Point(26, 129);
            this.pbUser.Name = "pbUser";
            this.pbUser.Size = new System.Drawing.Size(30, 30);
            this.pbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUser.TabIndex = 13;
            this.pbUser.TabStop = false;
            // 
            // chkShow
            // 
            this.chkShow.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkShow.AutoSize = true;
            this.chkShow.BackColor = System.Drawing.Color.White;
            this.chkShow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.chkShow.FlatAppearance.BorderSize = 0;
            this.chkShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkShow.Image = ((System.Drawing.Image)(resources.GetObject("chkShow.Image")));
            this.chkShow.Location = new System.Drawing.Point(348, 207);
            this.chkShow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkShow.Name = "chkShow";
            this.chkShow.Size = new System.Drawing.Size(16, 16);
            this.chkShow.TabIndex = 12;
            this.chkShow.UseVisualStyleBackColor = false;
            this.chkShow.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1190, 718);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1190, 718);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox3);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmLogin";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.LinkLabel lnkLblSign;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pbUser;
        private System.Windows.Forms.PictureBox pbPass;
        private System.Windows.Forms.CheckBox chkShow;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

