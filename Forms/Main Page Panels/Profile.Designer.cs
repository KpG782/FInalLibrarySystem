namespace FInalLibrarySystem
{
    partial class Profile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profile));
            this.PBNonFictional = new Guna.UI2.WinForms.Guna2PictureBox();
            this.PBFictional = new Guna.UI2.WinForms.Guna2PictureBox();
            this.LBLCategories = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.PBAcademics = new Guna.UI2.WinForms.Guna2PictureBox();
            this.LBLHello = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BTNAvailable = new Guna.UI2.WinForms.Guna2Button();
            this.BTNBorrowed = new Guna.UI2.WinForms.Guna2Button();
            this.LBLAvailable2 = new System.Windows.Forms.Label();
            this.LBLAvailable = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.LBLBorrowed = new System.Windows.Forms.Label();
            this.LBLBorrowed2 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.LBLReserved2 = new System.Windows.Forms.Label();
            this.LBLReserved = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.LBLFictional2 = new System.Windows.Forms.Label();
            this.LBLFictional = new System.Windows.Forms.Label();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.LBLNonFictional = new System.Windows.Forms.Label();
            this.LBLNonFictional2 = new System.Windows.Forms.Label();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.LBLAcademic = new System.Windows.Forms.Label();
            this.LBLAcademic2 = new System.Windows.Forms.Label();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PBNonFictional)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBFictional)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBAcademics)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PBNonFictional
            // 
            this.PBNonFictional.BorderRadius = 10;
            this.PBNonFictional.Image = ((System.Drawing.Image)(resources.GetObject("PBNonFictional.Image")));
            this.PBNonFictional.ImageRotate = 0F;
            this.PBNonFictional.Location = new System.Drawing.Point(609, 68);
            this.PBNonFictional.Name = "PBNonFictional";
            this.PBNonFictional.Size = new System.Drawing.Size(210, 291);
            this.PBNonFictional.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBNonFictional.TabIndex = 6;
            this.PBNonFictional.TabStop = false;
            this.PBNonFictional.Click += new System.EventHandler(this.PBNonFictional_Click_1);
            // 
            // PBFictional
            // 
            this.PBFictional.BorderRadius = 10;
            this.PBFictional.Image = ((System.Drawing.Image)(resources.GetObject("PBFictional.Image")));
            this.PBFictional.ImageRotate = 0F;
            this.PBFictional.Location = new System.Drawing.Point(358, 68);
            this.PBFictional.Name = "PBFictional";
            this.PBFictional.Size = new System.Drawing.Size(210, 291);
            this.PBFictional.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBFictional.TabIndex = 5;
            this.PBFictional.TabStop = false;
            this.PBFictional.Click += new System.EventHandler(this.PBFictional_Click_1);
            // 
            // LBLCategories
            // 
            this.LBLCategories.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLCategories.Location = new System.Drawing.Point(27, 18);
            this.LBLCategories.Name = "LBLCategories";
            this.LBLCategories.Size = new System.Drawing.Size(219, 34);
            this.LBLCategories.TabIndex = 1;
            this.LBLCategories.Text = "RECOMMENDED";
            this.LBLCategories.Click += new System.EventHandler(this.LBLCategories_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.guna2PictureBox1);
            this.panel3.Controls.Add(this.PBNonFictional);
            this.panel3.Controls.Add(this.PBFictional);
            this.panel3.Controls.Add(this.PBAcademics);
            this.panel3.Controls.Add(this.LBLCategories);
            this.panel3.Location = new System.Drawing.Point(2, 471);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1179, 417);
            this.panel3.TabIndex = 10;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // PBAcademics
            // 
            this.PBAcademics.BorderRadius = 10;
            this.PBAcademics.Image = ((System.Drawing.Image)(resources.GetObject("PBAcademics.Image")));
            this.PBAcademics.ImageRotate = 0F;
            this.PBAcademics.Location = new System.Drawing.Point(104, 68);
            this.PBAcademics.Name = "PBAcademics";
            this.PBAcademics.Size = new System.Drawing.Size(210, 291);
            this.PBAcademics.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBAcademics.TabIndex = 4;
            this.PBAcademics.TabStop = false;
            this.PBAcademics.Click += new System.EventHandler(this.PBAcademics_Click_1);
            // 
            // LBLHello
            // 
            this.LBLHello.BackColor = System.Drawing.Color.Transparent;
            this.LBLHello.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLHello.Location = new System.Drawing.Point(16, 15);
            this.LBLHello.Name = "LBLHello";
            this.LBLHello.Size = new System.Drawing.Size(845, 80);
            this.LBLHello.TabIndex = 2;
            this.LBLHello.Text = "Hello,";
            this.LBLHello.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LBLHello.Click += new System.EventHandler(this.LBLHello_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel9);
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(3, 118);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1178, 349);
            this.panel2.TabIndex = 9;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LBLHello);
            this.panel1.Location = new System.Drawing.Point(2, 3);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1179, 111);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // BTNAvailable
            // 
            this.BTNAvailable.BorderRadius = 20;
            this.BTNAvailable.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BTNAvailable.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BTNAvailable.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BTNAvailable.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BTNAvailable.FillColor = System.Drawing.Color.DarkSeaGreen;
            this.BTNAvailable.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BTNAvailable.ForeColor = System.Drawing.Color.White;
            this.BTNAvailable.HoverState.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.BTNAvailable.HoverState.CustomBorderColor = System.Drawing.Color.DarkSeaGreen;
            this.BTNAvailable.HoverState.FillColor = System.Drawing.Color.DarkSeaGreen;
            this.BTNAvailable.HoverState.ForeColor = System.Drawing.Color.Transparent;
            this.BTNAvailable.Image = ((System.Drawing.Image)(resources.GetObject("BTNAvailable.Image")));
            this.BTNAvailable.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BTNAvailable.ImageOffset = new System.Drawing.Point(14, 0);
            this.BTNAvailable.ImageSize = new System.Drawing.Size(100, 100);
            this.BTNAvailable.Location = new System.Drawing.Point(0, 0);
            this.BTNAvailable.Name = "BTNAvailable";
            this.BTNAvailable.PressedColor = System.Drawing.Color.DarkSeaGreen;
            this.BTNAvailable.Size = new System.Drawing.Size(371, 172);
            this.BTNAvailable.TabIndex = 2;
            this.BTNAvailable.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // BTNBorrowed
            // 
            this.BTNBorrowed.BorderRadius = 20;
            this.BTNBorrowed.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BTNBorrowed.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BTNBorrowed.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BTNBorrowed.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BTNBorrowed.FillColor = System.Drawing.Color.SteelBlue;
            this.BTNBorrowed.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BTNBorrowed.ForeColor = System.Drawing.Color.White;
            this.BTNBorrowed.HoverState.BorderColor = System.Drawing.Color.SteelBlue;
            this.BTNBorrowed.HoverState.CustomBorderColor = System.Drawing.Color.SteelBlue;
            this.BTNBorrowed.HoverState.FillColor = System.Drawing.Color.SteelBlue;
            this.BTNBorrowed.HoverState.ForeColor = System.Drawing.Color.Transparent;
            this.BTNBorrowed.Image = ((System.Drawing.Image)(resources.GetObject("BTNBorrowed.Image")));
            this.BTNBorrowed.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BTNBorrowed.ImageOffset = new System.Drawing.Point(14, 0);
            this.BTNBorrowed.ImageSize = new System.Drawing.Size(100, 100);
            this.BTNBorrowed.Location = new System.Drawing.Point(0, 0);
            this.BTNBorrowed.Name = "BTNBorrowed";
            this.BTNBorrowed.PressedColor = System.Drawing.Color.SteelBlue;
            this.BTNBorrowed.Size = new System.Drawing.Size(371, 172);
            this.BTNBorrowed.TabIndex = 6;
            this.BTNBorrowed.Click += new System.EventHandler(this.BTNBorrowed_Click);
            // 
            // LBLAvailable2
            // 
            this.LBLAvailable2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.LBLAvailable2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLAvailable2.Location = new System.Drawing.Point(40, 131);
            this.LBLAvailable2.Name = "LBLAvailable2";
            this.LBLAvailable2.Size = new System.Drawing.Size(149, 32);
            this.LBLAvailable2.TabIndex = 1;
            this.LBLAvailable2.Text = "AVAILABLE";
            this.LBLAvailable2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LBLAvailable2.Click += new System.EventHandler(this.LBLAvailable_Click);
            // 
            // LBLAvailable
            // 
            this.LBLAvailable.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.LBLAvailable.Font = new System.Drawing.Font("Segoe UI", 69F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLAvailable.Location = new System.Drawing.Point(20, -9);
            this.LBLAvailable.Name = "LBLAvailable";
            this.LBLAvailable.Size = new System.Drawing.Size(189, 139);
            this.LBLAvailable.TabIndex = 8;
            this.LBLAvailable.Text = "30";
            this.LBLAvailable.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.LBLAvailable2);
            this.panel4.Controls.Add(this.LBLAvailable);
            this.panel4.Controls.Add(this.BTNAvailable);
            this.panel4.Location = new System.Drawing.Point(12, 27);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(371, 172);
            this.panel4.TabIndex = 9;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.LBLBorrowed2);
            this.panel5.Controls.Add(this.LBLBorrowed);
            this.panel5.Controls.Add(this.BTNBorrowed);
            this.panel5.Location = new System.Drawing.Point(403, 27);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(371, 172);
            this.panel5.TabIndex = 10;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // LBLBorrowed
            // 
            this.LBLBorrowed.BackColor = System.Drawing.Color.SteelBlue;
            this.LBLBorrowed.Font = new System.Drawing.Font("Segoe UI", 69F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLBorrowed.Location = new System.Drawing.Point(20, -9);
            this.LBLBorrowed.Name = "LBLBorrowed";
            this.LBLBorrowed.Size = new System.Drawing.Size(182, 139);
            this.LBLBorrowed.TabIndex = 9;
            this.LBLBorrowed.Text = "0";
            this.LBLBorrowed.Click += new System.EventHandler(this.LBLBorrowed_Click);
            // 
            // LBLBorrowed2
            // 
            this.LBLBorrowed2.BackColor = System.Drawing.Color.SteelBlue;
            this.LBLBorrowed2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLBorrowed2.Location = new System.Drawing.Point(40, 131);
            this.LBLBorrowed2.Name = "LBLBorrowed2";
            this.LBLBorrowed2.Size = new System.Drawing.Size(149, 32);
            this.LBLBorrowed2.TabIndex = 9;
            this.LBLBorrowed2.Text = "Borrowed";
            this.LBLBorrowed2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LBLBorrowed2.Click += new System.EventHandler(this.LBLBorrowed2_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.LBLReserved2);
            this.panel6.Controls.Add(this.LBLReserved);
            this.panel6.Controls.Add(this.guna2Button1);
            this.panel6.Location = new System.Drawing.Point(793, 27);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(371, 172);
            this.panel6.TabIndex = 11;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // LBLReserved2
            // 
            this.LBLReserved2.BackColor = System.Drawing.Color.Orange;
            this.LBLReserved2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLReserved2.Location = new System.Drawing.Point(40, 131);
            this.LBLReserved2.Name = "LBLReserved2";
            this.LBLReserved2.Size = new System.Drawing.Size(149, 32);
            this.LBLReserved2.TabIndex = 9;
            this.LBLReserved2.Text = "RESERVED";
            this.LBLReserved2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LBLReserved2.Click += new System.EventHandler(this.LBLReserved2_Click);
            // 
            // LBLReserved
            // 
            this.LBLReserved.BackColor = System.Drawing.Color.Orange;
            this.LBLReserved.Font = new System.Drawing.Font("Segoe UI", 69F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLReserved.Location = new System.Drawing.Point(20, -9);
            this.LBLReserved.Name = "LBLReserved";
            this.LBLReserved.Size = new System.Drawing.Size(177, 139);
            this.LBLReserved.TabIndex = 9;
            this.LBLReserved.Text = "0";
            this.LBLReserved.Click += new System.EventHandler(this.LBLReserved_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 20;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Orange;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.BorderColor = System.Drawing.Color.Orange;
            this.guna2Button1.HoverState.CustomBorderColor = System.Drawing.Color.Orange;
            this.guna2Button1.HoverState.FillColor = System.Drawing.Color.Orange;
            this.guna2Button1.HoverState.ForeColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button1.Image")));
            this.guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.guna2Button1.ImageOffset = new System.Drawing.Point(14, 0);
            this.guna2Button1.ImageSize = new System.Drawing.Size(100, 100);
            this.guna2Button1.Location = new System.Drawing.Point(0, 0);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.PressedColor = System.Drawing.Color.Orange;
            this.guna2Button1.Size = new System.Drawing.Size(371, 172);
            this.guna2Button1.TabIndex = 6;
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click_1);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.LBLFictional);
            this.panel7.Controls.Add(this.LBLFictional2);
            this.panel7.Controls.Add(this.guna2Button2);
            this.panel7.Location = new System.Drawing.Point(415, 217);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(345, 113);
            this.panel7.TabIndex = 12;
            this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
            // 
            // LBLFictional2
            // 
            this.LBLFictional2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.LBLFictional2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLFictional2.Location = new System.Drawing.Point(42, 81);
            this.LBLFictional2.Name = "LBLFictional2";
            this.LBLFictional2.Size = new System.Drawing.Size(136, 32);
            this.LBLFictional2.TabIndex = 9;
            this.LBLFictional2.Text = "FICTIONAL BOOKS";
            this.LBLFictional2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LBLFictional2.Click += new System.EventHandler(this.LBLFictional2_Click);
            // 
            // LBLFictional
            // 
            this.LBLFictional.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.LBLFictional.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLFictional.Location = new System.Drawing.Point(37, 0);
            this.LBLFictional.Name = "LBLFictional";
            this.LBLFictional.Size = new System.Drawing.Size(115, 81);
            this.LBLFictional.TabIndex = 9;
            this.LBLFictional.Text = "10";
            this.LBLFictional.Click += new System.EventHandler(this.label2_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.BorderRadius = 20;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.guna2Button2.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.guna2Button2.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.guna2Button2.HoverState.ForeColor = System.Drawing.Color.Transparent;
            this.guna2Button2.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button2.Image")));
            this.guna2Button2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.guna2Button2.ImageOffset = new System.Drawing.Point(25, 0);
            this.guna2Button2.ImageSize = new System.Drawing.Size(60, 60);
            this.guna2Button2.Location = new System.Drawing.Point(0, 0);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.guna2Button2.Size = new System.Drawing.Size(345, 113);
            this.guna2Button2.TabIndex = 6;
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click_1);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.LBLNonFictional);
            this.panel8.Controls.Add(this.LBLNonFictional2);
            this.panel8.Controls.Add(this.guna2Button3);
            this.panel8.Location = new System.Drawing.Point(807, 217);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(345, 113);
            this.panel8.TabIndex = 13;
            this.panel8.Paint += new System.Windows.Forms.PaintEventHandler(this.panel8_Paint);
            // 
            // LBLNonFictional
            // 
            this.LBLNonFictional.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.LBLNonFictional.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLNonFictional.Location = new System.Drawing.Point(37, 0);
            this.LBLNonFictional.Name = "LBLNonFictional";
            this.LBLNonFictional.Size = new System.Drawing.Size(115, 81);
            this.LBLNonFictional.TabIndex = 9;
            this.LBLNonFictional.Text = "10";
            this.LBLNonFictional.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // LBLNonFictional2
            // 
            this.LBLNonFictional2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.LBLNonFictional2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLNonFictional2.Location = new System.Drawing.Point(42, 81);
            this.LBLNonFictional2.Name = "LBLNonFictional2";
            this.LBLNonFictional2.Size = new System.Drawing.Size(177, 32);
            this.LBLNonFictional2.TabIndex = 9;
            this.LBLNonFictional2.Text = "NON-FICTIONAL BOOKS";
            this.LBLNonFictional2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LBLNonFictional2.Click += new System.EventHandler(this.label3_Click);
            // 
            // guna2Button3
            // 
            this.guna2Button3.BorderRadius = 20;
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.guna2Button3.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.guna2Button3.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.guna2Button3.HoverState.ForeColor = System.Drawing.Color.Transparent;
            this.guna2Button3.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button3.Image")));
            this.guna2Button3.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.guna2Button3.ImageOffset = new System.Drawing.Point(25, 0);
            this.guna2Button3.ImageSize = new System.Drawing.Size(60, 60);
            this.guna2Button3.Location = new System.Drawing.Point(0, 0);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.guna2Button3.Size = new System.Drawing.Size(345, 113);
            this.guna2Button3.TabIndex = 6;
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.LBLAcademic);
            this.panel9.Controls.Add(this.LBLAcademic2);
            this.panel9.Controls.Add(this.guna2Button4);
            this.panel9.Location = new System.Drawing.Point(24, 217);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(345, 113);
            this.panel9.TabIndex = 13;
            this.panel9.Paint += new System.Windows.Forms.PaintEventHandler(this.panel9_Paint);
            // 
            // LBLAcademic
            // 
            this.LBLAcademic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.LBLAcademic.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLAcademic.Location = new System.Drawing.Point(37, 0);
            this.LBLAcademic.Name = "LBLAcademic";
            this.LBLAcademic.Size = new System.Drawing.Size(115, 81);
            this.LBLAcademic.TabIndex = 9;
            this.LBLAcademic.Text = "10";
            this.LBLAcademic.Click += new System.EventHandler(this.label4_Click);
            // 
            // LBLAcademic2
            // 
            this.LBLAcademic2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.LBLAcademic2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLAcademic2.Location = new System.Drawing.Point(42, 81);
            this.LBLAcademic2.Name = "LBLAcademic2";
            this.LBLAcademic2.Size = new System.Drawing.Size(143, 32);
            this.LBLAcademic2.TabIndex = 9;
            this.LBLAcademic2.Text = "ACADEMIC BOOKS";
            this.LBLAcademic2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LBLAcademic2.Click += new System.EventHandler(this.label5_Click);
            // 
            // guna2Button4
            // 
            this.guna2Button4.BorderRadius = 20;
            this.guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.guna2Button4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button4.ForeColor = System.Drawing.Color.White;
            this.guna2Button4.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.guna2Button4.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.guna2Button4.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.guna2Button4.HoverState.ForeColor = System.Drawing.Color.Transparent;
            this.guna2Button4.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button4.Image")));
            this.guna2Button4.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.guna2Button4.ImageOffset = new System.Drawing.Point(25, 0);
            this.guna2Button4.ImageSize = new System.Drawing.Size(60, 60);
            this.guna2Button4.Location = new System.Drawing.Point(0, 0);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.guna2Button4.Size = new System.Drawing.Size(345, 113);
            this.guna2Button4.TabIndex = 6;
            this.guna2Button4.Click += new System.EventHandler(this.guna2Button4_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BorderRadius = 10;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(860, 68);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(210, 291);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 7;
            this.guna2PictureBox1.TabStop = false;
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Profile";
            this.Size = new System.Drawing.Size(1184, 890);
            this.Load += new System.EventHandler(this.Profile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBNonFictional)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBFictional)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PBAcademics)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2PictureBox PBNonFictional;
        private Guna.UI2.WinForms.Guna2PictureBox PBFictional;
        private System.Windows.Forms.Label LBLCategories;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2PictureBox PBAcademics;
        private System.Windows.Forms.Label LBLHello;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button BTNAvailable;
        private Guna.UI2.WinForms.Guna2Button BTNBorrowed;
        private System.Windows.Forms.Label LBLAvailable;
        private System.Windows.Forms.Label LBLAvailable2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label LBLBorrowed;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label LBLReserved2;
        private System.Windows.Forms.Label LBLReserved;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Label LBLBorrowed2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label LBLFictional;
        private System.Windows.Forms.Label LBLFictional2;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label LBLNonFictional;
        private System.Windows.Forms.Label LBLNonFictional2;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label LBLAcademic;
        private System.Windows.Forms.Label LBLAcademic2;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}
