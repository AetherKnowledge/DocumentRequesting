using DocumentRequesting.Popup;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DocumentRequesting.Data
{
    public sealed class User
    {
        public static User? CurrentUser { get; internal set; }
        public static List<User> Users = new List<User>();
        public string ID {  get; private set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string FullName { get => FirstName + " " + MiddleName + " " + LastName; }
        public string Email { get; set; }
        public string ContactNumber { get; set; }
        public string Username { get; set; }
        public UserType Role { get; private set; }

        private User(string id, string? firstName, string? middleName, string? lastName, string? email, string? contactNumber, string username, UserType role)
        {
            ID = id;
            FirstName = firstName != null ? firstName : string.Empty;
            MiddleName = middleName != null ? middleName : string.Empty;
            LastName = lastName != null ? lastName : string.Empty;
            Email = email != null ? email : string.Empty;
            ContactNumber = contactNumber != null ? contactNumber : string.Empty;
            Username = username;
            Role = role;
        }

        public User(string? firstName, string? middleName, string? lastName, string? email, string? contactNumber, string username, UserType role, string password)
        {
            FirstName = firstName != null ? firstName : string.Empty;
            MiddleName = middleName != null ? middleName : string.Empty;
            LastName = lastName != null ? lastName : string.Empty;
            Email = email != null ? email : string.Empty;
            ContactNumber = contactNumber != null ? contactNumber : string.Empty;
            Username = username;
            Role = role;
            
            if (!Insert(password) || ID == null) throw new ArgumentNullException("ID cannot be null account name " + FullName);
        }

        private bool Insert(string password)
        {
            string connectionString = Utilities.DBString;

            string query = @"INSERT INTO Users ([FirstName], [MiddleName], [LastName], [Email], [ContactNumber], [Username], [Password], [Role]) 
                                            VALUES (@FirstName, @MiddleName, @LastName, @Email, @ContactNumber, @Username, @Password, @Role);";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@FirstName", FirstName);
                        command.Parameters.AddWithValue("@MiddleName", MiddleName);
                        command.Parameters.AddWithValue("@LastName", LastName);
                        command.Parameters.AddWithValue("@Email", Email);
                        command.Parameters.AddWithValue("@ContactNumber", ContactNumber);
                        command.Parameters.AddWithValue("@Username", Username);
                        command.Parameters.AddWithValue("@Password", password);
                        command.Parameters.AddWithValue("@Role", Role.ToString());

                        try
                        {
                            connection.Open();
                            command.ExecuteNonQuery();

                            command.CommandText = "SELECT @@IDENTITY";
                            ID = command.ExecuteScalar()?.ToString() ?? throw new ArgumentNullException("ID cannot be null account name " + FullName);
                            Users.Add(this);
                            Console.WriteLine("User data inserted successfully with ReferenceNumber: " + ID);
                        }
                        catch (Exception ex)
                        {
                            PopupForm.Show("Error: " + ex.Message, "Error");
                            return false;
                        }

                    }
                    catch (Exception ex)
                    {
                        PopupForm.Show("Error: " + ex.Message, "Error");
                        return false;
                    }
                }
            }

            return true;
        }

        internal static void LoadUsers()
        {
            Users.Clear();
            string connectionString = Utilities.DBString;

            string query = "SELECT ID, FirstName, MiddleName, LastName, Email, ContactNumber, Username, Role " +
                           "FROM Users";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        using (OleDbDataReader reader = command.ExecuteReader())
                        {
                            int row = 0;
                            while (reader.Read())
                            {
                                string? id = reader["ID"] != DBNull.Value ? reader["ID"].ToString() : null;
                                string? firstname = reader["FirstName"] != DBNull.Value ? reader["Firstname"].ToString() : string.Empty;
                                string? middlename = reader["MiddleName"] != DBNull.Value ? reader["MiddleName"].ToString() : string.Empty;
                                string? lastname = reader["LastName"] != DBNull.Value ? reader["LastName"].ToString() : string.Empty;
                                string? email = reader["Email"] != DBNull.Value ? reader["Email"].ToString() : string.Empty;
                                string? contactNumber = reader["ContactNumber"] != DBNull.Value ? reader["ContactNumber"].ToString() : string.Empty;
                                string? username = reader["Username"] != DBNull.Value ? reader["Username"].ToString() : string.Empty;
                                string? roleStr = reader["Role"] != DBNull.Value ? reader["Role"].ToString() : string.Empty;
                                UserType role;

                                if (!Enum.TryParse(roleStr, true, out role)) throw new ArgumentException(nameof(roleStr) + " at row " + row.ToString());
                                if (id == null) throw new ArgumentException(nameof(id) + " at row " + row.ToString());
                                if (username == null) throw new ArgumentException(nameof(username) + " at row " + row.ToString());

                                Users.Add(new User(id, firstname, middlename, lastname, email, contactNumber, username, role));
                                row++;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        PopupForm.Show("Error loading user " + ex.Message, "Error");
                    }
                }
            }
        }

        public static bool Login(string username, string password)
        {
            string connectionString = Utilities.DBString;

            string query = "SELECT Password FROM Users WHERE Username = @username";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    try
                    {
                        connection.Open();
                        using (OleDbDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string? passwordFromDB = reader["Password"] != DBNull.Value ? reader["Password"].ToString() : string.Empty;
                                if (passwordFromDB == password) 
                                { 
                                    CurrentUser = Users.FirstOrDefault(user => user.Username == username);
                                    return true; 
                                }
                                else return false;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        PopupForm.Show("Error loading user: " + ex.Message, "Error");
                        return false;
                    }
                }
            }

            return false;
        }

        public static User? GetUserFromUsername(string username)
        {
            foreach (User user in Users)
            {
                if (user.Username == username) return user;
            }

            return null;
        }

        public static User? GetUserFromID(string id)
        {
            foreach (User user in Users)
            {
                if (user.ID == id) return user;
            }

            return null;
        }

        public static bool Exist(string username, string email)
        {
            foreach(User user in Users)
            {
                if (user.Username.Equals(username) || user.Email.Equals(email)) return true;
            }
            return false;
        }

        public static void ResetCurrentUser()
        {
            CurrentUser = null;
        }


    }

    public enum UserType
    {
        Admin,
        Staff
    }

}
