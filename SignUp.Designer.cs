namespace FInalLibrarySystem
{
    partial class frmSignUp
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
            this.rdbtnTeacher = new System.Windows.Forms.RadioButton();
            this.rdbtnStudent = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.cbYear = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblYearLvl = new System.Windows.Forms.Label();
            this.cbSection = new System.Windows.Forms.ComboBox();
            this.lblSection = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lblPassT = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.lblEAddT = new System.Windows.Forms.Label();
            this.lblCPassT = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.txtMIT = new System.Windows.Forms.TextBox();
            this.txtFNT = new System.Windows.Forms.TextBox();
            this.txtLNT = new System.Windows.Forms.TextBox();
            this.lblFNT = new System.Windows.Forms.Label();
            this.txtEmployee = new System.Windows.Forms.TextBox();
            this.cbDepartment = new System.Windows.Forms.ComboBox();
            this.lblEID = new System.Windows.Forms.Label();
            this.lblDept = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rdbtnTeacher
            // 
            this.rdbtnTeacher.AutoSize = true;
            this.rdbtnTeacher.Location = new System.Drawing.Point(215, 47);
            this.rdbtnTeacher.Name = "rdbtnTeacher";
            this.rdbtnTeacher.Size = new System.Drawing.Size(65, 17);
            this.rdbtnTeacher.TabIndex = 0;
            this.rdbtnTeacher.TabStop = true;
            this.rdbtnTeacher.Text = "Teacher";
            this.rdbtnTeacher.UseVisualStyleBackColor = true;
            this.rdbtnTeacher.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdbtnStudent
            // 
            this.rdbtnStudent.AutoSize = true;
            this.rdbtnStudent.Location = new System.Drawing.Point(339, 47);
            this.rdbtnStudent.Name = "rdbtnStudent";
            this.rdbtnStudent.Size = new System.Drawing.Size(62, 17);
            this.rdbtnStudent.TabIndex = 1;
            this.rdbtnStudent.TabStop = true;
            this.rdbtnStudent.Text = "Student";
            this.rdbtnStudent.UseVisualStyleBackColor = true;
            this.rdbtnStudent.CheckedChanged += new System.EventHandler(this.btnStudent_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(204, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Student ID";
            // 
            // cbYear
            // 
            this.cbYear.FormattingEnabled = true;
            this.cbYear.Location = new System.Drawing.Point(206, 155);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(51, 21);
            this.cbYear.TabIndex = 18;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(207, 202);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(121, 20);
            this.textBox3.TabIndex = 17;
            // 
            // lblYearLvl
            // 
            this.lblYearLvl.AutoSize = true;
            this.lblYearLvl.Location = new System.Drawing.Point(203, 139);
            this.lblYearLvl.Name = "lblYearLvl";
            this.lblYearLvl.Size = new System.Drawing.Size(58, 13);
            this.lblYearLvl.TabIndex = 12;
            this.lblYearLvl.Text = "Year Level";
            this.lblYearLvl.Click += new System.EventHandler(this.label5_Click);
            // 
            // cbSection
            // 
            this.cbSection.FormattingEnabled = true;
            this.cbSection.Location = new System.Drawing.Point(336, 155);
            this.cbSection.Name = "cbSection";
            this.cbSection.Size = new System.Drawing.Size(93, 21);
            this.cbSection.TabIndex = 21;
            this.cbSection.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // lblSection
            // 
            this.lblSection.AutoSize = true;
            this.lblSection.Location = new System.Drawing.Point(337, 139);
            this.lblSection.Name = "lblSection";
            this.lblSection.Size = new System.Drawing.Size(43, 13);
            this.lblSection.TabIndex = 20;
            this.lblSection.Text = "Section";
            this.lblSection.Click += new System.EventHandler(this.label6_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(174, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 34;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(255, 366);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 35;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(336, 366);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 36;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblPassT
            // 
            this.lblPassT.AutoSize = true;
            this.lblPassT.Location = new System.Drawing.Point(204, 282);
            this.lblPassT.Name = "lblPassT";
            this.lblPassT.Size = new System.Drawing.Size(53, 13);
            this.lblPassT.TabIndex = 25;
            this.lblPassT.Text = "Password";
            this.lblPassT.Click += new System.EventHandler(this.lblPassT_Click);
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(207, 297);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(121, 20);
            this.textBox9.TabIndex = 24;
            this.textBox9.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(207, 339);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(121, 20);
            this.textBox10.TabIndex = 26;
            this.textBox10.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
            // 
            // lblEAddT
            // 
            this.lblEAddT.AutoSize = true;
            this.lblEAddT.Location = new System.Drawing.Point(203, 236);
            this.lblEAddT.Name = "lblEAddT";
            this.lblEAddT.Size = new System.Drawing.Size(73, 13);
            this.lblEAddT.TabIndex = 23;
            this.lblEAddT.Text = "Email Address";
            this.lblEAddT.Click += new System.EventHandler(this.lblEAddT_Click);
            // 
            // lblCPassT
            // 
            this.lblCPassT.AutoSize = true;
            this.lblCPassT.Location = new System.Drawing.Point(204, 323);
            this.lblCPassT.Name = "lblCPassT";
            this.lblCPassT.Size = new System.Drawing.Size(91, 13);
            this.lblCPassT.TabIndex = 27;
            this.lblCPassT.Text = "Confirm Password";
            this.lblCPassT.Click += new System.EventHandler(this.lblCPassT_Click);
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(207, 256);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(121, 20);
            this.textBox8.TabIndex = 22;
            this.textBox8.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // txtMIT
            // 
            this.txtMIT.Location = new System.Drawing.Point(369, 105);
            this.txtMIT.Name = "txtMIT";
            this.txtMIT.Size = new System.Drawing.Size(18, 20);
            this.txtMIT.TabIndex = 6;
            this.txtMIT.TextChanged += new System.EventHandler(this.txtMIT_TextChanged);
            // 
            // txtFNT
            // 
            this.txtFNT.Location = new System.Drawing.Point(299, 105);
            this.txtFNT.Name = "txtFNT";
            this.txtFNT.Size = new System.Drawing.Size(64, 20);
            this.txtFNT.TabIndex = 5;
            this.txtFNT.TextChanged += new System.EventHandler(this.txtFNT_TextChanged);
            // 
            // txtLNT
            // 
            this.txtLNT.Location = new System.Drawing.Point(207, 105);
            this.txtLNT.Name = "txtLNT";
            this.txtLNT.Size = new System.Drawing.Size(86, 20);
            this.txtLNT.TabIndex = 3;
            this.txtLNT.TextChanged += new System.EventHandler(this.txtLNT_TextChanged);
            // 
            // lblFNT
            // 
            this.lblFNT.AutoSize = true;
            this.lblFNT.Location = new System.Drawing.Point(204, 89);
            this.lblFNT.Name = "lblFNT";
            this.lblFNT.Size = new System.Drawing.Size(54, 13);
            this.lblFNT.TabIndex = 4;
            this.lblFNT.Text = "Full Name";
            this.lblFNT.Click += new System.EventHandler(this.lblFNT_Click);
            // 
            // txtEmployee
            // 
            this.txtEmployee.Location = new System.Drawing.Point(336, 157);
            this.txtEmployee.Name = "txtEmployee";
            this.txtEmployee.Size = new System.Drawing.Size(121, 20);
            this.txtEmployee.TabIndex = 8;
            this.txtEmployee.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // cbDepartment
            // 
            this.cbDepartment.FormattingEnabled = true;
            this.cbDepartment.Location = new System.Drawing.Point(206, 155);
            this.cbDepartment.Name = "cbDepartment";
            this.cbDepartment.Size = new System.Drawing.Size(126, 21);
            this.cbDepartment.TabIndex = 9;
            this.cbDepartment.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblEID
            // 
            this.lblEID.AutoSize = true;
            this.lblEID.Location = new System.Drawing.Point(337, 139);
            this.lblEID.Name = "lblEID";
            this.lblEID.Size = new System.Drawing.Size(67, 13);
            this.lblEID.TabIndex = 10;
            this.lblEID.Text = "Employee ID";
            this.lblEID.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // lblDept
            // 
            this.lblDept.AutoSize = true;
            this.lblDept.Location = new System.Drawing.Point(204, 139);
            this.lblDept.Name = "lblDept";
            this.lblDept.Size = new System.Drawing.Size(62, 13);
            this.lblDept.TabIndex = 2;
            this.lblDept.Text = "Department";
            this.lblDept.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // frmSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 428);
            this.Controls.Add(this.lblDept);
            this.Controls.Add(this.lblEID);
            this.Controls.Add(this.cbDepartment);
            this.Controls.Add(this.lblFNT);
            this.Controls.Add(this.txtEmployee);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtLNT);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtFNT);
            this.Controls.Add(this.txtMIT);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.lblCPassT);
            this.Controls.Add(this.lblEAddT);
            this.Controls.Add(this.cbSection);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.lblSection);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPassT);
            this.Controls.Add(this.cbYear);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.lblYearLvl);
            this.Controls.Add(this.rdbtnStudent);
            this.Controls.Add(this.rdbtnTeacher);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmSignUp";
            this.Text = "Sign Up";
            this.Load += new System.EventHandler(this.frmPrompt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbtnTeacher;
        private System.Windows.Forms.RadioButton rdbtnStudent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbYear;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblYearLvl;
        private System.Windows.Forms.ComboBox cbSection;
        private System.Windows.Forms.Label lblSection;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblPassT;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label lblEAddT;
        private System.Windows.Forms.Label lblCPassT;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox txtMIT;
        private System.Windows.Forms.TextBox txtFNT;
        private System.Windows.Forms.TextBox txtLNT;
        private System.Windows.Forms.Label lblFNT;
        private System.Windows.Forms.TextBox txtEmployee;
        private System.Windows.Forms.ComboBox cbDepartment;
        private System.Windows.Forms.Label lblEID;
        private System.Windows.Forms.Label lblDept;
    }
}