namespace FInalLibrarySystem
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.UProfileLinkList = new System.Windows.Forms.LinkLabel();
            this.SettingsLink = new System.Windows.Forms.LinkLabel();
            this.BookReservationLink = new System.Windows.Forms.LinkLabel();
            this.BookReturningLink = new System.Windows.Forms.LinkLabel();
            this.BookBorrowingLink = new System.Windows.Forms.LinkLabel();
            this.BorrowerListLink = new System.Windows.Forms.LinkLabel();
            this.BookListLink = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.penalty1 = new FInalLibrarySystem.Penalty();
            this.bookReservation1 = new FInalLibrarySystem.BookReservation();
            this.bookReturning1 = new FInalLibrarySystem.BookReturning();
            this.bookBorrowing1 = new FInalLibrarySystem.BookBorrowing();
            this.borrowerList1 = new FInalLibrarySystem.BorrowerList();
            this.bookList1 = new FInalLibrarySystem.BookList();
            this.profile1 = new FInalLibrarySystem.Profile();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabel3
            // 
            this.linkLabel3.ActiveLinkColor = System.Drawing.Color.Transparent;
            this.linkLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel3.Image = ((System.Drawing.Image)(resources.GetObject("linkLabel3.Image")));
            this.linkLabel3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkLabel3.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel3.LinkColor = System.Drawing.Color.White;
            this.linkLabel3.Location = new System.Drawing.Point(21, 537);
            this.linkLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(90, 52);
            this.linkLabel3.TabIndex = 25;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Penalty";
            this.linkLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // UProfileLinkList
            // 
            this.UProfileLinkList.ActiveLinkColor = System.Drawing.Color.Transparent;
            this.UProfileLinkList.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UProfileLinkList.Image = ((System.Drawing.Image)(resources.GetObject("UProfileLinkList.Image")));
            this.UProfileLinkList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UProfileLinkList.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.UProfileLinkList.LinkColor = System.Drawing.Color.White;
            this.UProfileLinkList.Location = new System.Drawing.Point(21, 152);
            this.UProfileLinkList.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UProfileLinkList.Name = "UProfileLinkList";
            this.UProfileLinkList.Size = new System.Drawing.Size(116, 52);
            this.UProfileLinkList.TabIndex = 24;
            this.UProfileLinkList.TabStop = true;
            this.UProfileLinkList.Text = "User Profile";
            this.UProfileLinkList.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UProfileLinkList.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.UProfileLinkList_LinkClicked);
            // 
            // SettingsLink
            // 
            this.SettingsLink.ActiveLinkColor = System.Drawing.Color.Transparent;
            this.SettingsLink.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsLink.Image = ((System.Drawing.Image)(resources.GetObject("SettingsLink.Image")));
            this.SettingsLink.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SettingsLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.SettingsLink.LinkColor = System.Drawing.Color.White;
            this.SettingsLink.Location = new System.Drawing.Point(20, 784);
            this.SettingsLink.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SettingsLink.Name = "SettingsLink";
            this.SettingsLink.Size = new System.Drawing.Size(100, 52);
            this.SettingsLink.TabIndex = 23;
            this.SettingsLink.TabStop = true;
            this.SettingsLink.Text = "Settings";
            this.SettingsLink.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BookReservationLink
            // 
            this.BookReservationLink.ActiveLinkColor = System.Drawing.Color.Transparent;
            this.BookReservationLink.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookReservationLink.Image = ((System.Drawing.Image)(resources.GetObject("BookReservationLink.Image")));
            this.BookReservationLink.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BookReservationLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.BookReservationLink.LinkColor = System.Drawing.Color.White;
            this.BookReservationLink.Location = new System.Drawing.Point(21, 472);
            this.BookReservationLink.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BookReservationLink.Name = "BookReservationLink";
            this.BookReservationLink.Size = new System.Drawing.Size(151, 52);
            this.BookReservationLink.TabIndex = 22;
            this.BookReservationLink.TabStop = true;
            this.BookReservationLink.Text = "Book Reservation";
            this.BookReservationLink.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BookReservationLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.BookReservationLink_LinkClicked);
            // 
            // BookReturningLink
            // 
            this.BookReturningLink.ActiveLinkColor = System.Drawing.Color.Transparent;
            this.BookReturningLink.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookReturningLink.Image = ((System.Drawing.Image)(resources.GetObject("BookReturningLink.Image")));
            this.BookReturningLink.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BookReturningLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.BookReturningLink.LinkColor = System.Drawing.Color.White;
            this.BookReturningLink.Location = new System.Drawing.Point(21, 408);
            this.BookReturningLink.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BookReturningLink.Name = "BookReturningLink";
            this.BookReturningLink.Size = new System.Drawing.Size(142, 52);
            this.BookReturningLink.TabIndex = 21;
            this.BookReturningLink.TabStop = true;
            this.BookReturningLink.Text = "Book Returning";
            this.BookReturningLink.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BookReturningLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.BookReturningLink_LinkClicked);
            // 
            // BookBorrowingLink
            // 
            this.BookBorrowingLink.ActiveLinkColor = System.Drawing.Color.Transparent;
            this.BookBorrowingLink.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookBorrowingLink.Image = ((System.Drawing.Image)(resources.GetObject("BookBorrowingLink.Image")));
            this.BookBorrowingLink.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BookBorrowingLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.BookBorrowingLink.LinkColor = System.Drawing.Color.White;
            this.BookBorrowingLink.Location = new System.Drawing.Point(21, 338);
            this.BookBorrowingLink.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BookBorrowingLink.Name = "BookBorrowingLink";
            this.BookBorrowingLink.Size = new System.Drawing.Size(142, 52);
            this.BookBorrowingLink.TabIndex = 20;
            this.BookBorrowingLink.TabStop = true;
            this.BookBorrowingLink.Text = "Book Borrowing";
            this.BookBorrowingLink.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BookBorrowingLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.BookBorrowingLink_LinkClicked);
            // 
            // BorrowerListLink
            // 
            this.BorrowerListLink.ActiveLinkColor = System.Drawing.Color.Transparent;
            this.BorrowerListLink.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BorrowerListLink.Image = ((System.Drawing.Image)(resources.GetObject("BorrowerListLink.Image")));
            this.BorrowerListLink.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BorrowerListLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.BorrowerListLink.LinkColor = System.Drawing.Color.White;
            this.BorrowerListLink.Location = new System.Drawing.Point(21, 278);
            this.BorrowerListLink.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BorrowerListLink.Name = "BorrowerListLink";
            this.BorrowerListLink.Size = new System.Drawing.Size(122, 52);
            this.BorrowerListLink.TabIndex = 19;
            this.BorrowerListLink.TabStop = true;
            this.BorrowerListLink.Text = "Borrower List";
            this.BorrowerListLink.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BorrowerListLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.BorrowerListLink_LinkClicked);
            // 
            // BookListLink
            // 
            this.BookListLink.ActiveLinkColor = System.Drawing.Color.Transparent;
            this.BookListLink.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookListLink.Image = ((System.Drawing.Image)(resources.GetObject("BookListLink.Image")));
            this.BookListLink.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BookListLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.BookListLink.LinkColor = System.Drawing.Color.White;
            this.BookListLink.Location = new System.Drawing.Point(21, 213);
            this.BookListLink.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BookListLink.Name = "BookListLink";
            this.BookListLink.Size = new System.Drawing.Size(100, 52);
            this.BookListLink.TabIndex = 18;
            this.BookListLink.TabStop = true;
            this.BookListLink.Text = "Book List";
            this.BookListLink.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BookListLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.BookListLink_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FInalLibrarySystem.Properties.Resources.logo_2;
            this.pictureBox1.Location = new System.Drawing.Point(24, 50);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1076, 4);
            this.guna2ControlBox1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(34, 24);
            this.guna2ControlBox1.TabIndex = 34;
            this.guna2ControlBox1.Click += new System.EventHandler(this.guna2ControlBox1_Click);
            // 
            // penalty1
            // 
            this.penalty1.BackColor = System.Drawing.Color.White;
            this.penalty1.Location = new System.Drawing.Point(192, -2);
            this.penalty1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.penalty1.Name = "penalty1";
            this.penalty1.Size = new System.Drawing.Size(926, 865);
            this.penalty1.TabIndex = 32;
            this.penalty1.Load += new System.EventHandler(this.penalty1_Load_2);
            // 
            // bookReservation1
            // 
            this.bookReservation1.BackColor = System.Drawing.Color.DarkGray;
            this.bookReservation1.Location = new System.Drawing.Point(192, 4);
            this.bookReservation1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bookReservation1.Name = "bookReservation1";
            this.bookReservation1.Size = new System.Drawing.Size(926, 860);
            this.bookReservation1.TabIndex = 31;
            // 
            // bookReturning1
            // 
            this.bookReturning1.BackColor = System.Drawing.Color.Silver;
            this.bookReturning1.Location = new System.Drawing.Point(533, 338);
            this.bookReturning1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bookReturning1.Name = "bookReturning1";
            this.bookReturning1.Size = new System.Drawing.Size(926, 860);
            this.bookReturning1.TabIndex = 30;
            // 
            // bookBorrowing1
            // 
            this.bookBorrowing1.BackColor = System.Drawing.Color.DimGray;
            this.bookBorrowing1.Location = new System.Drawing.Point(192, 4);
            this.bookBorrowing1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bookBorrowing1.Name = "bookBorrowing1";
            this.bookBorrowing1.Size = new System.Drawing.Size(926, 860);
            this.bookBorrowing1.TabIndex = 29;
            // 
            // borrowerList1
            // 
            this.borrowerList1.BackColor = System.Drawing.Color.LightGray;
            this.borrowerList1.Location = new System.Drawing.Point(192, 4);
            this.borrowerList1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.borrowerList1.Name = "borrowerList1";
            this.borrowerList1.Size = new System.Drawing.Size(936, 860);
            this.borrowerList1.TabIndex = 28;
            // 
            // bookList1
            // 
            this.bookList1.BackColor = System.Drawing.Color.Gray;
            this.bookList1.Location = new System.Drawing.Point(192, 4);
            this.bookList1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bookList1.Name = "bookList1";
            this.bookList1.Size = new System.Drawing.Size(926, 860);
            this.bookList1.TabIndex = 27;
            this.bookList1.Load += new System.EventHandler(this.bookList1_Load);
            // 
            // profile1
            // 
            this.profile1.BackColor = System.Drawing.Color.White;
            this.profile1.Location = new System.Drawing.Point(192, 4);
            this.profile1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.profile1.Name = "profile1";
            this.profile1.Size = new System.Drawing.Size(917, 860);
            this.profile1.TabIndex = 26;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1112, 687);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.penalty1);
            this.Controls.Add(this.bookReservation1);
            this.Controls.Add(this.bookReturning1);
            this.Controls.Add(this.bookBorrowing1);
            this.Controls.Add(this.borrowerList1);
            this.Controls.Add(this.bookList1);
            this.Controls.Add(this.profile1);
            this.Controls.Add(this.linkLabel3);
            this.Controls.Add(this.UProfileLinkList);
            this.Controls.Add(this.SettingsLink);
            this.Controls.Add(this.BookReservationLink);
            this.Controls.Add(this.BookReturningLink);
            this.Controls.Add(this.BookBorrowingLink);
            this.Controls.Add(this.BorrowerListLink);
            this.Controls.Add(this.BookListLink);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "s";
            this.Load += new System.EventHandler(this.Main_Page_Load);
            this.Shown += new System.EventHandler(this.MainPage_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.LinkLabel UProfileLinkList;
        private System.Windows.Forms.LinkLabel SettingsLink;
        private System.Windows.Forms.LinkLabel BookReservationLink;
        private System.Windows.Forms.LinkLabel BookReturningLink;
        private System.Windows.Forms.LinkLabel BookBorrowingLink;
        private System.Windows.Forms.LinkLabel BorrowerListLink;
        private System.Windows.Forms.LinkLabel BookListLink;
        private Profile profile1;
        private BookList bookList1;
        private BorrowerList borrowerList1;
        private BookBorrowing bookBorrowing1;
        private BookReturning bookReturning1;
        private BookReservation bookReservation1;
        private Penalty penalty1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
    }
}