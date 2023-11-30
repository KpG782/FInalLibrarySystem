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
            this.picUser = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtbxEmail = new System.Windows.Forms.TextBox();
            this.txtBoxPass = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lnkLblSign = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).BeginInit();
            this.SuspendLayout();
            // 
            // picUser
            // 
            this.picUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picUser.Image = ((System.Drawing.Image)(resources.GetObject("picUser.Image")));
            this.picUser.Location = new System.Drawing.Point(371, 97);
            this.picUser.Name = "picUser";
            this.picUser.Size = new System.Drawing.Size(146, 122);
            this.picUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUser.TabIndex = 1;
            this.picUser.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.Location = new System.Drawing.Point(332, 59);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(217, 35);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "JBP  School LIbrary System";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtbxEmail
            // 
            this.txtbxEmail.Location = new System.Drawing.Point(338, 264);
            this.txtbxEmail.Name = "txtbxEmail";
            this.txtbxEmail.Size = new System.Drawing.Size(211, 22);
            this.txtbxEmail.TabIndex = 3;
            this.txtbxEmail.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtBoxPass
            // 
            this.txtBoxPass.Location = new System.Drawing.Point(338, 339);
            this.txtBoxPass.Name = "txtBoxPass";
            this.txtBoxPass.Size = new System.Drawing.Size(211, 22);
            this.txtBoxPass.TabIndex = 4;
            // 
            // lblEmail
            // 
            this.lblEmail.Location = new System.Drawing.Point(335, 226);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(217, 35);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Email";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblEmail.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblPass
            // 
            this.lblPass.Location = new System.Drawing.Point(335, 301);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(217, 35);
            this.lblPass.TabIndex = 6;
            this.lblPass.Text = "Password";
            this.lblPass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPass.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(404, 380);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(91, 31);
            this.btnSubmit.TabIndex = 7;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.button1_Click);
            // 
            // lnkLblSign
            // 
            this.lnkLblSign.AutoSize = true;
            this.lnkLblSign.Location = new System.Drawing.Point(421, 414);
            this.lnkLblSign.Name = "lnkLblSign";
            this.lnkLblSign.Size = new System.Drawing.Size(55, 16);
            this.lnkLblSign.TabIndex = 9;
            this.lnkLblSign.TabStop = true;
            this.lnkLblSign.Text = "Sign Up";
            this.lnkLblSign.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 495);
            this.Controls.Add(this.lnkLblSign);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtBoxPass);
            this.Controls.Add(this.txtbxEmail);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.picUser);
            this.Name = "frmLogin";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picUser;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtbxEmail;
        private System.Windows.Forms.TextBox txtBoxPass;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.LinkLabel lnkLblSign;
    }
}

