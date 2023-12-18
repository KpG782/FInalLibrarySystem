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
            this.btnBookList = new System.Windows.Forms.Button();
            this.btnBorList = new System.Windows.Forms.Button();
            this.btnBookBor = new System.Windows.Forms.Button();
            this.btnBookReturn = new System.Windows.Forms.Button();
            this.bookReserv = new System.Windows.Forms.Button();
            this.btnBookPenalty = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.penalty1 = new FInalLibrarySystem.Penalty();
            this.bookReservation1 = new FInalLibrarySystem.BookReservation();
            this.bookReturning1 = new FInalLibrarySystem.BookReturning();
            this.bookBorrowing1 = new FInalLibrarySystem.BookBorrowing();
            this.borrowerList1 = new FInalLibrarySystem.BorrowerList();
            this.bookList1 = new FInalLibrarySystem.BookList();
            this.profile1 = new FInalLibrarySystem.Profile();
            this.SuspendLayout();
            // 
            // btnBookList
            // 
            this.btnBookList.Location = new System.Drawing.Point(19, 94);
            this.btnBookList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBookList.Name = "btnBookList";
            this.btnBookList.Size = new System.Drawing.Size(137, 44);
            this.btnBookList.TabIndex = 0;
            this.btnBookList.Text = "Book List";
            this.btnBookList.UseVisualStyleBackColor = true;
            this.btnBookList.Click += new System.EventHandler(this.btnBookList_Click);
            // 
            // btnBorList
            // 
            this.btnBorList.Location = new System.Drawing.Point(19, 153);
            this.btnBorList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBorList.Name = "btnBorList";
            this.btnBorList.Size = new System.Drawing.Size(137, 44);
            this.btnBorList.TabIndex = 1;
            this.btnBorList.Text = "Borrower List";
            this.btnBorList.UseVisualStyleBackColor = true;
            this.btnBorList.Click += new System.EventHandler(this.btnBorList_Click);
            // 
            // btnBookBor
            // 
            this.btnBookBor.Location = new System.Drawing.Point(19, 214);
            this.btnBookBor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBookBor.Name = "btnBookBor";
            this.btnBookBor.Size = new System.Drawing.Size(137, 44);
            this.btnBookBor.TabIndex = 2;
            this.btnBookBor.Text = "Book Borrowing";
            this.btnBookBor.UseVisualStyleBackColor = true;
            this.btnBookBor.Click += new System.EventHandler(this.btnBookBor_Click);
            // 
            // btnBookReturn
            // 
            this.btnBookReturn.Location = new System.Drawing.Point(19, 274);
            this.btnBookReturn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBookReturn.Name = "btnBookReturn";
            this.btnBookReturn.Size = new System.Drawing.Size(137, 44);
            this.btnBookReturn.TabIndex = 3;
            this.btnBookReturn.Text = "Book Returning";
            this.btnBookReturn.UseVisualStyleBackColor = true;
            this.btnBookReturn.Click += new System.EventHandler(this.btnBookReturn_Click);
            // 
            // bookReserv
            // 
            this.bookReserv.Location = new System.Drawing.Point(19, 334);
            this.bookReserv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bookReserv.Name = "bookReserv";
            this.bookReserv.Size = new System.Drawing.Size(137, 44);
            this.bookReserv.TabIndex = 4;
            this.bookReserv.Text = "Book Reservation";
            this.bookReserv.UseVisualStyleBackColor = true;
            this.bookReserv.Click += new System.EventHandler(this.bookReserv_Click);
            // 
            // btnBookPenalty
            // 
            this.btnBookPenalty.Location = new System.Drawing.Point(19, 395);
            this.btnBookPenalty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBookPenalty.Name = "btnBookPenalty";
            this.btnBookPenalty.Size = new System.Drawing.Size(137, 44);
            this.btnBookPenalty.TabIndex = 5;
            this.btnBookPenalty.Text = "Book Penalty";
            this.btnBookPenalty.UseVisualStyleBackColor = true;
            this.btnBookPenalty.Click += new System.EventHandler(this.btnBookPenalty_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.Location = new System.Drawing.Point(19, 33);
            this.btnProfile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(137, 44);
            this.btnProfile.TabIndex = 6;
            this.btnProfile.Text = "User Profile";
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // penalty1
            // 
            this.penalty1.Location = new System.Drawing.Point(177, 1);
            this.penalty1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.penalty1.Name = "penalty1";
            this.penalty1.Size = new System.Drawing.Size(891, 559);
            this.penalty1.TabIndex = 13;
            this.penalty1.Load += new System.EventHandler(this.penalty1_Load_1);
            // 
            // bookReservation1
            // 
            this.bookReservation1.Location = new System.Drawing.Point(168, 11);
            this.bookReservation1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bookReservation1.Name = "bookReservation1";
            this.bookReservation1.Size = new System.Drawing.Size(943, 569);
            this.bookReservation1.TabIndex = 12;
            // 
            // bookReturning1
            // 
            this.bookReturning1.Location = new System.Drawing.Point(168, 1);
            this.bookReturning1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bookReturning1.Name = "bookReturning1";
            this.bookReturning1.Size = new System.Drawing.Size(873, 542);
            this.bookReturning1.TabIndex = 11;
            // 
            // bookBorrowing1
            // 
            this.bookBorrowing1.Location = new System.Drawing.Point(161, -4);
            this.bookBorrowing1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bookBorrowing1.Name = "bookBorrowing1";
            this.bookBorrowing1.Size = new System.Drawing.Size(1013, 583);
            this.bookBorrowing1.TabIndex = 10;
            // 
            // borrowerList1
            // 
            this.borrowerList1.Location = new System.Drawing.Point(161, 5);
            this.borrowerList1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.borrowerList1.Name = "borrowerList1";
            this.borrowerList1.Size = new System.Drawing.Size(851, 555);
            this.borrowerList1.TabIndex = 9;
            // 
            // bookList1
            // 
            this.bookList1.Location = new System.Drawing.Point(161, -6);
            this.bookList1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bookList1.Name = "bookList1";
            this.bookList1.Size = new System.Drawing.Size(907, 566);
            this.bookList1.TabIndex = 8;
            // 
            // profile1
            // 
            this.profile1.Location = new System.Drawing.Point(161, -6);
            this.profile1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.profile1.Name = "profile1";
            this.profile1.Size = new System.Drawing.Size(941, 542);
            this.profile1.TabIndex = 7;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 593);
            this.Controls.Add(this.penalty1);
            this.Controls.Add(this.bookReservation1);
            this.Controls.Add(this.bookReturning1);
            this.Controls.Add(this.bookBorrowing1);
            this.Controls.Add(this.borrowerList1);
            this.Controls.Add(this.bookList1);
            this.Controls.Add(this.profile1);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.btnBookPenalty);
            this.Controls.Add(this.bookReserv);
            this.Controls.Add(this.btnBookReturn);
            this.Controls.Add(this.btnBookBor);
            this.Controls.Add(this.btnBorList);
            this.Controls.Add(this.btnBookList);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainPage";
            this.Text = "Main_Page";
            this.Load += new System.EventHandler(this.Main_Page_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBookList;
        private System.Windows.Forms.Button btnBorList;
        private System.Windows.Forms.Button btnBookBor;
        private System.Windows.Forms.Button btnBookReturn;
        private System.Windows.Forms.Button bookReserv;
        private System.Windows.Forms.Button btnBookPenalty;
        private System.Windows.Forms.Button btnProfile;
        private Profile profile1;
        private BookList bookList1;
        private BorrowerList borrowerList1;
        private BookBorrowing bookBorrowing1;
        private BookReturning bookReturning1;
        private BookReservation bookReservation1;
        private Penalty penalty1;
    }
}