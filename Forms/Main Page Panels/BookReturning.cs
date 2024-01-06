using FInalLibrarySystem.Database;
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
using static FInalLibrarySystem.Database.Users;

namespace FInalLibrarySystem
{
    public partial class BookReturning : UserControl
    {
        private Books books; // Assuming you have an instance of the Books class
        private BookBorrows bookBorrows;
        private Users usersManager;
        private string studentOrEmployeeId;  // Add this line

        public BookReturning()
        {
            InitializeComponent();
            books = new Books();
            bookBorrows = new BookBorrows(new MyDB());
            usersManager = new Users(); // Initialize the Users class
            DisplayBooks();
            DisplayBookBorrows();
        }

        // Update the DisplayReturnedBooks method in the BookReturning class
        private void DisplayBooks()
        {
            // Assuming dgvShow is the DataGridView control where you want to display the books
            dgvBooks.Rows.Clear();

            // Retrieve returned books from the Books class
            List<Book> borrowedBooks = books.GetBorrowedBooks();

            // Populate the DataGridView with returned books
            foreach (var book in borrowedBooks)
            {
                dgvBooks.Rows.Add(book.Id, book.Title, book.ISBN, book.Category, book.Author, book.Status, book.Copyright);
            }
        }

        private void DisplayBookBorrows()
        {
            // Assuming dgvBookBorrows is the DataGridView control where you want to display borrowed books
            dgvBookBorrow.Rows.Clear();

            // Retrieve all borrowed books from the BookBorrows class
            List<BorrowedBook> borrowedBooks = bookBorrows.GetAllBorrowedBooks();

            // Populate the DataGridView with borrowed books
            foreach (var borrowedBook in borrowedBooks)
            {
                dgvBookBorrow.Rows.Add(
                    borrowedBook.Username,
                    borrowedBook.ISBN,
                    borrowedBook.BookTitle,
                    borrowedBook.BookAuthor,
                    borrowedBook.Borrowed,
                    borrowedBook.Returned,
                    borrowedBook.Reserved
                // Add other columns as needed
                );
            }
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {

        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void IssueIDLabel_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {
            //dito ko lagay yung load
            //pnlReceiptForm.Visible = false;
        }

        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void ReturnButton_Click_1(object sender, EventArgs e)
        {
            //pnlReceiptForm.Visible=true;
        }

        private void pnlReceiptForm_Load(object sender, EventArgs e)
        {

        }

        private void PrimaryPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pbPicture_Click(object sender, EventArgs e)
        {

        }

        private void txtBookID_TextChanged(object sender, EventArgs e)
        {
            string isbn = txtBookID.Text.Trim();
            BorrowedBook borrowedBook = bookBorrows.GetBorrowedBookByISBN(isbn);

            if (borrowedBook != null)
            {
                // Display book information in the corresponding labels and picture box
                lblAuthorName.Text = borrowedBook.BookAuthor;
                lblBookTitle.Text = borrowedBook.BookTitle;

                // Check if the Cover property is not null before assigning to the PictureBox
                if (borrowedBook.Picture != null && borrowedBook.Picture.Length > 0)
                {
                    using (MemoryStream ms = new MemoryStream(borrowedBook.Picture))
                    {
                        pbPicture.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    // Set a default image or handle the case where the cover is not available
                }

                // Synchronize UserID and Username
                txtUserID.Text = borrowedBook.UserID;
                lblUserName.Text = borrowedBook.Username;
            }
            else
            {
                // Clear labels and picture box if book is not found
                lblAuthorName.Text = "Author Not Available";
                lblBookTitle.Text = "Book Not Available";
                pbPicture.Image = null;
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
            studentOrEmployeeId = txtUserID.Text.Trim();  // Update the class-level variable

            // Retrieve borrowed books based on the entered student or employee ID
            BorrowedBook borrowedBook = bookBorrows.GetBorrowedBookByUserID(studentOrEmployeeId);

            // Update labels with user details or show not available
            if (borrowedBook != null)
            {
                // Display book information in the corresponding labels and picture box
                lblAuthorName.Text = borrowedBook.BookAuthor;
                lblBookTitle.Text = borrowedBook.BookTitle;

                // Check if the Cover property is not null before assigning to the PictureBox
                if (borrowedBook.Picture != null && borrowedBook.Picture.Length > 0)
                {
                    using (MemoryStream ms = new MemoryStream(borrowedBook.Picture))
                    {
                        pbPicture.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    // Set a default image or handle the case where the cover is not available
                }

                // Synchronize ISBN
                txtBookID.Text = borrowedBook.ISBN;
            }
            else
            {
                // Clear labels and picture box if the user is not found or has no borrowed books
                lblAuthorName.Text = "Author Not Available";
                lblBookTitle.Text = "Book Not Available";
                pbPicture.Image = null;
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
            // Retrieve necessary information from UI elements
            string bookID = txtBookID.Text.Trim();
            string userID = txtUserID.Text.Trim();

            // Check if both book ID and user ID are provided
            if (!string.IsNullOrEmpty(bookID) && !string.IsNullOrEmpty(userID))
            {
                // Update the book status to "Returned" in the Books class using ISBN
                bool isBookReturned = books.UpdateBookStatusByISBN(bookID, "Returned");

                if (isBookReturned)
                {
                    // Remove the returned book from the bookborrows database
                    bool isBookRemoved = bookBorrows.RemoveReturnedBook(bookID);

                    if (isBookRemoved)
                    {
                        // Display a message indicating successful return and removal
                        MessageBox.Show("Book returned and removed successfully.");

                        // Refresh the DataGridView controls to reflect the changes
                        DisplayBooks();
                        DisplayBookBorrows();
                    }
                    else
                    {
                        // Display a message if removing the book fails
                        MessageBox.Show("Failed to remove the returned book from bookborrows database.");
                    }
                }
                else
                {
                    // Display a message if updating the book status fails
                    MessageBox.Show("Failed to update book status.");
                }
            }
            else
            {
                // Display a message if book ID or user ID is missing
                MessageBox.Show("Please provide both Book ID and User ID.");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void dgvBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvBookBorrow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DisplayBooks();
            DisplayBookBorrows();
        }
    }
}
