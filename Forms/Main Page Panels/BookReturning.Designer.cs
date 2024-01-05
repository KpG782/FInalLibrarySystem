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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.SecondaryPanel = new System.Windows.Forms.Panel();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrimaryPanel = new System.Windows.Forms.Panel();
            this.ConditionComboBox = new System.Windows.Forms.ComboBox();
            this.ConditionLabel = new System.Windows.Forms.Label();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.DateLabel = new System.Windows.Forms.Label();
            this.AuthorLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.SearchByComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BookPictureBox = new System.Windows.Forms.PictureBox();
            this.ClearButton = new System.Windows.Forms.Button();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.ReturnButton = new System.Windows.Forms.Button();
            this.AuthorTextBox = new System.Windows.Forms.TextBox();
            this.pnlReceiptForm = new FInalLibrarySystem.Forms.Main_Page_Panels.ReceiptForm();
            this.lblTitle = new System.Windows.Forms.Label();
            this.MainPanel.SuspendLayout();
            this.SecondaryPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.PrimaryPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BookPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.pnlReceiptForm);
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
            this.SecondaryPanel.Controls.Add(this.DataGridView);
            this.SecondaryPanel.Location = new System.Drawing.Point(404, 2);
            this.SecondaryPanel.Margin = new System.Windows.Forms.Padding(2);
            this.SecondaryPanel.Name = "SecondaryPanel";
            this.SecondaryPanel.Size = new System.Drawing.Size(508, 687);
            this.SecondaryPanel.TabIndex = 1;
            // 
            // DataGridView
            // 
            this.DataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column11,
            this.Column10});
            this.DataGridView.Location = new System.Drawing.Point(3, 2);
            this.DataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.RowHeadersWidth = 51;
            this.DataGridView.RowTemplate.Height = 24;
            this.DataGridView.Size = new System.Drawing.Size(501, 676);
            this.DataGridView.TabIndex = 0;
            this.DataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Issue_ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 30;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Student_ID";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 40;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Student_Name";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Student_Course";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Student_Email";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Book_ID";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Book_Title";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 125;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Book_Author";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Width = 125;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Book_IssueDate";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.Width = 125;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Book_DueDate";
            this.Column11.MinimumWidth = 6;
            this.Column11.Name = "Column11";
            this.Column11.Width = 125;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Book_Status";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.Width = 125;
            // 
            // PrimaryPanel
            // 
            this.PrimaryPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PrimaryPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PrimaryPanel.Controls.Add(this.lblTitle);
            this.PrimaryPanel.Controls.Add(this.ConditionComboBox);
            this.PrimaryPanel.Controls.Add(this.ConditionLabel);
            this.PrimaryPanel.Controls.Add(this.UpdateButton);
            this.PrimaryPanel.Controls.Add(this.dateTimePicker1);
            this.PrimaryPanel.Controls.Add(this.DateLabel);
            this.PrimaryPanel.Controls.Add(this.AuthorLabel);
            this.PrimaryPanel.Controls.Add(this.TitleLabel);
            this.PrimaryPanel.Controls.Add(this.SearchTextBox);
            this.PrimaryPanel.Controls.Add(this.SearchByComboBox);
            this.PrimaryPanel.Controls.Add(this.label1);
            this.PrimaryPanel.Controls.Add(this.BookPictureBox);
            this.PrimaryPanel.Controls.Add(this.ClearButton);
            this.PrimaryPanel.Controls.Add(this.TitleTextBox);
            this.PrimaryPanel.Controls.Add(this.ReturnButton);
            this.PrimaryPanel.Controls.Add(this.AuthorTextBox);
            this.PrimaryPanel.Location = new System.Drawing.Point(2, 2);
            this.PrimaryPanel.Margin = new System.Windows.Forms.Padding(2);
            this.PrimaryPanel.Name = "PrimaryPanel";
            this.PrimaryPanel.Size = new System.Drawing.Size(398, 679);
            this.PrimaryPanel.TabIndex = 2;
            // 
            // ConditionComboBox
            // 
            this.ConditionComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ConditionComboBox.FormattingEnabled = true;
            this.ConditionComboBox.Items.AddRange(new object[] {
            "Excellent Condition",
            "Lost/Misisng",
            "Damaged/Worn"});
            this.ConditionComboBox.Location = new System.Drawing.Point(115, 516);
            this.ConditionComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.ConditionComboBox.Name = "ConditionComboBox";
            this.ConditionComboBox.Size = new System.Drawing.Size(110, 21);
            this.ConditionComboBox.TabIndex = 16;
            // 
            // ConditionLabel
            // 
            this.ConditionLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ConditionLabel.Location = new System.Drawing.Point(43, 516);
            this.ConditionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ConditionLabel.Name = "ConditionLabel";
            this.ConditionLabel.Size = new System.Drawing.Size(68, 18);
            this.ConditionLabel.TabIndex = 15;
            this.ConditionLabel.Text = "CONDITION:";
            this.ConditionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UpdateButton
            // 
            this.UpdateButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UpdateButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.UpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateButton.Location = new System.Drawing.Point(152, 593);
            this.UpdateButton.Margin = new System.Windows.Forms.Padding(2);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(79, 32);
            this.UpdateButton.TabIndex = 14;
            this.UpdateButton.Text = "UPDATE";
            this.UpdateButton.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker1.Location = new System.Drawing.Point(129, 546);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(151, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // DateLabel
            // 
            this.DateLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DateLabel.Location = new System.Drawing.Point(43, 546);
            this.DateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(81, 18);
            this.DateLabel.TabIndex = 13;
            this.DateLabel.Text = "RETURN DATE:";
            this.DateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AuthorLabel
            // 
            this.AuthorLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AuthorLabel.Location = new System.Drawing.Point(43, 486);
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
            this.TitleLabel.Location = new System.Drawing.Point(43, 457);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(40, 18);
            this.TitleLabel.TabIndex = 11;
            this.TitleLabel.Text = "TITLE:";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SearchTextBox.Location = new System.Drawing.Point(117, 418);
            this.SearchTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(221, 20);
            this.SearchTextBox.TabIndex = 1;
            // 
            // SearchByComboBox
            // 
            this.SearchByComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SearchByComboBox.FormattingEnabled = true;
            this.SearchByComboBox.Items.AddRange(new object[] {
            "Issue_ID",
            "Book_ID"});
            this.SearchByComboBox.Location = new System.Drawing.Point(43, 418);
            this.SearchByComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.SearchByComboBox.Name = "SearchByComboBox";
            this.SearchByComboBox.Size = new System.Drawing.Size(68, 21);
            this.SearchByComboBox.TabIndex = 0;
            this.SearchByComboBox.Text = "Search By:";
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
            // ClearButton
            // 
            this.ClearButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ClearButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearButton.Location = new System.Drawing.Point(259, 593);
            this.ClearButton.Margin = new System.Windows.Forms.Padding(2);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(79, 32);
            this.ClearButton.TabIndex = 4;
            this.ClearButton.Text = "CLEAR";
            this.ClearButton.UseVisualStyleBackColor = true;
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TitleTextBox.Location = new System.Drawing.Point(101, 457);
            this.TitleTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(237, 20);
            this.TitleTextBox.TabIndex = 0;
            // 
            // ReturnButton
            // 
            this.ReturnButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ReturnButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ReturnButton.BackColor = System.Drawing.Color.White;
            this.ReturnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReturnButton.Location = new System.Drawing.Point(45, 593);
            this.ReturnButton.Margin = new System.Windows.Forms.Padding(2);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(79, 32);
            this.ReturnButton.TabIndex = 3;
            this.ReturnButton.Text = "RETURN";
            this.ReturnButton.UseVisualStyleBackColor = false;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click_1);
            // 
            // AuthorTextBox
            // 
            this.AuthorTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AuthorTextBox.Location = new System.Drawing.Point(101, 486);
            this.AuthorTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.AuthorTextBox.Name = "AuthorTextBox";
            this.AuthorTextBox.Size = new System.Drawing.Size(237, 20);
            this.AuthorTextBox.TabIndex = 1;
            // 
            // pnlReceiptForm
            // 
            this.pnlReceiptForm.Location = new System.Drawing.Point(288, 92);
            this.pnlReceiptForm.Name = "pnlReceiptForm";
            this.pnlReceiptForm.Size = new System.Drawing.Size(295, 499);
            this.pnlReceiptForm.TabIndex = 3;
            this.pnlReceiptForm.Load += new System.EventHandler(this.pnlReceiptForm_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.PrimaryPanel.ResumeLayout(false);
            this.PrimaryPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BookPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel SecondaryPanel;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.Panel PrimaryPanel;
        private System.Windows.Forms.ComboBox ConditionComboBox;
        private System.Windows.Forms.Label ConditionLabel;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label AuthorLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.ComboBox SearchByComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox BookPictureBox;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.Button ReturnButton;
        private System.Windows.Forms.TextBox AuthorTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private Forms.Main_Page_Panels.ReceiptForm pnlReceiptForm;
        private System.Windows.Forms.Label lblTitle;
    }
}
