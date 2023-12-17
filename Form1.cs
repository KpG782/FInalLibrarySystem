using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FInalLibrarySystem
{
    public partial class frmLogin : Form
    {
        //set global
        MainPage mainPage = new MainPage();


        // Define a simple class to represent a user
        public class User
        {
            public string Username { get; set; }
            public string Password { get; set; }

            public string Email { get; set; }

            public string FirstName { get; set; }
            public string LastName { get; set; }

            public string Role { get; set; }
            public string Department { get; set; }
        }

        // Array to store user information
        private User[] users = new User[20];


        public frmLogin()
        {
            InitializeComponent();
            InitializeUsers();

        }

        private void InitializeUsers()
        {
            // Initialize the array with sample username and password pairs
            users[0] = new User { Username = "stud1", Password = "pass1", FirstName = "Ken Patrick", LastName = "Garcia" };
            users[1] = new User { Username = "stud2", Password = "pass2" };
            users[2] = new User { Username = "stud3", Password = "pass3" };
            users[3] = new User { Username = "stud4", Password = "pass4" };
            users[4] = new User { Username = "stud5", Password = "pass5" };
            users[5] = new User { Username = "stud6", Password = "pass6" };
            users[6] = new User { Username = "stud7", Password = "pass7" };
            users[7] = new User { Username = "stud8", Password = "pass8" };
            users[8] = new User { Username = "stud9", Password = "pass9" };
            users[9] = new User { Username = "stud10", Password = "pass10" };
            users[10] = new User { Username = "teach1", Password = "pass11" };
            users[11] = new User { Username = "teach2", Password = "pass12" };
            users[12] = new User { Username = "teach3", Password = "pass13" };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //to hide automatically
            txtPass.UseSystemPasswordChar = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Retrieve entered username and password
            string enteredUsername = txtEmail.Text;
            string enteredPassword = txtPass.Text;

            // Check if the entered credentials match any user in the array
            foreach (var user in users)
            {
                if (user.Username == enteredUsername && user.Password == enteredPassword)
                {
                    MessageBox.Show("Login successful! Mr. " + user.FirstName);

                    //opens book list form
                    
                    Form3 f3 = new Form3();

                    mainPage.Show();
                    return;
                }
            }

            // If no match is found, display an error message
            MessageBox.Show("Invalid username or password. Please try again.");


        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            frmSignUp f2 = new frmSignUp();
            f2.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtEmail.Text = "";
            txtPass.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (chkShow.Checked == true)
            {
                txtPass.UseSystemPasswordChar = false;
            }
            else
            {
                txtPass.UseSystemPasswordChar = true;
            }
        }
    }
}
