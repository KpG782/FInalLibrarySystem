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
            this.lblNote = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateReturn = new System.Windows.Forms.DateTimePicker();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.nudMemberID = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dateBorrow = new System.Windows.Forms.DateTimePicker();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.nudBookID = new System.Windows.Forms.NumericUpDown();
            this.bk1lbl7 = new System.Windows.Forms.Label();
            this.bookDetails1 = new FInalLibrarySystem.Forms.bookDetails();
            ((System.ComponentModel.ISupportInitialize)(this.nudMemberID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBookID)).BeginInit();
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
            // lblNote
            // 
            this.lblNote.Location = new System.Drawing.Point(220, 447);
            this.lblNote.Multiline = true;
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(248, 99);
            this.lblNote.TabIndex = 51;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(182, 462);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 50;
            this.label6.Text = "Note:";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(268, 301);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 23);
            this.label4.TabIndex = 49;
            this.label4.Text = "Yes";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(150, 306);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 23);
            this.label5.TabIndex = 48;
            this.label5.Text = "Is This Book Available:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(144, 406);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 23);
            this.label3.TabIndex = 47;
            this.label3.Text = "Book Return:  ";
            // 
            // dateReturn
            // 
            this.dateReturn.Location = new System.Drawing.Point(237, 409);
            this.dateReturn.Name = "dateReturn";
            this.dateReturn.Size = new System.Drawing.Size(200, 20);
            this.dateReturn.TabIndex = 46;
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
            this.guna2Button3.Location = new System.Drawing.Point(406, 243);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(180, 45);
            this.guna2Button3.TabIndex = 45;
            this.guna2Button3.Text = "Name";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.LinkColor = System.Drawing.Color.White;
            this.linkLabel2.Location = new System.Drawing.Point(269, 277);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(76, 13);
            this.linkLabel2.TabIndex = 44;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Member Name";
            // 
            // nudMemberID
            // 
            this.nudMemberID.Location = new System.Drawing.Point(257, 246);
            this.nudMemberID.Name = "nudMemberID";
            this.nudMemberID.Size = new System.Drawing.Size(120, 20);
            this.nudMemberID.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(149, 243);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 23);
            this.label2.TabIndex = 42;
            this.label2.Text = "Enter member id ; ";
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
            this.guna2Button2.Location = new System.Drawing.Point(288, 568);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(180, 45);
            this.guna2Button2.TabIndex = 41;
            this.guna2Button2.Text = "Borrow Book";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(149, 354);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 23);
            this.label1.TabIndex = 40;
            this.label1.Text = "Issue Data:";
            // 
            // dateBorrow
            // 
            this.dateBorrow.Location = new System.Drawing.Point(242, 354);
            this.dateBorrow.Name = "dateBorrow";
            this.dateBorrow.Size = new System.Drawing.Size(200, 20);
            this.dateBorrow.TabIndex = 39;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(269, 209);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(55, 13);
            this.linkLabel1.TabIndex = 38;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Book Title";
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
            this.guna2Button1.Location = new System.Drawing.Point(406, 165);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(180, 45);
            this.guna2Button1.TabIndex = 37;
            this.guna2Button1.Text = "Search Book";
            // 
            // nudBookID
            // 
            this.nudBookID.Location = new System.Drawing.Point(257, 178);
            this.nudBookID.Name = "nudBookID";
            this.nudBookID.Size = new System.Drawing.Size(120, 20);
            this.nudBookID.TabIndex = 36;
            // 
            // bk1lbl7
            // 
            this.bk1lbl7.Location = new System.Drawing.Point(149, 175);
            this.bk1lbl7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bk1lbl7.Name = "bk1lbl7";
            this.bk1lbl7.Size = new System.Drawing.Size(88, 23);
            this.bk1lbl7.TabIndex = 35;
            this.bk1lbl7.Text = "Enter a book id ; ";
            // 
            // bookDetails1
            // 
            this.bookDetails1.Location = new System.Drawing.Point(105, 156);
            this.bookDetails1.Name = "bookDetails1";
            this.bookDetails1.Size = new System.Drawing.Size(481, 406);
            this.bookDetails1.TabIndex = 52;
            // 
            // BookBorrowing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.bookDetails1);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
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
            ((System.ComponentModel.ISupportInitialize)(this.nudMemberID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBookID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox lblNote;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateReturn;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.NumericUpDown nudMemberID;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateBorrow;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.NumericUpDown nudBookID;
        private System.Windows.Forms.Label bk1lbl7;
        private Forms.bookDetails bookDetails1;
    }
}
