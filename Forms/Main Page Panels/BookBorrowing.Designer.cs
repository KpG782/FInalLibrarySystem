namespace FInalLibrarySystem
{
    partial class BookBorrowing
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.bk1lbl7 = new System.Windows.Forms.Label();
            this.nudBookID = new System.Windows.Forms.NumericUpDown();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.dateBorrow = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.nudMemberID = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.dateReturn = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNote = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudBookID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMemberID)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Location = new System.Drawing.Point(20, 24);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(113, 32);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Book Borrowing";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // bk1lbl7
            // 
            this.bk1lbl7.Location = new System.Drawing.Point(194, 194);
            this.bk1lbl7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bk1lbl7.Name = "bk1lbl7";
            this.bk1lbl7.Size = new System.Drawing.Size(88, 23);
            this.bk1lbl7.TabIndex = 17;
            this.bk1lbl7.Text = "Enter a book id ; ";
            // 
            // nudBookID
            // 
            this.nudBookID.Location = new System.Drawing.Point(302, 197);
            this.nudBookID.Name = "nudBookID";
            this.nudBookID.Size = new System.Drawing.Size(120, 20);
            this.nudBookID.TabIndex = 18;
            this.nudBookID.ValueChanged += new System.EventHandler(this.nudbookID_ValueChanged);
            // 
            // guna2Button1
            // 
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BorderRadius = 21;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(451, 184);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(180, 45);
            this.guna2Button1.TabIndex = 19;
            this.guna2Button1.Text = "Search Book";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(314, 228);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(55, 13);
            this.linkLabel1.TabIndex = 20;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Book Title";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // dateBorrow
            // 
            this.dateBorrow.Location = new System.Drawing.Point(287, 335);
            this.dateBorrow.Name = "dateBorrow";
            this.dateBorrow.Size = new System.Drawing.Size(200, 20);
            this.dateBorrow.TabIndex = 21;
            this.dateBorrow.ValueChanged += new System.EventHandler(this.dateBorrow_ValueChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(194, 335);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 23);
            this.label1.TabIndex = 22;
            this.label1.Text = "Issue Data:";
            // 
            // guna2Button2
            // 
            this.guna2Button2.AutoRoundedCorners = true;
            this.guna2Button2.BorderRadius = 21;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Location = new System.Drawing.Point(307, 551);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(180, 45);
            this.guna2Button2.TabIndex = 23;
            this.guna2Button2.Text = "Borrow Book";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.LinkColor = System.Drawing.Color.White;
            this.linkLabel2.Location = new System.Drawing.Point(314, 296);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(76, 13);
            this.linkLabel2.TabIndex = 26;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Member Name";
            // 
            // nudMemberID
            // 
            this.nudMemberID.Location = new System.Drawing.Point(302, 265);
            this.nudMemberID.Name = "nudMemberID";
            this.nudMemberID.Size = new System.Drawing.Size(120, 20);
            this.nudMemberID.TabIndex = 25;
            this.nudMemberID.ValueChanged += new System.EventHandler(this.nudMemberID_ValueChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(194, 262);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 23);
            this.label2.TabIndex = 24;
            this.label2.Text = "Enter member id ; ";
            // 
            // guna2Button3
            // 
            this.guna2Button3.AutoRoundedCorners = true;
            this.guna2Button3.BorderRadius = 21;
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.Location = new System.Drawing.Point(451, 262);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(180, 45);
            this.guna2Button3.TabIndex = 27;
            this.guna2Button3.Text = "Name";
            // 
            // dateReturn
            // 
            this.dateReturn.Location = new System.Drawing.Point(282, 390);
            this.dateReturn.Name = "dateReturn";
            this.dateReturn.Size = new System.Drawing.Size(200, 20);
            this.dateReturn.TabIndex = 28;
            this.dateReturn.ValueChanged += new System.EventHandler(this.dateReturn_ValueChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(189, 387);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 23);
            this.label3.TabIndex = 29;
            this.label3.Text = "Book Return:  ";
            // 
            // lblNote
            // 
            this.lblNote.Location = new System.Drawing.Point(299, 452);
            this.lblNote.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(211, 83);
            this.lblNote.TabIndex = 30;
            this.lblNote.Text = "note";
            this.lblNote.Click += new System.EventHandler(this.lblNote_Click);
            // 
            // BookBorrowing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateReturn);
            this.Controls.Add(this.guna2Button3);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.nudMemberID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateBorrow);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.nudBookID);
            this.Controls.Add(this.bk1lbl7);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BookBorrowing";
            this.Size = new System.Drawing.Size(936, 860);
            this.Load += new System.EventHandler(this.BookBorrowing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudBookID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMemberID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label bk1lbl7;
        private System.Windows.Forms.NumericUpDown nudBookID;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.DateTimePicker dateBorrow;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.NumericUpDown nudMemberID;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private System.Windows.Forms.DateTimePicker dateReturn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNote;
    }
}
