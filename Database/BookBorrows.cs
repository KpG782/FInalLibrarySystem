using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static FInalLibrarySystem.Database.Users;

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

        public bool BorrowBook(int bookID, int userID, string username, string bookTitle, string bookAuthor, DateTime borrowedDate, DateTime returnedDate, DateTime reservedDate, byte[] picture)
        {
            try
            {
                using (MySqlConnection connection = db.getConnection())
                {
                    db.openConnection();

                    string insertQuery = "INSERT INTO bookborrows (bookID, userID, username, bookTitle, bookAuthor, borrowed, returned, reserved, picture) " +
                                         "VALUES (@bookID, @userID, @username, @bookTitle, @bookAuthor, @borrowedDate, @returnedDate, @reservedDate, @picture)";

                    using (MySqlCommand insertCommand = new MySqlCommand(insertQuery, connection))
                    {
                        insertCommand.Parameters.AddWithValue("@bookID", bookID);
                        insertCommand.Parameters.AddWithValue("@userID", userID);
                        insertCommand.Parameters.AddWithValue("@username", username);
                        insertCommand.Parameters.AddWithValue("@bookTitle", bookTitle);
                        insertCommand.Parameters.AddWithValue("@bookAuthor", bookAuthor);
                        insertCommand.Parameters.AddWithValue("@borrowedDate", borrowedDate);
                        insertCommand.Parameters.AddWithValue("@returnedDate", returnedDate);
                        insertCommand.Parameters.AddWithValue("@reservedDate", reservedDate);
                        insertCommand.Parameters.AddWithValue("@picture", picture);

                        int rowsAffected = insertCommand.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            // Successful borrow
                            return true;
                        }
                        else
                        {
                            Console.WriteLine("No rows affected. Failed to borrow the book.");
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the exception or display a user-friendly error message
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
            finally
            {
                db.closeConnection();
            }
        }





    }

}
