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
            this.lblUserName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.UserID = new System.Windows.Forms.Label();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.lblBookTitle = new System.Windows.Forms.Label();
            this.lblAuthorName = new System.Windows.Forms.Label();
            this.lbltitleBook = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.SecondaryPanel = new System.Windows.Forms.Panel();
            this.dgvShow = new System.Windows.Forms.DataGridView();
            this.PrimaryPanel = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpBorrow = new System.Windows.Forms.DateTimePicker();
            this.lblBorrow = new System.Windows.Forms.Label();
            this.AuthorLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.txtBookID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbPicture = new System.Windows.Forms.PictureBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBorrow = new System.Windows.Forms.Button();
            this.Book_Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Book_Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Copyright = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MainPanel.SuspendLayout();
            this.SecondaryPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).BeginInit();
            this.PrimaryPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).BeginInit();
            this.SuspendLayout();
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
            this.lbltitleBook.Size = new System.Drawing.Size(78, 15);
            this.lbltitleBook.TabIndex = 17;
            this.lbltitleBook.Text = "Book Borrowing";
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
            this.MainPanel.TabIndex = 2;
            // 
            // SecondaryPanel
            // 
            this.SecondaryPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SecondaryPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SecondaryPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SecondaryPanel.Controls.Add(this.dgvShow);
            this.SecondaryPanel.Location = new System.Drawing.Point(404, 2);
            this.SecondaryPanel.Margin = new System.Windows.Forms.Padding(2);
            this.SecondaryPanel.Name = "SecondaryPanel";
            this.SecondaryPanel.Size = new System.Drawing.Size(526, 860);
            this.SecondaryPanel.TabIndex = 1;
            // 
            // dgvShow
            // 
            this.dgvShow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvShow.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Book_Title,
            this.ISBN,
            this.Category,
            this.Book_Author,
            this.Column10,
            this.Copyright});
            this.dgvShow.Location = new System.Drawing.Point(3, 2);
            this.dgvShow.Margin = new System.Windows.Forms.Padding(2);
            this.dgvShow.Name = "dgvShow";
            this.dgvShow.RowHeadersWidth = 51;
            this.dgvShow.RowTemplate.Height = 24;
            this.dgvShow.Size = new System.Drawing.Size(519, 849);
            this.dgvShow.TabIndex = 0;
            this.dgvShow.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShow_CellContentClick);
            // 
            // PrimaryPanel
            // 
            this.PrimaryPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PrimaryPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PrimaryPanel.Controls.Add(this.btnUpdate);
            this.PrimaryPanel.Controls.Add(this.lblUserName);
            this.PrimaryPanel.Controls.Add(this.label4);
            this.PrimaryPanel.Controls.Add(this.UserID);
            this.PrimaryPanel.Controls.Add(this.txtUserID);
            this.PrimaryPanel.Controls.Add(this.lblBookTitle);
            this.PrimaryPanel.Controls.Add(this.lblAuthorName);
            this.PrimaryPanel.Controls.Add(this.label2);
            this.PrimaryPanel.Controls.Add(this.lbltitleBook);
            this.PrimaryPanel.Controls.Add(this.dtpBorrow);
            this.PrimaryPanel.Controls.Add(this.lblBorrow);
            this.PrimaryPanel.Controls.Add(this.AuthorLabel);
            this.PrimaryPanel.Controls.Add(this.TitleLabel);
            this.PrimaryPanel.Controls.Add(this.txtBookID);
            this.PrimaryPanel.Controls.Add(this.label1);
            this.PrimaryPanel.Controls.Add(this.pbPicture);
            this.PrimaryPanel.Controls.Add(this.btnClear);
            this.PrimaryPanel.Controls.Add(this.btnBorrow);
            this.PrimaryPanel.Location = new System.Drawing.Point(2, 2);
            this.PrimaryPanel.Margin = new System.Windows.Forms.Padding(2);
            this.PrimaryPanel.Name = "PrimaryPanel";
            this.PrimaryPanel.Size = new System.Drawing.Size(416, 852);
            this.PrimaryPanel.TabIndex = 2;
            this.PrimaryPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.PrimaryPanel_Paint);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUpdate.BackColor = System.Drawing.Color.White;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Location = new System.Drawing.Point(156, 680);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(79, 32);
            this.btnUpdate.TabIndex = 25;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
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
            // dtpBorrow
            // 
            this.dtpBorrow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpBorrow.Location = new System.Drawing.Point(138, 633);
            this.dtpBorrow.Margin = new System.Windows.Forms.Padding(2);
            this.dtpBorrow.Name = "dtpBorrow";
            this.dtpBorrow.Size = new System.Drawing.Size(151, 20);
            this.dtpBorrow.TabIndex = 0;
            this.dtpBorrow.ValueChanged += new System.EventHandler(this.dtpBorrow_ValueChanged);
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
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Location = new System.Drawing.Point(251, 680);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(79, 32);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnBorrow
            // 
            this.btnBorrow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBorrow.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBorrow.BackColor = System.Drawing.Color.White;
            this.btnBorrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrow.Location = new System.Drawing.Point(54, 680);
            this.btnBorrow.Margin = new System.Windows.Forms.Padding(2);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(79, 32);
            this.btnBorrow.TabIndex = 3;
            this.btnBorrow.Text = "BORROW";
            this.btnBorrow.UseVisualStyleBackColor = false;
            this.btnBorrow.Click += new System.EventHandler(this.btnBorrow_Click);
            // 
            // Book_Title
            // 
            this.Book_Title.HeaderText = "Book_Title";
            this.Book_Title.MinimumWidth = 6;
            this.Book_Title.Name = "Book_Title";
            this.Book_Title.Width = 125;
            // 
            // ISBN
            // 
            this.ISBN.HeaderText = "ISBN";
            this.ISBN.Name = "ISBN";
            // 
            // Category
            // 
            this.Category.HeaderText = "Category";
            this.Category.Name = "Category";
            // 
            // Book_Author
            // 
            this.Book_Author.HeaderText = "Book_Author";
            this.Book_Author.MinimumWidth = 6;
            this.Book_Author.Name = "Book_Author";
            this.Book_Author.Width = 125;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Book_Status";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.Width = 125;
            // 
            // Copyright
            // 
            this.Copyright.HeaderText = "Copyright";
            this.Copyright.Name = "Copyright";
            // 
            // BookBorrowing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.MainPanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BookBorrowing";
            this.Size = new System.Drawing.Size(936, 860);
            this.Load += new System.EventHandler(this.BookBorrowing_Load);
            this.MainPanel.ResumeLayout(false);
            this.SecondaryPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).EndInit();
            this.PrimaryPanel.ResumeLayout(false);
            this.PrimaryPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label UserID;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.Label lblBookTitle;
        private System.Windows.Forms.Label lblAuthorName;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbltitleBook;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel SecondaryPanel;
        private System.Windows.Forms.DataGridView dgvShow;
        private System.Windows.Forms.Panel PrimaryPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblBorrow;
        private System.Windows.Forms.Label AuthorLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.TextBox txtBookID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbPicture;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnBorrow;
        private System.Windows.Forms.DateTimePicker dtpBorrow;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Book_Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Book_Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Copyright;
    }
}
