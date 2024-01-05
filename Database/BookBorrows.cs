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
        public string ISBN { get; set; }
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

        public delegate void BookBorrowedHandler();
        public event BookBorrowedHandler BookBorrowed;

        public bool BorrowBook(string isbn, string userID, string username, string bookTitle, string bookAuthor, DateTime borrowedDate, DateTime returnedDate, DateTime reservedDate, byte[] picture)
        {
            try
            {
                // Check user status and limit the number of books a student can borrow
                User user = new Users().GetUserByStudentOrEmployeeId(userID);
                if (user != null && user.Role == "Student" && CountUserBorrows(userID) >= 2)
                {
                    MessageBox.Show("Students can only borrow up to 2 books.");
                    return false; // Exit the method early
                }

                if (user != null && user.Role == "Teacher" && CountUserBorrows(userID) >= 3)
                {
                    MessageBox.Show("Students can only borrow up to 2 books.");
                    return false; // Exit the method early
                }

                using (MySqlConnection connection = db.getConnection())
                {
                    db.openConnection();

                    string insertQuery = "INSERT INTO bookborrows (ISBN, userID, username, bookTitle, bookAuthor, borrowed, returned, reserved, picture) " +
                                         "VALUES (@ISBN, @userID, @username, @bookTitle, @bookAuthor, @borrowedDate, @returnedDate, @reservedDate, @picture)";

                    using (MySqlCommand insertCommand = new MySqlCommand(insertQuery, connection))
                    {
                        insertCommand.Parameters.AddWithValue("@ISBN", isbn);
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
                            BookBorrowed?.Invoke();
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
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
            finally
            {
                db.closeConnection();
            }
        }

        // Add this method to the BookBorrows class
        public int CountUserBorrows(string userID)
        {
            try
            {
                using (MySqlConnection connection = db.getConnection())
                {
                    db.openConnection();

                    string countQuery = "SELECT COUNT(*) FROM bookborrows WHERE userID = @userID";

                    using (MySqlCommand countCommand = new MySqlCommand(countQuery, connection))
                    {
                        countCommand.Parameters.AddWithValue("@userID", userID);

                        int userBorrowCount = Convert.ToInt32(countCommand.ExecuteScalar());
                        return userBorrowCount;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return -1; // Return -1 to indicate an error
            }
            finally
            {
                db.closeConnection();
            }
        }


    }

}
