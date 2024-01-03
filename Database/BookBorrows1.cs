using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FInalLibrarySystem.Database
{

    //contructor
    public class BorrowedBook
    {
        public int BookID { get; set; }
        public string UserID { get; set; }
        public string Username { get; set; }
        public string BookTitle { get; set; }
        public string BookAuthor { get; set; }
        public DateTime Borrowed { get; set; }
        public DateTime Returned { get; set; }
        public DateTime Reserved { get; set; }
        public byte[] Picture { get; set; }
    }

    internal class BookBorrows
    {
        private MyDB db;

        public BookBorrows(MyDB myDb)
        {
            db = myDb;
        }

        // Method to add user-input data to BorrowedBooks
        public bool BorrowBook(int bookID, string userID, string username, string bookTitle, string bookAuthor, DateTime borrowedDate, DateTime returnedDate, DateTime reservedDate, byte[] picture)
        {
            try
            {
                using (MySqlConnection connection = db.getConnection())
                {
                    db.openConnection(); // Open the database connection

                    // SQL query to insert user-input borrowed book details
                    string insertQuery = "INSERT INTO BorrowedBooks (bookID, userID, username, bookTitle, bookAuthor, borrowed, returned, reserved, picture) " +
                                         "VALUES (@bookID, @userID, @username, @bookTitle, @bookAuthor, @borrowedDate, @returnedDate, @reservedDate, @picture)";

                    using (MySqlCommand insertCommand = new MySqlCommand(insertQuery, connection))
                    {
                        // Use parameters to prevent SQL injection
                        insertCommand.Parameters.AddWithValue("@bookID", bookID);
                        insertCommand.Parameters.AddWithValue("@userID", userID);
                        insertCommand.Parameters.AddWithValue("@username", username);
                        insertCommand.Parameters.AddWithValue("@bookTitle", bookTitle);
                        insertCommand.Parameters.AddWithValue("@bookAuthor", bookAuthor);
                        insertCommand.Parameters.AddWithValue("@borrowedDate", borrowedDate);
                        insertCommand.Parameters.AddWithValue("@returnedDate", returnedDate);
                        insertCommand.Parameters.AddWithValue("@reservedDate", reservedDate);
                        insertCommand.Parameters.AddWithValue("@picture", picture);

                        // Execute the insert query
                        int rowsAffected = insertCommand.ExecuteNonQuery();

                        // Return true if the operation is successful
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions (log or notify the user)
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
            finally
            {
                db.closeConnection(); // Close the database connection
            }
        }
    }

}
