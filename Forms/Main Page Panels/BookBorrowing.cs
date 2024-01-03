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

        // Inside BookBorrowing class
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            // Get user input from form controls
            int bookID = Convert.ToInt32(nudBookID.Value);
            int userID = Convert.ToInt32(nudMemberID.Value);
            DateTime borrowedDate = dateBorrow.Value;
            DateTime returnDate = dateReturn.Value;
            string note = lblNote.Text; // Assuming lblNote is a control where the user can input notes

            // Call the Books class method to borrow the book
            bool success = booksManager1.BorrowBook(bookID, userID, borrowedDate, returnDate, note);

            // Check if the operation was successful and provide feedback to the user
            if (success)
            {
                MessageBox.Show("Book borrowed successfully!");
                // Optionally, you can perform additional actions (clear fields, update UI, etc.)
            }
            else
            {
                MessageBox.Show("Error borrowing book. Please try again.");
            }
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

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void bookDetails1_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void BookBorrowing_Load(object sender, EventArgs e)
        {
            LoadAllBooks();
        }

        private void nudbookID_ValueChanged(object sender, EventArgs e)
        {

        }



        private void nudMemberID_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateBorrow_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateReturn_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblNote_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
