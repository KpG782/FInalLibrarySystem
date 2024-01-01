using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FInalLibrarySystem.Database
{
    internal class BorrowedDetails
    {

        private MyDB db;

        public class BorrowedItem 
        {
            public int ID { get; set; }
            public int UserID { get; set; }
            public int BookID { get; set; }
            public DateTime BorrowedDate { get; set; }
            public DateTime ReturnedDate { get; set; }
            public DateTime ReservedDate { get; set; }
            public string Note { get; set; }
        }

        public BorrowedDetails()
        {
            db = new MyDB(); // Initialize the database connection
        }

        // Method to get all borrowed details
        public List<BorrowedItem> GetAllBorrowedDetails()
        {
            List<BorrowedItem> borrowedDetails = new List<BorrowedItem>();

            try
            {
                using (MySqlConnection connection = db.getConnection())
                {
                    db.openConnection(); // Open the database connection

                    // SQL query to retrieve all borrowed details
                    string query = "SELECT * FROM borrowedDetails";
                  

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Assuming BorrowedItem is a class representing borrowed item details
                                BorrowedItem item = new BorrowedItem
                                {
                                    

                                    ID= reader.GetInt32("ID"),
                                    UserID = reader.GetInt32("userID"),
                                    BookID = reader.GetInt32("bookID"),
                                    BorrowedDate = reader.GetDateTime("borrowedDate"),
                                    ReturnedDate = reader.GetDateTime("returnedDate"),
                                    ReservedDate = reader.GetDateTime("reservedDate"),
                                    Note = reader.GetString("note")
                                };

                                borrowedDetails.Add(item);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions (log or notify the user)
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                db.closeConnection(); // Close the database connection
            }

            return borrowedDetails;
        }



    }
}
