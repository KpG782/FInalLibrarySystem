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
        //set global object
        MainPage mainPage = new MainPage();
        


        // Define a simple class to represent a user
        public class User
        {
            public string Username { get; set; }
            public string Password { get; set; }

            public string Email { get; set; }

            public string FirstName { get; set; }
            public string LastName { get; set; }

            public string MiddleInitial { get; set; }
            public string Role { get; set; }
            public string Department { get; set; }

            public string StudentID { get; set; }

            public string EmployeeID { get; set; }

            public string Section { get; set; }
            public string Year { get; set; }
        }

        // Array to store user information
        public User[] users = new User[20];

        //draggable window
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool ReleaseCapture();



        public frmLogin()
        {
            InitializeComponent();
            InitializeUsers();

        }

        private void InitializeUsers()
        {
            // Initialize the array with sample username and password pairs
            users[0] = new User { Username = "stud1", Password = "pass1", FirstName = "Ken Patrick", LastName = "Garcia", MiddleInitial = "A", Role = "Student", StudentID = "A62240916", Section = "ACSAD", Year = "2"};
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
            //to hide automatically the password
            txtPass.UseSystemPasswordChar = true;

            // rounded corner
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            int radius = 20; // adjust the value to change the roundness of corners

            // create a rounded rectangle path using the form's size and radius
            path.AddArc(0, 0, radius * 2, radius * 2, 180, 90); // top left corner
            path.AddArc(this.Width - radius * 2, 0, radius * 2, radius * 2, 270, 90); // top-right corner
            path.AddArc(this.Width - radius * 2, this.Height - radius * 2, radius * 2, radius * 2, 0, 90); // bottom right corner
            path.AddArc(0, this.Height - radius * 2, radius * 2, radius * 2, 90, 90); // bottom-left corner

            // create a region with the rounded rectangle path and apply it to the form
            this.Region = new Region(path);



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
            //DATABASEEE!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            //creation of connection of database
            Database.MyDB db = new Database.MyDB();

            








            //old non-database way`````````````````````````````````````````
            // Retrieve entered username and password
            string enteredUsername = txtEmail.Text;
            string enteredPassword = txtPass.Text;

            // Check if the entered credentials match any user in the array
            foreach (var user in users)
            {
                if (user.Username == enteredUsername && user.Password == enteredPassword)
                {
                    MessageBox.Show("Login successful! Welcome " + user.FirstName + "!!");

                    //opens main page form
                    
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

        private void label1_Click_3(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click_4(object sender, EventArgs e)
        {

        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                //check if the click was on the title bar
                if (e.Clicks == 1 && e.Y <= this.Height && e.Y >= 0)
                {
                    ReleaseCapture();
                    SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                }
            }
        }
    }
}
