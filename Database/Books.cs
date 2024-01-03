using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using static FInalLibrarySystem.BookList;

namespace FInalLibrarySystem.Database
{
    public class User
    {
        // Define properties for user information
        public int UserID { get; set; }
        public string Username { get; set; }
        public string UserType { get; set; } // Add a property to store user type (e.g., "Student" or "Employee")
                                             // Add other properties as needed
    }

    //constructor
    public class Book
    {
        // Define properties for book information
        public int Id { get; set; }
        public string Title { get; set; }
        public string ISBN { get; set; }
        public string Category { get; set; }
        public string Author { get; set; }
        public int Copyright { get; set; }
        public string Publisher { get; set; }
        public string Status { get; set; }
        public string Description { get; set; }
        public byte[] Cover { get; set; }
    }

    public class Books
    {

        private MyDB db;

        public Books()
        {
            db = new MyDB();
        }

        // Assuming you have a method to retrieve academic books
        public List<Book> GetAcademicBooks()
        {
            List<Book> academicBooks = new List<Book>();

            try
            {
                using (MySqlConnection connection = db.getConnection())
                {
                    db.openConnection(); // Open the database connection

                    // Modify the query to retrieve academic books
                    string query = "SELECT * FROM books WHERE category = 'Academic'";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Book book = new Book
                                {
                                    Id = reader.GetInt32("id"),
                                    Title = reader.GetString("title"),
                                    ISBN = reader.GetString("ISBN"),
                                    Category = reader.GetString("category"),
                                    Author = reader.GetString("author"),
                                    Copyright = reader.GetInt32("copyright"),
                                    Publisher = reader.GetString("publisher"),
                                    Status = reader.GetString("status"),
                                    Description = reader.GetString("description"),
                                    Cover = (byte[])reader["cover"]
                                };
                                academicBooks.Add(book);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log the error)
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                db.closeConnection(); // Close the database connection
            }

            return academicBooks;
        }

        // Method to retrieve fictional books
        public List<Book> GetFictionalBooks()
        {
            List<Book> fictionalBooks = new List<Book>();

            try
            {
                using (MySqlConnection connection = db.getConnection())
                {
                    db.openConnection(); // Open the database connection

                    // Modify the query to retrieve fictional books
                    string query = "SELECT * FROM books WHERE category = 'Fiction'";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Book book = new Book
                                {
                                    Id = reader.GetInt32("id"),
                                    Title = reader.GetString("title"),
                                    ISBN = reader.GetString("ISBN"),
                                    Category = reader.GetString("category"),
                                    Author = reader.GetString("author"),
                                    Copyright = reader.GetInt32("copyright"),
                                    Publisher = reader.GetString("publisher"),
                                    Status = reader.GetString("status"),
                                    Description = reader.GetString("description"),
                                    Cover = (byte[])reader["cover"]
                                };
                                fictionalBooks.Add(book);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log the error)
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                db.closeConnection(); // Close the database connection
            }

            return fictionalBooks;
        }

        // Method to retrieve non-fictional books
        public List<Book> GetNonFictionalBooks()
        {
            List<Book> nonFictionalBooks = new List<Book>();

            try
            {
                using (MySqlConnection connection = db.getConnection())
                {
                    db.openConnection(); // Open the database connection

                    // Modify the query to retrieve non-fictional books
                    string query = "SELECT * FROM books WHERE category = 'Non-Fiction'";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Book book = new Book
                                {
                                    Id = reader.GetInt32("id"),
                                    Title = reader.GetString("title"),
                                    ISBN = reader.GetString("ISBN"),
                                    Category = reader.GetString("category"),
                                    Author = reader.GetString("author"),
                                    Copyright = reader.GetInt32("copyright"),
                                    Publisher = reader.GetString("publisher"),
                                    Status = reader.GetString("status"),
                                    Description = reader.GetString("description"),
                                    Cover = (byte[])reader["cover"]
                                };
                                nonFictionalBooks.Add(book);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log the error)
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                db.closeConnection(); // Close the database connection
            }

            return nonFictionalBooks;
        }


        // Method to retrieve all books
        public List<Book> GetAllBooks()
        {
            List<Book> allBooks = new List<Book>();

            try
            {
                using (MySqlConnection connection = db.getConnection())
                {
                    db.openConnection(); // Open the database connection

                    // Modify the query to retrieve all books
                    string query = "SELECT * FROM books";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Book book = new Book
                                {
                                    Id = reader.GetInt32("id"),
                                    Title = reader.GetString("title"),
                                    ISBN = reader.GetString("ISBN"),
                                    Category = reader.GetString("category"),
                                    Author = reader.GetString("author"),
                                    Copyright = reader.GetInt32("copyright"),
                                    Publisher = reader.GetString("publisher"),
                                    Status = reader.GetString("status"),
                                    Description = reader.GetString("description"),
                                    Cover = (byte[])reader["cover"]
                                };
                                allBooks.Add(book);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log the error)
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                db.closeConnection(); // Close the database connection
            }

            return allBooks;
        }

        // Add a method to insert a borrowed book record
        public bool BorrowBook(int bookID, int userID, DateTime borrowedDate, DateTime returnDate, string note)
        {
            try
            {
                using (MySqlConnection connection = db.getConnection())
                {
                    db.openConnection(); // Open the database connection

                    // SQL query to insert borrowed book details
                    string insertQuery = "INSERT INTO borrowedDetails (bookID, userID, borrowedDate, returnedDate, note) " +
                                         "VALUES (@bookID, @userID, @borrowedDate, @returnedDate, @note)";

                    using (MySqlCommand insertCommand = new MySqlCommand(insertQuery, connection))
                    {
                        // Use parameters to prevent SQL injection
                        insertCommand.Parameters.AddWithValue("@bookID", bookID);
                        insertCommand.Parameters.AddWithValue("@userID", userID);
                        insertCommand.Parameters.AddWithValue("@borrowedDate", borrowedDate);
                        insertCommand.Parameters.AddWithValue("@returnedDate", returnDate);
                        insertCommand.Parameters.AddWithValue("@note", note);

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

        //get book details by id
        public Book GetBookDetailsById(int bookID)
        {
            try
            {
                using (MySqlConnection connection = db.getConnection())
                {
                    db.openConnection(); // Open the database connection

                    // Modify the query to retrieve book details by ID
                    string query = "SELECT * FROM books WHERE id = @bookID";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@bookID", bookID);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Create a Book object with retrieved details
                                return new Book
                                {
                                    Id = reader.GetInt32("id"),
                                    Title = reader.GetString("title"),
                                    Author = reader.GetString("author"),
                                    // Add other properties as needed
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log the error)
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                db.closeConnection(); // Close the database connection
            }

            return null; // Return null if the book is not found or an error occurs
        }

        public User GetUserDetailsById(int userID)
        {
            try
            {
                using (MySqlConnection connection = db.getConnection())
                {
                    db.openConnection(); // Open the database connection

                    // Modify the query to retrieve user details and user type by ID
                    string query = "SELECT userID, username, 'Student' AS userType FROM students WHERE studentID = @userID " +
                                   "UNION " +
                                   "SELECT userID, username, 'Employee' AS userType FROM employees WHERE employeeID = @userID";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@userID", userID);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Create a User object with retrieved details
                                return new User
                                {
                                    UserID = reader.GetInt32("userID"),
                                    Username = reader.GetString("username"),
                                    UserType = reader.GetString("userType"),
                                    // Add other properties as needed
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log the error)
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                db.closeConnection(); // Close the database connection
            }

            return null; // Return null if the user is not found or an error occurs
        }


    }


}
