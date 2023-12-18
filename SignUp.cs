using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static FInalLibrarySystem.frmLogin;

namespace FInalLibrarySystem
{
    public partial class frmSignUp : Form
    {
        //global login  
        frmLogin login1 = new frmLogin();
         


        public frmSignUp()
        {
            InitializeComponent();
            
        }

        private void frmPrompt_Load(object sender, EventArgs e)
        {
           lblSection.Visible = false;
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
                lblDept.Visible = true;
                cbDepartment.Visible = true;
                lblEID.Visible = true;
                txtEmployee.Visible = true;
                // Add more components as needed

                // You may also want to reset the visibility of other group boxes if needed
                // For example, if you have a group box for students, you can hide it when the "Teacher" is selected
                // groupBoxStudent.Visible = false;
            }
            else
            {

                // If unchecked, set the visibility of the group box and its components to false
                lblDept.Visible = false;
                cbDepartment.Visible = false;
                lblEID.Visible = false;
                txtEmployee.Visible = false;
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
            // Check if the "Teacher" radio button is checked
            if (rdbtnStudent.Checked)
            {
                // If checked, set the visibility of the group box and its components to true
                lblYearLvl.Visible = true;
                cbYear.Visible = true;
                lblSection.Visible = true;
                cbSection.Visible = true;
                // Add more components as needed

                // You may also want to reset the visibility of other group boxes if needed
                // For example, if you have a group box for students, you can hide it when the "Teacher" is selected
                // groupBoxStudent.Visible = false;
            }
            else
            {
                // If unchecked, set the visibility of the group box and its components to false
                lblYearLvl.Visible = false;
                cbYear.Visible = false;
                lblSection.Visible = false;
                cbSection.Visible = false;
                // Hide other components as needed
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            string enteredLastName = txtLNT.Text;
            string enteredFirstName = txtFNT.Text;
            string enteredMI = txtMIT.Text;
            string enteredDepartment = cbDepartment.Text;
            string enteredYear = cbSection.Text;
            string enteredSection = cbSection.Text;
            string enteredEmployeeID = txtEmployee.Text;
            string enteredStudentID = txtStudID.Text;
            string enteredEmailAdd = txtEmailAdd.Text;
            string enteredPassword = txtPassword.Text;
            string enteredCPassword = txtCPassword.Text;
            string enteredUsername = txtUsername.Text;

            //password checker
            if (enteredPassword == enteredCPassword)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("The Entered Password Does not Match!");
            }

            //checks if username already taken

            // Create a new User object
            User newUser = new User
            {
                Username = enteredUsername,
                Password = enteredPassword,
                Email = enteredEmailAdd,
                FirstName = enteredFirstName,
                LastName = enteredLastName,
                MiddleInitial = enteredMI,
                Department = enteredDepartment,
                Year = enteredYear,
                Section = enteredSection,
                EmployeeID = enteredEmployeeID,
                StudentID = enteredStudentID,


                // Set other details
            };




            // Add the new user to the existing array
            AddUser(newUser);
        }

        //adds new user
        public void AddUser(User newUser)
        {
            // Find the first empty slot in the array or resize the array if needed
            for (int i = 0; i < login1.users.Length; i++)
            {
                if (login1.users[i] == null)
                {
                    login1.users[i] = newUser;
                    return;
                }
            }

            // If no empty slot is found, resize the array and add the new user
            Array.Resize(ref login1.users, login1.users.Length + 1);
            login1.users[login1.users.Length - 1] = newUser;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
