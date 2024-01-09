namespace FInalLibrarySystem
{
    partial class BookReservation
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
            this.label2 = new System.Windows.Forms.Label();
            this.dtpReserve = new System.Windows.Forms.DateTimePicker();
            this.lblBorrow = new System.Windows.Forms.Label();
            this.AuthorLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.txtBookID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbPicture = new System.Windows.Forms.PictureBox();
            this.btnReserve = new System.Windows.Forms.Button();
            this.SecondaryPanel = new System.Windows.Forms.Panel();
            this.dgvBookReserved = new System.Windows.Forms.DataGridView();
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.Book_TItle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Book_Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Book_Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Book_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Book_Copyright = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.PrimaryPanel = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblUserName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.UserID = new System.Windows.Forms.Label();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.lblBookTitle = new System.Windows.Forms.Label();
            this.lblAuthorName = new System.Windows.Forms.Label();
            this.lbltitleBook = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnClear = new System.Windows.Forms.Button();
            this.ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReservedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).BeginInit();
            this.SecondaryPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookReserved)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            this.MainPanel.SuspendLayout();
            this.PrimaryPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Location = new System.Drawing.Point(51, 459);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 18);
            this.label2.TabIndex = 18;
            this.label2.Text = "BOOK ID:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpReserve
            // 
            this.dtpReserve.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpReserve.Location = new System.Drawing.Point(138, 633);
            this.dtpReserve.Margin = new System.Windows.Forms.Padding(2);
            this.dtpReserve.Name = "dtpReserve";
            this.dtpReserve.Size = new System.Drawing.Size(151, 20);
            this.dtpReserve.TabIndex = 0;
            this.dtpReserve.ValueChanged += new System.EventHandler(this.dtpReserve_ValueChanged);
            // 
            // lblBorrow
            // 
            this.lblBorrow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBorrow.Location = new System.Drawing.Point(52, 633);
            this.lblBorrow.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBorrow.Name = "lblBorrow";
            this.lblBorrow.Size = new System.Drawing.Size(81, 18);
            this.lblBorrow.TabIndex = 13;
            this.lblBorrow.Text = "BORROW";
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
            // btnReserve
            // 
            this.btnReserve.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReserve.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnReserve.BackColor = System.Drawing.Color.White;
            this.btnReserve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReserve.Location = new System.Drawing.Point(26, 680);
            this.btnReserve.Margin = new System.Windows.Forms.Padding(2);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(79, 32);
            this.btnReserve.TabIndex = 3;
            this.btnReserve.Text = "RESERVE";
            this.btnReserve.UseVisualStyleBackColor = false;
            this.btnReserve.Click += new System.EventHandler(this.btnReserve_Click);
            // 
            // SecondaryPanel
            // 
            this.SecondaryPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SecondaryPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SecondaryPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SecondaryPanel.Controls.Add(this.dgvBookReserved);
            this.SecondaryPanel.Controls.Add(this.dgvBooks);
            this.SecondaryPanel.Location = new System.Drawing.Point(404, 2);
            this.SecondaryPanel.Margin = new System.Windows.Forms.Padding(2);
            this.SecondaryPanel.Name = "SecondaryPanel";
            this.SecondaryPanel.Size = new System.Drawing.Size(526, 860);
            this.SecondaryPanel.TabIndex = 1;
            // 
            // dgvBookReserved
            // 
            this.dgvBookReserved.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvBookReserved.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBookReserved.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBookReserved.BackgroundColor = System.Drawing.Color.Black;
            this.dgvBookReserved.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBookReserved.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvBookReserved.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBookReserved.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBookReserved.ColumnHeadersHeight = 40;
            this.dgvBookReserved.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ISBN,
            this.Username,
            this.Title,
            this.Author,
            this.Status,
            this.ReservedDate});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBookReserved.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBookReserved.EnableHeadersVisualStyles = false;
            this.dgvBookReserved.Location = new System.Drawing.Point(-1, 336);
            this.dgvBookReserved.Margin = new System.Windows.Forms.Padding(2);
            this.dgvBookReserved.Name = "dgvBookReserved";
            this.dgvBookReserved.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBookReserved.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvBookReserved.RowHeadersWidth = 51;
            this.dgvBookReserved.RowTemplate.Height = 40;
            this.dgvBookReserved.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBookReserved.Size = new System.Drawing.Size(523, 341);
            this.dgvBookReserved.TabIndex = 25;
            this.dgvBookReserved.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBookReserved_CellContentClick);
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
            this.Book_TItle,
            this.SBN,
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
            this.dgvBooks.Location = new System.Drawing.Point(2, 2);
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
            this.dgvBooks.Size = new System.Drawing.Size(523, 341);
            this.dgvBooks.TabIndex = 24;
            this.dgvBooks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBooks_CellContentClick);
            // 
            // Book_TItle
            // 
            this.Book_TItle.HeaderText = "Book_TItle";
            this.Book_TItle.Name = "Book_TItle";
            // 
            // SBN
            // 
            this.SBN.HeaderText = "Book_ISBN";
            this.SBN.Name = "SBN";
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
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.SecondaryPanel);
            this.MainPanel.Controls.Add(this.PrimaryPanel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(2);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(936, 860);
            this.MainPanel.TabIndex = 3;
            // 
            // PrimaryPanel
            // 
            this.PrimaryPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PrimaryPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PrimaryPanel.Controls.Add(this.btnUpdate);
            this.PrimaryPanel.Controls.Add(this.btnCancel);
            this.PrimaryPanel.Controls.Add(this.lblUserName);
            this.PrimaryPanel.Controls.Add(this.label4);
            this.PrimaryPanel.Controls.Add(this.UserID);
            this.PrimaryPanel.Controls.Add(this.txtUserID);
            this.PrimaryPanel.Controls.Add(this.lblBookTitle);
            this.PrimaryPanel.Controls.Add(this.lblAuthorName);
            this.PrimaryPanel.Controls.Add(this.label2);
            this.PrimaryPanel.Controls.Add(this.lbltitleBook);
            this.PrimaryPanel.Controls.Add(this.dtpReserve);
            this.PrimaryPanel.Controls.Add(this.lblBorrow);
            this.PrimaryPanel.Controls.Add(this.AuthorLabel);
            this.PrimaryPanel.Controls.Add(this.TitleLabel);
            this.PrimaryPanel.Controls.Add(this.txtBookID);
            this.PrimaryPanel.Controls.Add(this.label1);
            this.PrimaryPanel.Controls.Add(this.pbPicture);
            this.PrimaryPanel.Controls.Add(this.btnClear);
            this.PrimaryPanel.Controls.Add(this.btnReserve);
            this.PrimaryPanel.Location = new System.Drawing.Point(2, 2);
            this.PrimaryPanel.Margin = new System.Windows.Forms.Padding(2);
            this.PrimaryPanel.Name = "PrimaryPanel";
            this.PrimaryPanel.Size = new System.Drawing.Size(416, 852);
            this.PrimaryPanel.TabIndex = 2;
            this.PrimaryPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.PrimaryPanel_Paint);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(278, 680);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(79, 32);
            this.btnCancel.TabIndex = 25;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
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
            // lbltitleBook
            // 
            this.lbltitleBook.BackColor = System.Drawing.Color.Transparent;
            this.lbltitleBook.Location = new System.Drawing.Point(101, 19);
            this.lbltitleBook.Name = "lbltitleBook";
            this.lbltitleBook.Size = new System.Drawing.Size(88, 15);
            this.lbltitleBook.TabIndex = 17;
            this.lbltitleBook.Text = "Book Reservation";
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Location = new System.Drawing.Point(112, 680);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(79, 32);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // ISBN
            // 
            this.ISBN.HeaderText = "ISBN";
            this.ISBN.Name = "ISBN";
            // 
            // Username
            // 
            this.Username.HeaderText = "Username";
            this.Username.Name = "Username";
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
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            // 
            // ReservedDate
            // 
            this.ReservedDate.HeaderText = "ReservedDate";
            this.ReservedDate.Name = "ReservedDate";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Location = new System.Drawing.Point(195, 680);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(79, 32);
            this.btnUpdate.TabIndex = 26;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // BookReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.MainPanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BookReservation";
            this.Size = new System.Drawing.Size(936, 860);
            this.Load += new System.EventHandler(this.BookReservation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).EndInit();
            this.SecondaryPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookReserved)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            this.MainPanel.ResumeLayout(false);
            this.PrimaryPanel.ResumeLayout(false);
            this.PrimaryPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpReserve;
        private System.Windows.Forms.Label lblBorrow;
        private System.Windows.Forms.Label AuthorLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.TextBox txtBookID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbPicture;
        private System.Windows.Forms.Button btnReserve;
        private System.Windows.Forms.Panel SecondaryPanel;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel PrimaryPanel;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label UserID;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.Label lblBookTitle;
        private System.Windows.Forms.Label lblAuthorName;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbltitleBook;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dgvBookReserved;
        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.DataGridViewTextBoxColumn Book_TItle;
        private System.Windows.Forms.DataGridViewTextBoxColumn SBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Book_Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Book_Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn Book_Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Book_Copyright;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReservedDate;
        private System.Windows.Forms.Button btnUpdate;
    }
}
