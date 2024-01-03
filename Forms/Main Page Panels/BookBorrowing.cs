using FInalLibrarySystem.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FInalLibrarySystem
{
    public partial class BookBorrowing : UserControl
    {


        private Books booksManager1;


        public BookBorrowing()
        {
            InitializeComponent();
            booksManager1 = new Books();

        }



        private void LoadAllBooks()
        {


            List<Book> fictionalBooks = booksManager1.GetAllBooks();

            foreach (var book in fictionalBooks)
            {

                // Create an image from the byte[] cover data
                Image coverImage = ByteArrayToImage(book.Cover);

                // Check if the current book is "To KIll a Mockingbird"



            }
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





        private void BookBorrowing_Load(object sender, EventArgs e)
        {
            LoadAllBooks();


        }

        private void PrimaryPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtBookID_TextChanged(object sender, EventArgs e)
        {
            // Ensure the user has entered a valid book ID
            if (int.TryParse(txtBookID.Text, out int bookID))
            {
                // Retrieve book details from the database
                Book book = booksManager1.GetBookDetailsById(bookID);

                // Update labels with book details
                if (book != null)
                {
                    lblBookTitle.Text = book.Title;
                    lblAuthorName.Text = book.Author;
                }
                else
                {
                    // Clear labels if the book is not found
                    lblBookTitle.Text = "";
                    lblAuthorName.Text = "";
                }
            }
            else
            {
                // Clear labels if the input is not a valid integer
                lblBookTitle.Text = "";
                lblAuthorName.Text = "";
            }
        }

        private void lblBookTitle_Click(object sender, EventArgs e)
        {

        }

        private void lblAuthorName_Click(object sender, EventArgs e)
        {

        }

        private void txtUserID_TextChanged(object sender, EventArgs e)
        {
            
           
            /// Ensure the user has entered a valid user ID
            if (int.TryParse(txtUserID.Text, out int userID))
            {
                // Retrieve user details from the database
                User user = booksManager1.GetUserDetailsById(userID);

                // Update label with user details
                if (user != null)
                {
                    lblUserName.Text = $"Username: {user.Username} ({user.UserType})";
                }
                else
                {
                    // Clear label if the user is not found
                    lblUserName.Text = "User not found";
                }
            }
            else
            {
                // Clear label if the input is not a valid integer
                lblUserName.Text = "";
            }
        }

        private void lblUserName_Click(object sender, EventArgs e)
        {

        }

        private void dtpBorrow_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {

        }


    }
}
