namespace FInalLibrarySystem
{
    partial class Penalty
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Penalty));
            this.dasd = new System.Windows.Forms.LinkLabel();
            this.Paid = new System.Windows.Forms.LinkLabel();
            this.pedro = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // dasd
            // 
            this.dasd.ActiveLinkColor = System.Drawing.Color.Transparent;
            this.dasd.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dasd.Image = ((System.Drawing.Image)(resources.GetObject("dasd.Image")));
            this.dasd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dasd.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.dasd.LinkColor = System.Drawing.Color.Black;
            this.dasd.Location = new System.Drawing.Point(153, 19);
            this.dasd.Name = "dasd";
            this.dasd.Size = new System.Drawing.Size(169, 112);
            this.dasd.TabIndex = 32;
            this.dasd.TabStop = true;
            this.dasd.Text = "dasda";
            this.dasd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dasd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblAcadBooks_LinkClicked);
            // 
            // Paid
            // 
            this.Paid.ActiveLinkColor = System.Drawing.Color.Transparent;
            this.Paid.CausesValidation = false;
            this.Paid.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Paid.Image = ((System.Drawing.Image)(resources.GetObject("Paid.Image")));
            this.Paid.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Paid.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.Paid.LinkColor = System.Drawing.Color.Black;
            this.Paid.Location = new System.Drawing.Point(910, 19);
            this.Paid.Name = "Paid";
            this.Paid.Size = new System.Drawing.Size(205, 112);
            this.Paid.TabIndex = 31;
            this.Paid.TabStop = true;
            this.Paid.Text = "Paid";
            this.Paid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Paid.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblNFBooks_LinkClicked);
            // 
            // pedro
            // 
            this.pedro.ActiveLinkColor = System.Drawing.Color.Transparent;
            this.pedro.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pedro.Image = ((System.Drawing.Image)(resources.GetObject("pedro.Image")));
            this.pedro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pedro.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.pedro.LinkColor = System.Drawing.Color.Black;
            this.pedro.Location = new System.Drawing.Point(583, 19);
            this.pedro.Name = "pedro";
            this.pedro.Size = new System.Drawing.Size(148, 112);
            this.pedro.TabIndex = 30;
            this.pedro.TabStop = true;
            this.pedro.Text = "pedro";
            this.pedro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pedro.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblFBooks_LinkClicked);
            // 
            // Penalty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.Controls.Add(this.dasd);
            this.Controls.Add(this.Paid);
            this.Controls.Add(this.pedro);
            this.Name = "Penalty";
            this.Size = new System.Drawing.Size(1248, 1059);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.LinkLabel dasd;
        private System.Windows.Forms.LinkLabel Paid;
        private System.Windows.Forms.LinkLabel pedro;
    }
}
