namespace FInalLibrarySystem.Forms
{
    partial class bookDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bookDetails));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bk1lbl7 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(56, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 204);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // bk1lbl7
            // 
            this.bk1lbl7.Location = new System.Drawing.Point(64, 295);
            this.bk1lbl7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bk1lbl7.Name = "bk1lbl7";
            this.bk1lbl7.Size = new System.Drawing.Size(129, 95);
            this.bk1lbl7.TabIndex = 18;
            this.bk1lbl7.Text = "book description ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(256, 70);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(137, 204);
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(415, 16);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(45, 23);
            this.close.TabIndex = 20;
            this.close.Text = "X";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // bookDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.close);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.bk1lbl7);
            this.Controls.Add(this.pictureBox1);
            this.Name = "bookDetails";
            this.Size = new System.Drawing.Size(481, 355);
            this.Load += new System.EventHandler(this.bookDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label bk1lbl7;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button close;
    }
}
