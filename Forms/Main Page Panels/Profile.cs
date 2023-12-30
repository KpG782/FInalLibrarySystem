using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FInalLibrarySystem.Database;

namespace FInalLibrarySystem
{
    public partial class Profile : UserControl
    {

        private Users usersManager; // Assuming you have an instance of the Users class


        public Profile()
        {
            InitializeComponent();
            usersManager = new Users(); // Instantiate the Users class

        }

        public int UserId { get; set; } = 1;// Public property for user ID



        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void lblTitleDepartment_Click(object sender, EventArgs e)
        {

        }

        private void Profile_Load(object sender, EventArgs e)
        {


        }


        // Helper method to convert byte array to Image
        private Image ByteArrayToImage(byte[] byteArray)
        {
            if (byteArray == null || byteArray.Length == 0)
                return null;

            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                return Image.FromStream(ms);
            }
        }


        private Users.User GetUserProfile(int userId)
        {
            // Retrieve user profile information from the Users class
            List<Users.User> users = usersManager.GetAllUsers();

            // Find the user with the specified ID
            Users.User userProfile = users.FirstOrDefault(user => user.Id == userId);

            return userProfile;
        }



        private void Profile_Load_1(object sender, EventArgs e)
        {
            if (UserId == 0)
            {

                // Display the UserId in a MessageBox
                MessageBox.Show($"User ID : {UserId} di gumana yung user id", "User ID Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Fetch user data for the specified user ID using the new method
            Users.User userProfile = usersManager.GetUserById(UserId);

            // Update labels with user profile information
            lblID.Text = userProfile.Id.ToString();
            lblEmail.Text = userProfile.Email;
            lblPassword.Text = userProfile.Password;
            lblFirstName.Text = userProfile.FirstName;
            lblLastName.Text = userProfile.LastName;
            lblMI.Text = userProfile.MiddleInitial;
            lblSection.Text = userProfile.Section;
            lblDepartment.Text = userProfile.Department;
            lblUsername.Text = userProfile.Username;
            lblRole.Text = userProfile.Role;
            lblStudentID.Text = userProfile.StudentID;
            lblYear.Text = userProfile.Year;
            lblSection.Text = userProfile.Section;
            lblEmployeeID.Text = userProfile.EmployeeID;

            // Display user's image in the PictureBox
            if (userProfile.Picture != null)
            {
                pbUserPic.Image = ByteArrayToImage(userProfile.Picture);
                MessageBox.Show("gumana naman yung pic");
            }
            else
            {
                // Set a default image or handle the case where there is no image
                MessageBox.Show("Di gumana yung pic"); // Assuming you have a default image in your resources
            }
            // You can add more labels or UI elements and update them with additional user information

        }

        private void lblDepartment_Click(object sender, EventArgs e)
        {
            // ...
        }
    }
}