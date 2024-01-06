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
using static FInalLibrarySystem.BookList;
using static FInalLibrarySystem.Database.BookBorrows;
using BookListBook = FInalLibrarySystem.BookList.Book;
using DatabaseBook = FInalLibrarySystem.Database.Book;

namespace FInalLibrarySystem
{
    public partial class BookBorrowing : UserControl
    {
        private Books booksManager1;
        private Users usersManager;
        private BookBorrows bookBorrowsManager;  // Instantiate BookBorrows
        private string studentOrEmployeeId;  // Add this line


        public BookBorrowing()
        {
            InitializeComponent();
            booksManager1 = new Books();
            usersManager = new Users(); // Initialize the Users class
            bookBorrowsManager = new BookBorrows(new MyDB());  // Pass the appropriate database instance
        }

        private void LoadAllBooks()
        {
            // Implement code to load all books if needed
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
            // Subscribe to the BookBorrowed event
            bookBorrowsManager.BookBorrowed += BookBorrowedHandler;
        }

        private void BookBorrowedHandler()
        {
            // Handle the event, e.g., refresh the DataGridView
            DisplayReturnedBooks();
        }

        private void txtBookID_TextChanged(object sender, EventArgs e)
        {
            // Ensure the user has entered a valid ISBN
            string isbn = txtBookID.Text.Trim();

            // Retrieve book details from the database
            FInalLibrarySystem.Database.Book book = booksManager1.GetBookDetailsByISBN(isbn);

            // Update labels with book details or show not available
            if (book != null)
            {
                lblBookTitle.Text = book.Title;
                lblAuthorName.Text = book.Author;
                pbPicture.Image = ByteArrayToImage(book.Cover);
            }
            else
            {
                // Clear labels if the book is not found
                lblBookTitle.Text = "Book not available";
                lblAuthorName.Text = "Author not available";
                pbPicture.Image = null;
            }
        }

        private void lblBookTitle_Click(object sender, EventArgs e)
        {
            // Handle label click if needed
        }

        private void lblAuthorName_Click(object sender, EventArgs e)
        {
            // Handle label click if needed
        }

        private void txtUserID_TextChanged(object sender, EventArgs e)
        {
            studentOrEmployeeId = txtUserID.Text.Trim();  // Update the class-level variable

            // Retrieve user details from the database based on student or employee ID
            Users.User user = usersManager.GetUserByStudentOrEmployeeId(studentOrEmployeeId);

            // Update labels with user details or show not available
            if (user != null)
            {
                lblUserName.Text = $"{user.FirstName} {user.LastName}";
            }
            else
            {
                // Clear labels if the user is not found
                lblUserName.Text = "User not available";
            }
        }

        private void lblUserName_Click(object sender, EventArgs e)
        {
            // Handle label click if needed
        }

        private void dtpBorrow_ValueChanged(object sender, EventArgs e)
        {
            // Handle DateTimePicker value changed if needed
        }
        private void btnBorrow_Click(object sender, EventArgs e)
        {
            // Retrieve necessary data from UI elements
            string isbn = txtBookID.Text.Trim();
            if (string.IsNullOrEmpty(isbn))
            {
                MessageBox.Show("Invalid ISBN. Please enter a valid ISBN.");
                return;
            }

            // Retrieve book details from the database
            FInalLibrarySystem.Database.Book book = booksManager1.GetBookDetailsByISBN(isbn);

            // Update labels with book details
            if (book == null)
            {
                // Clear labels if the book is not found
                lblBookTitle.Text = "Book not available";
                lblAuthorName.Text = "Author not available";
                pbPicture.Image = null;

                MessageBox.Show("Book not found. Please enter a valid ISBN.");
                return; // Exit the method early
            }

            // Retrieve user details from the database based on student or employee ID
            Users.User user = usersManager.GetUserByStudentOrEmployeeId(studentOrEmployeeId);

            // Update labels with user details or show not available
            if (user == null)
            {
                // Clear labels if the user is not found
                lblUserName.Text = "User not available";

                MessageBox.Show("User not found. Please enter a valid Student ID or Employee ID.");
                return; // Exit the method early
            }

            // Check if the book is already borrowed
            if (book.Status.Equals("Borrowed", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Sorry, this book is already borrowed.");
                return; // Exit the method early
            }

            // Check if the user is a student and has already borrowed 2 books
            if (user.Role == "Student" && bookBorrowsManager.CountUserBorrows(studentOrEmployeeId) >= 2)
            {
                MessageBox.Show("Students can only borrow up to 2 books.");
                return; // Exit the method early
            }

            // Check if the user is a teacher and has already borrowed 3 books
            if (user.Role == "Teacher" && bookBorrowsManager.CountUserBorrows(studentOrEmployeeId) >= 3)
            {
                MessageBox.Show("Teachers can only borrow up to 3 books.");
                return; // Exit the method early
            }

            // Continue with the borrow process
            string username = lblUserName.Text;
            string bookTitle = lblBookTitle.Text;
            string bookAuthor = lblAuthorName.Text;
            DateTime borrowedDate = dtpBorrow.Value;

            // Set returnedDate based on the user's role
            DateTime returnedDate = user.Role == "Student" ? borrowedDate.AddDays(3) : DateTime.MinValue;



            DateTime reservedDate = DateTime.MinValue;  // You might need to update this based on your logic
            byte[] picture = book.Cover;

            // Call the BorrowBook function in BookBorrows
            bool success = bookBorrowsManager.BorrowBook(isbn, studentOrEmployeeId, username, bookTitle, bookAuthor, borrowedDate, returnedDate, reservedDate, picture);

            // Handle the result
            if (success)
            {
                this.Refresh();
                MessageBox.Show("Book borrowed successfully!");
                bool updateSuccess = booksManager1.UpdateBookStatus(book.Id, "Borrowed");

                // Refresh the DataGridView
                if (updateSuccess)
                {
                    DisplayReturnedBooks();
                }
                // Optionally, you can perform additional actions after a successful borrow.
            }
            else
            {
                MessageBox.Show("Failed to borrow the book. Please try again.");
                // Optionally, you can handle the failure scenario.
            }
        }


        private void PrimaryPanel_Paint(object sender, PaintEventArgs e)
        {

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
                dgvShow.Rows.Add(book.Id, book.Title, book.ISBN, book.Category, book.Author, book.Status,  book.Copyright);
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
            // Handle PictureBox click if needed
        }

        private void dgvShow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle DataGridView cell content click if needed
        }
    }
}
