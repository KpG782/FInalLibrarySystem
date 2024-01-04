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
using static FInalLibrarySystem.BookList;
using BookListBook = FInalLibrarySystem.BookList.Book;
using DatabaseBook = FInalLibrarySystem.Database.Book;

namespace FInalLibrarySystem
{
    public partial class BookBorrowing : UserControl
    {


        private Books booksManager1;
        private Users usersManager;
        private BookBorrows bookBorrowsManager;  // Instantiate BookBorrows



        public BookBorrowing()
        {
            InitializeComponent();
            booksManager1 = new Books();
            usersManager = new Users(); // Initialize the Users class
            bookBorrowsManager = new BookBorrows(new MyDB());  // Pass the appropriate database instance

        }



        private void LoadAllBooks()
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





        private void BookBorrowing_Load(object sender, EventArgs e)
        {
            LoadAllBooks();
            DisplayReturnedBooks();


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
                FInalLibrarySystem.Database.Book book = booksManager1.GetBookDetailsById(bookID);

                // Update labels with book details
                if (book != null)
                {
                    lblBookTitle.Text = book.Title;
                    lblAuthorName.Text = book.Author;
                    pbPicture.Image = ByteArrayToImage(book.Cover);
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
            if (int.TryParse(txtUserID.Text, out int userId))
            {
                // Retrieve user details from the database
                Users.User user = usersManager.GetUserById(userId);

                // Update labels with user details
                if (user != null)
                {
                    lblUserName.Text = $"{user.FirstName} {user.LastName}";
                }
                else
                {
                    // Clear labels if the user is not found
                    lblUserName.Text = "";
                }
            }
            else
            {
                // Clear labels if the input is not a valid integer
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
            // Retrieve necessary data from UI elements
            if (int.TryParse(txtBookID.Text, out int bookID) && int.TryParse(txtUserID.Text, out int userID))
            {
                string username = lblUserName.Text;  // Assuming lblUserName is updated correctly
                string bookTitle = lblBookTitle.Text;  // Assuming lblBookTitle is updated correctly
                string bookAuthor = lblAuthorName.Text;  // Assuming lblAuthorName is updated correctly
                DateTime borrowedDate = dtpBorrow.Value;
                DateTime returnedDate = DateTime.MinValue;  // You might need to update this based on your logic
                DateTime reservedDate = DateTime.MinValue;  // You might need to update this based on your logic

                // Retrieve the book details from the database
                FInalLibrarySystem.Database.Book book = booksManager1.GetBookDetailsById(bookID);

                //

                // Use the original book.Cover byte array
                byte[] picture = book.Cover;

                // Call the BorrowBook function in BookBorrows
                bool success = bookBorrowsManager.BorrowBook(bookID, userID, username, bookTitle, bookAuthor, borrowedDate, returnedDate, reservedDate, picture);
                // Handle the result
                if (success)
                {
                    this.Refresh();
                    MessageBox.Show("Book borrowed successfully!");
                    bool updateSuccess = booksManager1.UpdateBookStatus(bookID, "Borrowed");
                    // Optionally, you can perform additional actions after a successful borrow.
                }
                else
                {
                    MessageBox.Show("Failed to borrow the book. Please try again.");
                    // Optionally, you can handle the failure scenario.
                }

              
            }
            else
            {
                MessageBox.Show("Invalid book ID or user ID. Please enter valid values.");
            }
        }

        private byte[] ImageToByteArray(Image image)
        {
            if (image == null)
                return null;

            using (MemoryStream ms = new MemoryStream())
            {
                // Convert the Image to a byte array without using Image.Save
                image.Save(ms, image.RawFormat);
                return ms.ToArray();
            }
        }

        private void DisplayReturnedBooks()
        {
            // Assuming dgvShow is the DataGridView control where you want to display the books
            dgvShow.Rows.Clear();

            // Retrieve returned books from the Books class
            List<DatabaseBook> returnedBooks = booksManager1.GetReturnedBooks();

            // Populate the DataGridView with returned books
            foreach (var book in returnedBooks)
            {
                dgvShow.Rows.Add(book.Id, book.Title, book.Category, book.Author, book.Status, book.ISBN, book.Copyright);
            }
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear the UI elements after borrowing
            txtBookID.Text = "";
            txtUserID.Text = "";
            lblUserName.Text = "";
            lblBookTitle.Text = "";
            lblAuthorName.Text = "";
            dtpBorrow.Value = DateTime.Now; // Reset the DateTimePicker value
            pbPicture.Image = null; // Clear the PictureBox image
        }


        private void pbPicture_Click(object sender, EventArgs e)
        {

        }

        private void dgvShow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
