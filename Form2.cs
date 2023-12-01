using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FInalLibrarySystem
{
    public partial class frmSignUp : Form
    {
        public frmSignUp()
        {
            InitializeComponent();
        }

        private void frmPrompt_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnStudent_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            // Check if the "Teacher" radio button is checked
            if (rdbtnTeacher.Checked)
            {
                // If checked, set the visibility of the group box and its components to true
                grpTeacher.Visible = true;
                // Add more components as needed

                // You may also want to reset the visibility of other group boxes if needed
                // For example, if you have a group box for students, you can hide it when the "Teacher" is selected
                // groupBoxStudent.Visible = false;
            }
            else
            {
                // If unchecked, set the visibility of the group box and its components to false
                grpTeacher.Visible = false;
                // Hide other components as needed
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLNT_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblFNT_Click(object sender, EventArgs e)
        {

        }

        private void txtFNT_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMIT_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblEAddT_Click(object sender, EventArgs e)
        {

        }

        private void lblPassT_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCPassT_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnStudent_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
