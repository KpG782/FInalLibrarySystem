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
using MySql.Data; // don't forget this
using MySql.Data.MySqlClient; //don't forget this

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

            string username = txtEmail.Text;
            string password = txtPass.Text;

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `app_users` WHERE `username` = @usn AND `password` = @pass", db.getConnection());


            command.Parameters.Add("@usn",MySqlDbType.VarChar).Value = username;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            //check if this user exists or not 
            if(table.Rows.Count > 0) //if exists
            {
                mainPage.Show();
                mainPage.Enabled = true;
                
            }
            else //if not
            {
                //check if username is empty
                if (username.Trim().Equals(""))
                {
                    MessageBox.Show("Enter Your Username To Login" , "Empty Username", MessageBoxButtons.OK,MessageBoxIcon.Error );
                }

                //check if password is empty
                else if (password.Trim().Equals(""))
                {
                    MessageBox.Show("Enter Your Password To Login", "Empty Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //check if data is exists
                else 
                {
                    MessageBox.Show("Wrong Username or Password", "Wrong Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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
