namespace FInalLibrarySystem
{
    partial class BookReturning
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.SecondaryPanel = new System.Windows.Forms.Panel();
            this.dgvBookBorrow = new System.Windows.Forms.DataGridView();
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.Book_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Book_TItle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Book_ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Book_Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Book_Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Book_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Book_Copyright = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrimaryPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblUserName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.UserID = new System.Windows.Forms.Label();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.lblBookTitle = new System.Windows.Forms.Label();
            this.lblAuthorName = new System.Windows.Forms.Label();
            this.lblBookID = new System.Windows.Forms.Label();
            this.lbltitleBook = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblBorrow = new System.Windows.Forms.Label();
            this.AuthorLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.txtBookID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pbPicture = new System.Windows.Forms.PictureBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BookPictureBox = new System.Windows.Forms.PictureBox();
            this.lblbook = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Borrowed_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Returned_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reserved_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dtpReturn = new System.Windows.Forms.DateTimePicker();
            this.MainPanel.SuspendLayout();
            this.SecondaryPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookBorrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            this.PrimaryPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.SecondaryPanel);
            this.MainPanel.Controls.Add(this.PrimaryPanel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(2);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(918, 687);
            this.MainPanel.TabIndex = 0;
            this.MainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MainPanel_Paint);
            // 
            // SecondaryPanel
            // 
            this.SecondaryPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SecondaryPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SecondaryPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SecondaryPanel.Controls.Add(this.dgvBookBorrow);
            this.SecondaryPanel.Controls.Add(this.dgvBooks);
            this.SecondaryPanel.Location = new System.Drawing.Point(404, 2);
            this.SecondaryPanel.Margin = new System.Windows.Forms.Padding(2);
            this.SecondaryPanel.Name = "SecondaryPanel";
            this.SecondaryPanel.Size = new System.Drawing.Size(508, 687);
            this.SecondaryPanel.TabIndex = 1;
            // 
            // dgvBookBorrow
            // 
            this.dgvBookBorrow.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvBookBorrow.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBookBorrow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBookBorrow.BackgroundColor = System.Drawing.Color.Black;
            this.dgvBookBorrow.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBookBorrow.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvBookBorrow.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBookBorrow.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBookBorrow.ColumnHeadersHeight = 40;
            this.dgvBookBorrow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Username,
            this.ISBN,
            this.Title,
            this.Author,
            this.Borrowed_Date,
            this.Returned_Date,
            this.Reserved_Date});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBookBorrow.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBookBorrow.EnableHeadersVisualStyles = false;
            this.dgvBookBorrow.Location = new System.Drawing.Point(-5, 337);
            this.dgvBookBorrow.Margin = new System.Windows.Forms.Padding(2);
            this.dgvBookBorrow.Name = "dgvBookBorrow";
            this.dgvBookBorrow.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBookBorrow.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvBookBorrow.RowHeadersWidth = 51;
            this.dgvBookBorrow.RowTemplate.Height = 40;
            this.dgvBookBorrow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBookBorrow.Size = new System.Drawing.Size(512, 341);
            this.dgvBookBorrow.TabIndex = 23;
            this.dgvBookBorrow.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBookBorrow_CellContentClick);
            // 
            // dgvBooks
            // 
            this.dgvBooks.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvBooks.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBooks.BackgroundColor = System.Drawing.Color.Black;
            this.dgvBooks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBooks.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvBooks.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBooks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvBooks.ColumnHeadersHeight = 40;
            this.dgvBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Book_ID,
            this.Book_TItle,
            this.Book_ISBN,
            this.Book_Category,
            this.Book_Author,
            this.Book_Status,
            this.Book_Copyright});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBooks.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvBooks.EnableHeadersVisualStyles = false;
            this.dgvBooks.Location = new System.Drawing.Point(-1, -3);
            this.dgvBooks.Margin = new System.Windows.Forms.Padding(2);
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBooks.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvBooks.RowHeadersWidth = 51;
            this.dgvBooks.RowTemplate.Height = 40;
            this.dgvBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBooks.Size = new System.Drawing.Size(512, 341);
            this.dgvBooks.TabIndex = 22;
            this.dgvBooks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBooks_CellContentClick);
            // 
            // Book_ID
            // 
            this.Book_ID.HeaderText = "Book_ID";
            this.Book_ID.Name = "Book_ID";
            // 
            // Book_TItle
            // 
            this.Book_TItle.HeaderText = "Book_TItle";
            this.Book_TItle.Name = "Book_TItle";
            // 
            // Book_ISBN
            // 
            this.Book_ISBN.HeaderText = "Book_ISBN";
            this.Book_ISBN.Name = "Book_ISBN";
            // 
            // Book_Category
            // 
            this.Book_Category.HeaderText = "Book_Category";
            this.Book_Category.Name = "Book_Category";
            // 
            // Book_Author
            // 
            this.Book_Author.HeaderText = "Book_Author";
            this.Book_Author.Name = "Book_Author";
            // 
            // Book_Status
            // 
            this.Book_Status.HeaderText = "Book_Status";
            this.Book_Status.Name = "Book_Status";
            // 
            // Book_Copyright
            // 
            this.Book_Copyright.HeaderText = "Book_Copyright";
            this.Book_Copyright.Name = "Book_Copyright";
            // 
            // PrimaryPanel
            // 
            this.PrimaryPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PrimaryPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PrimaryPanel.Controls.Add(this.panel1);
            this.PrimaryPanel.Controls.Add(this.lblTitle);
            this.PrimaryPanel.Controls.Add(this.label1);
            this.PrimaryPanel.Controls.Add(this.BookPictureBox);
            this.PrimaryPanel.Location = new System.Drawing.Point(2, 2);
            this.PrimaryPanel.Margin = new System.Windows.Forms.Padding(2);
            this.PrimaryPanel.Name = "PrimaryPanel";
            this.PrimaryPanel.Size = new System.Drawing.Size(398, 679);
            this.PrimaryPanel.TabIndex = 2;
            this.PrimaryPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.PrimaryPanel_Paint);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dtpReturn);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.lblbook);
            this.panel1.Controls.Add(this.lblUserName);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.UserID);
            this.panel1.Controls.Add(this.txtUserID);
            this.panel1.Controls.Add(this.lblBookTitle);
            this.panel1.Controls.Add(this.lblAuthorName);
            this.panel1.Controls.Add(this.lblBookID);
            this.panel1.Controls.Add(this.lbltitleBook);
            this.panel1.Controls.Add(this.lblBorrow);
            this.panel1.Controls.Add(this.AuthorLabel);
            this.panel1.Controls.Add(this.TitleLabel);
            this.panel1.Controls.Add(this.txtBookID);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pbPicture);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnReturn);
            this.panel1.Location = new System.Drawing.Point(-10, -88);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(416, 852);
            this.panel1.TabIndex = 18;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_2);
            // 
            // lblUserName
            // 
            this.lblUserName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUserName.Location = new System.Drawing.Point(109, 590);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(238, 18);
            this.lblUserName.TabIndex = 24;
            this.lblUserName.Text = "Username";
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblUserName.Click += new System.EventHandler(this.lblUserName_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.Location = new System.Drawing.Point(38, 590);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 18);
            this.label4.TabIndex = 23;
            this.label4.Text = "USERNAME";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserID
            // 
            this.UserID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UserID.Location = new System.Drawing.Point(51, 557);
            this.UserID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UserID.Name = "UserID";
            this.UserID.Size = new System.Drawing.Size(71, 18);
            this.UserID.TabIndex = 22;
            this.UserID.Text = "USER ID:";
            this.UserID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtUserID
            // 
            this.txtUserID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUserID.Location = new System.Drawing.Point(126, 557);
            this.txtUserID.Margin = new System.Windows.Forms.Padding(2);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(221, 20);
            this.txtUserID.TabIndex = 21;
            this.txtUserID.TextChanged += new System.EventHandler(this.txtUserID_TextChanged);
            // 
            // lblBookTitle
            // 
            this.lblBookTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBookTitle.Location = new System.Drawing.Point(109, 498);
            this.lblBookTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBookTitle.Name = "lblBookTitle";
            this.lblBookTitle.Size = new System.Drawing.Size(238, 18);
            this.lblBookTitle.TabIndex = 20;
            this.lblBookTitle.Text = "Book Title";
            this.lblBookTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBookTitle.Click += new System.EventHandler(this.lblBookTitle_Click);
            // 
            // lblAuthorName
            // 
            this.lblAuthorName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAuthorName.Location = new System.Drawing.Point(109, 527);
            this.lblAuthorName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAuthorName.Name = "lblAuthorName";
            this.lblAuthorName.Size = new System.Drawing.Size(238, 18);
            this.lblAuthorName.TabIndex = 19;
            this.lblAuthorName.Text = "AuthorName";
            this.lblAuthorName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAuthorName.Click += new System.EventHandler(this.lblAuthorName_Click);
            // 
            // lblBookID
            // 
            this.lblBookID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBookID.Location = new System.Drawing.Point(51, 459);
            this.lblBookID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBookID.Name = "lblBookID";
            this.lblBookID.Size = new System.Drawing.Size(71, 18);
            this.lblBookID.TabIndex = 18;
            this.lblBookID.Text = "BOOK ID:";
            this.lblBookID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbltitleBook
            // 
            this.lbltitleBook.BackColor = System.Drawing.Color.Transparent;
            this.lbltitleBook.Location = new System.Drawing.Point(101, 19);
            this.lbltitleBook.Name = "lbltitleBook";
            this.lbltitleBook.Size = new System.Drawing.Size(78, 15);
            this.lbltitleBook.TabIndex = 17;
            this.lbltitleBook.Text = "Book Borrowing";
            // 
            // lblBorrow
            // 
            this.lblBorrow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBorrow.Location = new System.Drawing.Point(52, 633);
            this.lblBorrow.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBorrow.Name = "lblBorrow";
            this.lblBorrow.Size = new System.Drawing.Size(81, 18);
            this.lblBorrow.TabIndex = 13;
            this.lblBorrow.Text = "RETURN";
            this.lblBorrow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AuthorLabel
            // 
            this.AuthorLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AuthorLabel.Location = new System.Drawing.Point(52, 527);
            this.AuthorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Size = new System.Drawing.Size(53, 18);
            this.AuthorLabel.TabIndex = 12;
            this.AuthorLabel.Text = "AUTHOR:";
            this.AuthorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TitleLabel
            // 
            this.TitleLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TitleLabel.Location = new System.Drawing.Point(21, 498);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(112, 18);
            this.TitleLabel.TabIndex = 11;
            this.TitleLabel.Text = "BOOK TITLE:";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBookID
            // 
            this.txtBookID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBookID.Location = new System.Drawing.Point(126, 459);
            this.txtBookID.Margin = new System.Windows.Forms.Padding(2);
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.Size = new System.Drawing.Size(221, 20);
            this.txtBookID.TabIndex = 1;
            this.txtBookID.TextChanged += new System.EventHandler(this.txtBookID_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-98, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "label3";
            // 
            // pbPicture
            // 
            this.pbPicture.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbPicture.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pbPicture.Location = new System.Drawing.Point(95, 150);
            this.pbPicture.Margin = new System.Windows.Forms.Padding(2);
            this.pbPicture.Name = "pbPicture";
            this.pbPicture.Size = new System.Drawing.Size(194, 275);
            this.pbPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPicture.TabIndex = 6;
            this.pbPicture.TabStop = false;
            this.pbPicture.Click += new System.EventHandler(this.pbPicture_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Location = new System.Drawing.Point(254, 680);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(79, 32);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReturn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnReturn.BackColor = System.Drawing.Color.White;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Location = new System.Drawing.Point(65, 680);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(2);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(79, 32);
            this.btnReturn.TabIndex = 3;
            this.btnReturn.Text = "RETURN";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnBorrow_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.Location = new System.Drawing.Point(112, 20);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(151, 18);
            this.lblTitle.TabIndex = 17;
            this.lblTitle.Text = "Book Returning";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-98, 82);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            // 
            // BookPictureBox
            // 
            this.BookPictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BookPictureBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BookPictureBox.Location = new System.Drawing.Point(86, 63);
            this.BookPictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.BookPictureBox.Name = "BookPictureBox";
            this.BookPictureBox.Size = new System.Drawing.Size(194, 275);
            this.BookPictureBox.TabIndex = 6;
            this.BookPictureBox.TabStop = false;
            // 
            // lblbook
            // 
            this.lblbook.BackColor = System.Drawing.Color.Transparent;
            this.lblbook.Location = new System.Drawing.Point(158, 107);
            this.lblbook.Name = "lblbook";
            this.lblbook.Size = new System.Drawing.Size(77, 15);
            this.lblbook.TabIndex = 25;
            this.lblbook.Text = "Book Returning";
            // 
            // Username
            // 
            this.Username.HeaderText = "Username";
            this.Username.Name = "Username";
            // 
            // ISBN
            // 
            this.ISBN.HeaderText = "ISBN";
            this.ISBN.Name = "ISBN";
            // 
            // Title
            // 
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            // 
            // Author
            // 
            this.Author.HeaderText = "Author";
            this.Author.Name = "Author";
            // 
            // Borrowed_Date
            // 
            this.Borrowed_Date.HeaderText = "Borrowed_Date";
            this.Borrowed_Date.Name = "Borrowed_Date";
            // 
            // Returned_Date
            // 
            this.Returned_Date.HeaderText = "Returned_Date";
            this.Returned_Date.Name = "Returned_Date";
            // 
            // Reserved_Date
            // 
            this.Reserved_Date.HeaderText = "Reserved_Date";
            this.Reserved_Date.Name = "Reserved_Date";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUpdate.BackColor = System.Drawing.Color.White;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Location = new System.Drawing.Point(158, 680);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(79, 32);
            this.btnUpdate.TabIndex = 26;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dtpReturn
            // 
            this.dtpReturn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpReturn.Location = new System.Drawing.Point(138, 630);
            this.dtpReturn.Margin = new System.Windows.Forms.Padding(2);
            this.dtpReturn.Name = "dtpReturn";
            this.dtpReturn.Size = new System.Drawing.Size(151, 20);
            this.dtpReturn.TabIndex = 27;
            // 
            // BookReturning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.MainPanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BookReturning";
            this.Size = new System.Drawing.Size(918, 687);
            this.MainPanel.ResumeLayout(false);
            this.SecondaryPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookBorrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            this.PrimaryPanel.ResumeLayout(false);
            this.PrimaryPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel SecondaryPanel;
        private System.Windows.Forms.Panel PrimaryPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox BookPictureBox;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.DataGridViewTextBoxColumn Book_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Book_TItle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Book_ISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Book_Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Book_Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn Book_Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Book_Copyright;
        private System.Windows.Forms.DataGridView dgvBookBorrow;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label UserID;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.Label lblBookTitle;
        private System.Windows.Forms.Label lblAuthorName;
        private System.Windows.Forms.Label lblBookID;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbltitleBook;
        private System.Windows.Forms.Label lblBorrow;
        private System.Windows.Forms.Label AuthorLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.TextBox txtBookID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbPicture;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnReturn;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblbook;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn Borrowed_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Returned_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reserved_Date;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DateTimePicker dtpReturn;
    }
}
