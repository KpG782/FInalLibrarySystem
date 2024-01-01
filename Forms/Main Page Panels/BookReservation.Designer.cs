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
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgvBorrowedDetailsDat = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrowedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returnedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reservedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrowedDetailsDat)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Location = new System.Drawing.Point(26, 20);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(92, 33);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Book Reservation";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvBorrowedDetailsDat
            // 
            this.dgvBorrowedDetailsDat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBorrowedDetailsDat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.UserID,
            this.BookID,
            this.borrowedDate,
            this.returnedDate,
            this.reservedDate,
            this.note});
            this.dgvBorrowedDetailsDat.Location = new System.Drawing.Point(91, 153);
            this.dgvBorrowedDetailsDat.Name = "dgvBorrowedDetailsDat";
            this.dgvBorrowedDetailsDat.Size = new System.Drawing.Size(729, 304);
            this.dgvBorrowedDetailsDat.TabIndex = 3;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // UserID
            // 
            this.UserID.HeaderText = "UserID";
            this.UserID.Name = "UserID";
            // 
            // BookID
            // 
            this.BookID.HeaderText = "BookID";
            this.BookID.Name = "BookID";
            // 
            // borrowedDate
            // 
            this.borrowedDate.HeaderText = "borrowedDate";
            this.borrowedDate.Name = "borrowedDate";
            // 
            // returnedDate
            // 
            this.returnedDate.HeaderText = "returnedDate";
            this.returnedDate.Name = "returnedDate";
            // 
            // reservedDate
            // 
            this.reservedDate.HeaderText = "reservedDate";
            this.reservedDate.Name = "reservedDate";
            // 
            // note
            // 
            this.note.HeaderText = "note";
            this.note.Name = "note";
            // 
            // BookReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.Controls.Add(this.dgvBorrowedDetailsDat);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "BookReservation";
            this.Size = new System.Drawing.Size(936, 860);
            this.Load += new System.EventHandler(this.BookReservation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrowedDetailsDat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvBorrowedDetailsDat;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrowedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn returnedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn reservedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn note;
    }
}
