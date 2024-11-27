using DocumentRequesting.Popup;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentRequesting.Data
{
    public class DocumentType
    {
        public static List<DocumentType> DocumentTypes = new List<DocumentType>();
        public string Type {  get; set; }
        public string Abv { get; set; }

        public DocumentType(string type, string abv)
        {
            Type = type;
            Abv = abv;
        }

        internal static void LoadDocumentTypes()
        {
            DocumentTypes.Clear();

            string connectionString = Utilities.DBString;

            string query = "SELECT * FROM RequestTypes";

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
                            string type = reader["Type"]?.ToString() ?? throw new ArgumentNullException(nameof(type) + " at row " + row.ToString());
                            string abv = reader["Abv"]?.ToString() ?? throw new ArgumentNullException(nameof(abv) + " at row " + row.ToString());
                            DocumentTypes.Add(new DocumentType(type, abv));
                        }
                        row++;
                    }
                }
                catch (Exception ex)
                {
                    PopupForm.Show("Error loading document types: " + ex.Message, "Error");
                }
            }
        }

        public static bool Insert(string type, string abv)
        {
            string connectionString = Utilities.DBString;
            string query = "INSERT INTO RequestTypes ([Type], [Abv]) VALUES (@Type, @Abv)";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            using (OleDbCommand command = new OleDbCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Type", type);
                command.Parameters.AddWithValue("@Abv", abv);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    DocumentTypes.Add(new DocumentType(type, abv));
                    return true;
                }
                catch (Exception ex)
                {
                    PopupForm.Show("Error adding document type: " + ex.Message, "Error");
                    return false;
                }
            }
        }

        public static void Update(DocumentType oldType, DocumentType newType)
        {
            string connectionString = Utilities.DBString;
            string query = "UPDATE RequestTypes SET Type = @NewType, Abv = @NewAbv WHERE Type = @OldType";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            using (OleDbCommand command = new OleDbCommand(query, connection))
            {
                command.Parameters.AddWithValue("@NewType", newType.Type);
                command.Parameters.AddWithValue("@NewAbv", newType.Abv);
                command.Parameters.AddWithValue("@OldType", oldType.Type);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    DocumentType? documentType = DocumentTypes.FirstOrDefault(dt => dt.Type == oldType.Type);
                    if (documentType != null)
                    {
                        documentType.Type = newType.Type;
                    }

                }
                catch (Exception ex)
                {
                    PopupForm.Show("Error updating document type: " + ex.Message, "Error");
                }
            }
        }

        public static void Delete(string type)
        {
            string connectionString = Utilities.DBString;
            string query = "DELETE FROM RequestTypes WHERE Type = @Type";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            using (OleDbCommand command = new OleDbCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Type", type);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();

                    DocumentTypes.RemoveAll(dt => dt.Type == type);
                }
                catch (Exception ex)
                {
                    PopupForm.Show("Error deleting document type: " + ex.Message, "Error");
                }
            }
        }

        public override string ToString()
        {
            return Type + " - " + Abv;
        }

    }
}
