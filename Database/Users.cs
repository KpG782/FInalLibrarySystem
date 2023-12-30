using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FInalLibrarySystem.Database
{
    internal class Users
    {

        internal class User
        {
            public int Id { get; set; }
            public string Username { get; set; }
            public string Password { get; set; }
            public string Email { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string MiddleInitial { get; set; }
            public string Role { get; set; }
            public string Department { get; set; }
            public string StudentID { get; set; }
            public string EmployeeID { get; set; }
            public string Section { get; set; }
            public string Year { get; set; }
            public byte[] Picture { get; set; }
        }

        

        // Add a method to retrieve user by ID
        public User GetUserById(int userId)
        {
            User user = null;

            try
            {
                using (MySqlConnection connection = db.getConnection())
                {
                    db.openConnection(); // Open the database connection

                    string query = "SELECT * FROM `app_users` WHERE `id` = @userId";
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                    {
                        adapter.SelectCommand.Parameters.Add("@userId", MySqlDbType.Int32).Value = userId;

                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        if (table.Rows.Count > 0)
                        {
                            MessageBox.Show("The user id should be : " + userId);

                            DataRow row = table.Rows[0];

                            user = new User
                            {
                                Id = Convert.ToInt32(row["id"]),
                                Username = row["username"].ToString(),
                                Password = row["password"].ToString(),
                                Email = row["email"].ToString(),
                                FirstName = row["first_name"].ToString(),
                                LastName = row["last_name"].ToString(),
                                MiddleInitial = row["middle_initial"].ToString(),
                                Role = row["role"].ToString(),
                                Department = row["department"].ToString(),
                                StudentID = row["studentID"].ToString(),
                                EmployeeID = row["employeeID"].ToString(),
                                Section = row["section"].ToString(),
                                Year = row["year"].ToString(),
                                Picture = (byte[])row["picture"]

                            };
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

            return user;
        }

        private MyDB db;

        public Users()
        {
            db = new MyDB();
        }

        public List<User> GetAllUsers()
        {
            List<User> users = new List<User>();

            try
            {
                using (MySqlConnection connection = db.getConnection())
                {
                    db.openConnection(); // Open the database connection

                    string query = "SELECT * FROM app_users";
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        foreach (DataRow row in table.Rows)
                        {
                            User user = new User
                            {
                                Id = Convert.ToInt32(row["id"]),
                                Username = row["username"].ToString(),
                                Password = row["password"].ToString(),
                                Email = row["email"].ToString(),
                                FirstName = row["first_name"].ToString(),
                                LastName = row["last_name"].ToString(),
                                MiddleInitial = row["middle_initial"].ToString(),
                                Role = row["role"].ToString(),
                                Department = row["department"].ToString(),
                                StudentID = row["studentID"].ToString(),
                                EmployeeID = row["employeeID"].ToString(),
                                Section = row["section"].ToString(),
                                Year = row["year"].ToString(),
                                Picture = (byte[])row["picture"]
                            };

                            users.Add(user);
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

            return users;
        }


        //getallstudents only
        public List<User> GetAllStudents()
        {
            List<User> students = new List<User>();

            try
            {
                using (MySqlConnection connection = db.getConnection())
                {
                    db.openConnection(); // Open the database connection

                    string query = "SELECT * FROM app_users WHERE role = 'Student'";
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        foreach (DataRow row in table.Rows)
                        {
                            User student = new User
                            {
                                Id = Convert.ToInt32(row["id"]),
                                Username = row["username"].ToString(),
                                Password = row["password"].ToString(),
                                Email = row["email"].ToString(),
                                FirstName = row["first_name"].ToString(),
                                LastName = row["last_name"].ToString(),
                                MiddleInitial = row["middle_initial"].ToString(),
                                Role = row["role"].ToString(),
                                Department = row["department"].ToString(),
                                StudentID = row["studentID"].ToString(),
                                EmployeeID = row["employeeID"].ToString(),
                                Section = row["section"].ToString(),
                                Year = row["year"].ToString(),
                                Picture = (byte[])row["picture"]
                            };

                            students.Add(student);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                db.closeConnection(); // Close the database connection
            }

            return students;
        }


        //get all teachers
        public List<User> GetAllTeachers()
        {
            List<User> teachers = new List<User>();

            try
            {
                using (MySqlConnection connection = db.getConnection())
                {
                    db.openConnection(); // Open the database connection

                    string query = "SELECT * FROM app_users WHERE role = 'Teacher'";
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        foreach (DataRow row in table.Rows)
                        {
                            User teacher = new User
                            {
                                Id = Convert.ToInt32(row["id"]),
                                Username = row["username"].ToString(),
                                Password = row["password"].ToString(),
                                Email = row["email"].ToString(),
                                FirstName = row["first_name"].ToString(),
                                LastName = row["last_name"].ToString(),
                                MiddleInitial = row["middle_initial"].ToString(),
                                Role = row["role"].ToString(),
                                Department = row["department"].ToString(),
                                StudentID = row["studentID"].ToString(),
                                EmployeeID = row["employeeID"].ToString(),
                                Section = row["section"].ToString(),
                                Year = row["year"].ToString(),
                                Picture = (byte[])row["picture"]
                            };

                            teachers.Add(teacher);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                db.closeConnection(); // Close the database connection
            }

            return teachers;
        }

    }
}
