using DocumentRequesting;
using DocumentRequesting.Data;
using DocumentRequesting.Popup;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DocumentRequestingUtils.Data
{
    public sealed class Notification
    {
        public static readonly List<Notification> Notifications = new List<Notification>();
        public User User { get;}
        public Request Request { get;}
        public DateTime DateAdded { get;}
        private Notification(User user, Request request,DateTime dateAdded)
        {
            this.User = user;
            this.Request = request;
            this.DateAdded = dateAdded;
        }

        internal Notification(User user, Request request)
        {
            this.User = user;
            this.Request = request;
            this.DateAdded = DateTime.Now;

            Insert();
        }

        private void Insert()
        {
            string connectionString = Utilities.DBString;
            string query = "INSERT INTO Notifications ([UserID], [ReferenceNumber], [DateAdded]) VALUES (@ID, @ReferenceNumber, @DateAdded)";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            using (OleDbCommand command = new OleDbCommand(query, connection))
            {
                command.Parameters.AddWithValue("@UserID", User.ID);
                command.Parameters.AddWithValue("@ReferenceNumber", Request.ReferenceNumber);
                command.Parameters.AddWithValue("@DateAdded", DateAdded);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();

                    Notifications.Add(this);
                }
                catch (Exception ex)
                {
                    PopupForm.Show("Error adding document type: " + ex.Message, "Error");
                }
            }
        }

        internal static void LoadNotifications()
        {
            Notification.Notifications.Clear();

            string connectionString = Utilities.DBString;

            string query = "SELECT * FROM Notifications";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
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
                            string referenceNum = reader["ReferenceNumber"]?.ToString() ?? throw new ArgumentNullException(nameof(referenceNum) + " at row " + row.ToString()); ;
                            string userID = reader["UserID"]?.ToString() ?? throw new ArgumentNullException(nameof(userID) + " at row " + row.ToString()); ;
                            string dateAddedStr = reader["DateAdded"]?.ToString() ?? throw new ArgumentNullException(nameof(dateAddedStr) + " at row " + row.ToString()); ;

                            Request request = Request.Requests.First(request => request.ReferenceNumber == referenceNum);
                            User user = User.Users.First(user => user.ID == userID);
                            DateTime dateAdded = DateTime.Parse(dateAddedStr);

                            Notifications.Add(new Notification(user, request, dateAdded));
                            row++;
                        }

                    }
                }
                catch (Exception ex)
                {
                    PopupForm.Show("Error loading document types: " + ex.Message, "Error");
                }
            }
        }
    }
}
