﻿namespace FInalLibrarySystem
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
            this.lblborrow = new System.Windows.Forms.Label();
            this.LBLBookID = new System.Windows.Forms.Label();
            this.lbluser = new System.Windows.Forms.Label();
            this.txtBookID = new Guna.UI2.WinForms.Guna2TextBox();
            this.LBLUserID = new System.Windows.Forms.Label();
            this.txtUserID = new Guna.UI2.WinForms.Guna2TextBox();
            this.LBLTitle = new System.Windows.Forms.Label();
            this.dgvBookReserved = new System.Windows.Forms.DataGridView();
            this.ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReservedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SecondaryPanel = new System.Windows.Forms.Panel();
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.Book_TItle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Book_Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Book_Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Book_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Book_Copyright = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.PrimaryPanel = new System.Windows.Forms.Panel();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblAuthorName = new System.Windows.Forms.Label();
            this.lblBookTitle = new System.Windows.Forms.Label();
            this.btnClear = new Guna.UI2.WinForms.Guna2Button();
            this.lbltitleBook = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnReserve = new Guna.UI2.WinForms.Guna2Button();
            this.pbPicture = new Guna.UI2.WinForms.Guna2PictureBox();
            this.dtpReserve = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.LBLAuthor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookReserved)).BeginInit();
            this.SecondaryPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            this.MainPanel.SuspendLayout();
            this.PrimaryPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // lblborrow
            // 
            this.lblborrow.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblborrow.Location = new System.Drawing.Point(21, 546);
            this.lblborrow.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblborrow.Name = "lblborrow";
            this.lblborrow.Size = new System.Drawing.Size(69, 18);
            this.lblborrow.TabIndex = 55;
            this.lblborrow.Text = "RESERVE:";
            this.lblborrow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LBLBookID
            // 
            this.LBLBookID.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLBookID.Location = new System.Drawing.Point(21, 385);
            this.LBLBookID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBLBookID.Name = "LBLBookID";
            this.LBLBookID.Size = new System.Drawing.Size(69, 18);
            this.LBLBookID.TabIndex = 56;
            this.LBLBookID.Text = "BOOK ID:";
            this.LBLBookID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbluser
            // 
            this.lbluser.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluser.Location = new System.Drawing.Point(21, 512);
            this.lbluser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(69, 18);
            this.lbluser.TabIndex = 58;
            this.lbluser.Text = "USERNAME:";
            this.lbluser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtBookID
            // 
            this.txtBookID.BorderColor = System.Drawing.Color.Black;
            this.txtBookID.BorderRadius = 10;
            this.txtBookID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBookID.DefaultText = "";
            this.txtBookID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBookID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBookID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBookID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBookID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBookID.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.txtBookID.ForeColor = System.Drawing.Color.Black;
            this.txtBookID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBookID.Location = new System.Drawing.Point(94, 385);
            this.txtBookID.Margin = new System.Windows.Forms.Padding(2);
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.PasswordChar = '\0';
            this.txtBookID.PlaceholderText = "";
            this.txtBookID.SelectedText = "";
            this.txtBookID.Size = new System.Drawing.Size(244, 24);
            this.txtBookID.TabIndex = 60;
            this.txtBookID.TextChanged += new System.EventHandler(this.txtBookID_TextChanged_1);
            // 
            // LBLUserID
            // 
            this.LBLUserID.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLUserID.Location = new System.Drawing.Point(21, 480);
            this.LBLUserID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBLUserID.Name = "LBLUserID";
            this.LBLUserID.Size = new System.Drawing.Size(69, 18);
            this.LBLUserID.TabIndex = 57;
            this.LBLUserID.Text = "USER ID:";
            this.LBLUserID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtUserID
            // 
            this.txtUserID.BorderColor = System.Drawing.Color.Black;
            this.txtUserID.BorderRadius = 10;
            this.txtUserID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserID.DefaultText = "";
            this.txtUserID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUserID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUserID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserID.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.txtUserID.ForeColor = System.Drawing.Color.Black;
            this.txtUserID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserID.Location = new System.Drawing.Point(94, 480);
            this.txtUserID.Margin = new System.Windows.Forms.Padding(2);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.PasswordChar = '\0';
            this.txtUserID.PlaceholderText = "";
            this.txtUserID.SelectedText = "";
            this.txtUserID.Size = new System.Drawing.Size(244, 24);
            this.txtUserID.TabIndex = 61;
            this.txtUserID.TextChanged += new System.EventHandler(this.txtUserID_TextChanged_1);
            // 
            // LBLTitle
            // 
            this.LBLTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLTitle.Location = new System.Drawing.Point(21, 422);
            this.LBLTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBLTitle.Name = "LBLTitle";
            this.LBLTitle.Size = new System.Drawing.Size(69, 18);
            this.LBLTitle.TabIndex = 53;
            this.LBLTitle.Text = "BOOK TITLE:";
            this.LBLTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.FullName,
            this.Title,
            this.Author,
            this.dataGridViewTextBoxColumn6,
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
            this.dgvBookReserved.Location = new System.Drawing.Point(2, 331);
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
            this.dgvBookReserved.Size = new System.Drawing.Size(523, 351);
            this.dgvBookReserved.TabIndex = 26;
            this.dgvBookReserved.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBookReserved_CellContentClick_1);
            // 
            // ISBN
            // 
            this.ISBN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ISBN.FillWeight = 73.73386F;
            this.ISBN.HeaderText = "Book_ISBN";
            this.ISBN.Name = "ISBN";
            this.ISBN.Width = 96;
            // 
            // FullName
            // 
            this.FullName.HeaderText = "FullName";
            this.FullName.Name = "FullName";
            // 
            // Title
            // 
            this.Title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Title.FillWeight = 58.17943F;
            this.Title.HeaderText = "Book_TItle";
            this.Title.Name = "Title";
            this.Title.Width = 95;
            // 
            // Author
            // 
            this.Author.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Author.FillWeight = 117.2417F;
            this.Author.HeaderText = "Book_Author";
            this.Author.Name = "Author";
            this.Author.Width = 110;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn6.FillWeight = 145.6994F;
            this.dataGridViewTextBoxColumn6.HeaderText = "Book_Status";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 105;
            // 
            // ReservedDate
            // 
            this.ReservedDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ReservedDate.FillWeight = 177.665F;
            this.ReservedDate.HeaderText = "ReservedDate";
            this.ReservedDate.Name = "ReservedDate";
            this.ReservedDate.Width = 116;
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
            this.dgvBooks.Size = new System.Drawing.Size(523, 330);
            this.dgvBooks.TabIndex = 25;
            // 
            // Book_TItle
            // 
            this.Book_TItle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Book_TItle.FillWeight = 58.17943F;
            this.Book_TItle.HeaderText = "Book_TItle";
            this.Book_TItle.Name = "Book_TItle";
            this.Book_TItle.Width = 95;
            // 
            // SBN
            // 
            this.SBN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.SBN.FillWeight = 73.73386F;
            this.SBN.HeaderText = "Book_ISBN";
            this.SBN.Name = "SBN";
            this.SBN.Width = 96;
            // 
            // Book_Category
            // 
            this.Book_Category.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Book_Category.FillWeight = 93.26363F;
            this.Book_Category.HeaderText = "Book_Category";
            this.Book_Category.Name = "Book_Category";
            this.Book_Category.Width = 123;
            // 
            // Book_Author
            // 
            this.Book_Author.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Book_Author.FillWeight = 117.2417F;
            this.Book_Author.HeaderText = "Book_Author";
            this.Book_Author.Name = "Book_Author";
            this.Book_Author.Width = 110;
            // 
            // Book_Status
            // 
            this.Book_Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Book_Status.FillWeight = 145.6994F;
            this.Book_Status.HeaderText = "Book_Status";
            this.Book_Status.Name = "Book_Status";
            this.Book_Status.Width = 105;
            // 
            // Book_Copyright
            // 
            this.Book_Copyright.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Book_Copyright.FillWeight = 177.665F;
            this.Book_Copyright.HeaderText = "Book_Copyright";
            this.Book_Copyright.Name = "Book_Copyright";
            this.Book_Copyright.Width = 128;
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
            this.MainPanel.TabIndex = 5;
            // 
            // PrimaryPanel
            // 
            this.PrimaryPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PrimaryPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PrimaryPanel.Controls.Add(this.btnCancel);
            this.PrimaryPanel.Controls.Add(this.btnUpdate);
            this.PrimaryPanel.Controls.Add(this.lblUserName);
            this.PrimaryPanel.Controls.Add(this.lblAuthorName);
            this.PrimaryPanel.Controls.Add(this.lblBookTitle);
            this.PrimaryPanel.Controls.Add(this.btnClear);
            this.PrimaryPanel.Controls.Add(this.lbltitleBook);
            this.PrimaryPanel.Controls.Add(this.btnReserve);
            this.PrimaryPanel.Controls.Add(this.pbPicture);
            this.PrimaryPanel.Controls.Add(this.dtpReserve);
            this.PrimaryPanel.Controls.Add(this.lblborrow);
            this.PrimaryPanel.Controls.Add(this.LBLBookID);
            this.PrimaryPanel.Controls.Add(this.lbluser);
            this.PrimaryPanel.Controls.Add(this.txtUserID);
            this.PrimaryPanel.Controls.Add(this.txtBookID);
            this.PrimaryPanel.Controls.Add(this.LBLUserID);
            this.PrimaryPanel.Controls.Add(this.LBLTitle);
            this.PrimaryPanel.Controls.Add(this.LBLAuthor);
            this.PrimaryPanel.Controls.Add(this.label1);
            this.PrimaryPanel.Location = new System.Drawing.Point(2, 2);
            this.PrimaryPanel.Margin = new System.Windows.Forms.Padding(2);
            this.PrimaryPanel.Name = "PrimaryPanel";
            this.PrimaryPanel.Size = new System.Drawing.Size(416, 852);
            this.PrimaryPanel.TabIndex = 2;
            this.PrimaryPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.PrimaryPanel_Paint_1);
            // 
            // btnCancel
            // 
            this.btnCancel.BorderRadius = 15;
            this.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancel.FillColor = System.Drawing.Color.IndianRed;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(206, 592);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(82, 30);
            this.btnCancel.TabIndex = 69;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BorderRadius = 15;
            this.btnUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdate.FillColor = System.Drawing.Color.IndianRed;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Location = new System.Drawing.Point(118, 592);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(87, 30);
            this.btnUpdate.TabIndex = 68;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click_1);
            // 
            // lblUserName
            // 
            this.lblUserName.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(100, 512);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(238, 18);
            this.lblUserName.TabIndex = 67;
            this.lblUserName.Text = "Username";
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAuthorName
            // 
            this.lblAuthorName.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthorName.Location = new System.Drawing.Point(100, 451);
            this.lblAuthorName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAuthorName.Name = "lblAuthorName";
            this.lblAuthorName.Size = new System.Drawing.Size(238, 18);
            this.lblAuthorName.TabIndex = 66;
            this.lblAuthorName.Text = "AuthorName";
            this.lblAuthorName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBookTitle
            // 
            this.lblBookTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookTitle.Location = new System.Drawing.Point(100, 422);
            this.lblBookTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBookTitle.Name = "lblBookTitle";
            this.lblBookTitle.Size = new System.Drawing.Size(238, 18);
            this.lblBookTitle.TabIndex = 65;
            this.lblBookTitle.Text = "Book Title";
            this.lblBookTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClear
            // 
            this.btnClear.BorderRadius = 15;
            this.btnClear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClear.FillColor = System.Drawing.Color.IndianRed;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(292, 592);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(84, 30);
            this.btnClear.TabIndex = 64;
            this.btnClear.Text = "CLEAR";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click_1);
            // 
            // lbltitleBook
            // 
            this.lbltitleBook.BackColor = System.Drawing.Color.Transparent;
            this.lbltitleBook.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitleBook.Location = new System.Drawing.Point(116, 33);
            this.lbltitleBook.Name = "lbltitleBook";
            this.lbltitleBook.Size = new System.Drawing.Size(141, 23);
            this.lbltitleBook.TabIndex = 52;
            this.lbltitleBook.Text = "Book Reservation";
            // 
            // btnReserve
            // 
            this.btnReserve.BorderRadius = 15;
            this.btnReserve.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReserve.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReserve.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReserve.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReserve.FillColor = System.Drawing.Color.DarkSeaGreen;
            this.btnReserve.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReserve.ForeColor = System.Drawing.Color.Black;
            this.btnReserve.Location = new System.Drawing.Point(24, 592);
            this.btnReserve.Margin = new System.Windows.Forms.Padding(2);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(90, 30);
            this.btnReserve.TabIndex = 63;
            this.btnReserve.Text = "RESERVE";
            this.btnReserve.Click += new System.EventHandler(this.btnReserve_Click_1);
            // 
            // pbPicture
            // 
            this.pbPicture.BorderRadius = 20;
            this.pbPicture.FillColor = System.Drawing.SystemColors.ActiveBorder;
            this.pbPicture.ImageRotate = 0F;
            this.pbPicture.Location = new System.Drawing.Point(94, 83);
            this.pbPicture.Margin = new System.Windows.Forms.Padding(2);
            this.pbPicture.Name = "pbPicture";
            this.pbPicture.Size = new System.Drawing.Size(194, 275);
            this.pbPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPicture.TabIndex = 59;
            this.pbPicture.TabStop = false;
            // 
            // dtpReserve
            // 
            this.dtpReserve.BorderRadius = 10;
            this.dtpReserve.BorderThickness = 1;
            this.dtpReserve.Checked = true;
            this.dtpReserve.FillColor = System.Drawing.Color.White;
            this.dtpReserve.Font = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpReserve.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpReserve.Location = new System.Drawing.Point(103, 546);
            this.dtpReserve.Margin = new System.Windows.Forms.Padding(2);
            this.dtpReserve.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpReserve.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpReserve.Name = "dtpReserve";
            this.dtpReserve.Size = new System.Drawing.Size(205, 25);
            this.dtpReserve.TabIndex = 62;
            this.dtpReserve.Value = new System.DateTime(2024, 1, 10, 14, 37, 0, 0);
            // 
            // LBLAuthor
            // 
            this.LBLAuthor.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLAuthor.Location = new System.Drawing.Point(21, 452);
            this.LBLAuthor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBLAuthor.Name = "LBLAuthor";
            this.LBLAuthor.Size = new System.Drawing.Size(69, 18);
            this.LBLAuthor.TabIndex = 54;
            this.LBLAuthor.Text = "AUTHOR:";
            this.LBLAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookReserved)).EndInit();
            this.SecondaryPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            this.MainPanel.ResumeLayout(false);
            this.PrimaryPanel.ResumeLayout(false);
            this.PrimaryPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblborrow;
        private System.Windows.Forms.Label LBLBookID;
        private System.Windows.Forms.Label lbluser;
        private Guna.UI2.WinForms.Guna2TextBox txtBookID;
        private System.Windows.Forms.Label LBLUserID;
        private Guna.UI2.WinForms.Guna2TextBox txtUserID;
        private System.Windows.Forms.Label LBLTitle;
        private System.Windows.Forms.DataGridView dgvBookReserved;
        private System.Windows.Forms.Panel SecondaryPanel;
        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel PrimaryPanel;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblAuthorName;
        private System.Windows.Forms.Label lblBookTitle;
        private Guna.UI2.WinForms.Guna2Button btnClear;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbltitleBook;
        private Guna.UI2.WinForms.Guna2Button btnReserve;
        private Guna.UI2.WinForms.Guna2PictureBox pbPicture;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpReserve;
        private System.Windows.Forms.Label LBLAuthor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Book_TItle;
        private System.Windows.Forms.DataGridViewTextBoxColumn SBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Book_Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Book_Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn Book_Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Book_Copyright;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReservedDate;
    }
}
