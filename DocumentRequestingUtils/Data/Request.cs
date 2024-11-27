using DocumentRequesting;
using DocumentRequesting.Data;
using DocumentRequesting.Popup;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System.Data.OleDb;

namespace DocumentRequestingUtils.Data
{
    public sealed class Request : ICloneable
    {
        public static readonly Dictionary<string, int> RequestedCount = new Dictionary<string, int>();
        public static readonly List<Request> Requests = new List<Request>();
        public string ReferenceNumber { get; set; }
        public DocumentType RequestType { get; set; }
        public DateTime? DateClaiming { get; set; }
        public RequestStatus Status { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string FullName { get => FirstName + " " + MiddleName + " " + LastName; }
        public string StudentID { get; set; }
        public DateTime BirthDate { get; set; }
        public string Gender { get; set; }
        public string MobileNumber { get; set; }
        public string Email {  get; set; }
        public string Address { get; set; }
        public string Course { get; set; }
        public string Section { get; set; }
        public string Use {  get; set; }
        public DateTime? YearGraduated { get; set; }

        private Request(string referenceNumber,
            DocumentType requestType,
            DateTime? dateClaiming,
            RequestStatus status,
            string firstName,
            string middleName,
            string lastName,
            string studentID,
            DateTime birthDate,
            string gender,
            string mobileNumber,
            string email,
            string address,
            string course,
            string section,
            string use,
            DateTime? yearGraduated)
        {
            ReferenceNumber = referenceNumber;
            RequestType = requestType;
            DateClaiming = dateClaiming;
            Status = status;
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            StudentID = studentID;
            BirthDate = birthDate;
            Gender = gender;
            MobileNumber = mobileNumber;
            Email = email;
            Address = address;
            Course = course;
            Section = section;
            Use = use;
            YearGraduated = yearGraduated;

            if (DateClaiming != null && DateClaiming.Value < DateTime.Now)
            {
                Status = RequestStatus.Archived;
                UpdateToArchived();
            }
        }

        public Request(DocumentType requestType,
            DateTime? dateClaiming,
            RequestStatus status,
            string firstName,
            string middleName,
            string lastName,
            string studentID,
            DateTime birthDate,
            string gender,
            string mobileNumber,
            string email,
            string address,
            string course,
            string section,
            string use,
            DateTime? yearGraduated)
        {
            RequestType = requestType;
            DateClaiming = dateClaiming;
            Status = status;
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            StudentID = studentID;
            BirthDate = birthDate;
            Gender = gender;
            MobileNumber = mobileNumber;
            Email = email;
            Address = address;
            Course = course;
            Section = section;
            Use = use;
            YearGraduated = yearGraduated;

            if (DateClaiming != null && DateClaiming.Value < DateTime.Now)
            {
                Status = RequestStatus.Archived;
            }

            string? referenceNumber = Insert();
            if (referenceNumber == null) throw new ArgumentNullException(nameof(referenceNumber));
            else ReferenceNumber = referenceNumber;

            Requests.Add(this);
            Console.WriteLine("Request data inserted successfully with ReferenceNumber: " + ReferenceNumber);
        }

        internal static void LoadRequests()
        {
            RequestedCount.Clear();
            Requests.Clear();
            string connectionString = Utilities.DBString;

            string query = "SELECT * FROM Requests";

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
                                string referenceNumber = reader["ReferenceNumber"]?.ToString() ?? throw new ArgumentNullException(nameof(referenceNumber) + " at row " + row.ToString());
                                string requestTypeStr = reader["RequestType"]?.ToString() ?? throw new ArgumentNullException(nameof(requestTypeStr) + " at row " + row.ToString());
                                string? dateClaimingStr = reader["DateClaiming"]?.ToString();
                                string statusStr = reader["Status"]?.ToString() ?? throw new ArgumentNullException(nameof(statusStr) + " at row " + row.ToString());
                                string firstname = reader["FirstName"]?.ToString() ?? throw new ArgumentNullException(nameof(firstname) + " at row " + row.ToString());
                                string middlename = reader["MiddleName"]?.ToString() ?? throw new ArgumentNullException(nameof(middlename) + " at row " + row.ToString());
                                string lastname = reader["LastName"]?.ToString() ?? throw new ArgumentNullException(nameof(lastname) + " at row " + row.ToString());
                                string studentID = reader["StudentID"]?.ToString() ?? throw new ArgumentNullException(nameof(studentID) + " at row " + row.ToString());
                                string birthDateStr = reader["BirthDate"]?.ToString() ?? throw new ArgumentNullException(nameof(birthDateStr) + " at row " + row.ToString());
                                string gender = reader["Gender"]?.ToString() ?? throw new ArgumentNullException(nameof(gender) + " at row " + row.ToString());
                                string mobileNumber = reader["MobileNumber"]?.ToString() ?? throw new ArgumentNullException(nameof(mobileNumber) + " at row " + row.ToString());
                                string email = reader["Email"]?.ToString() ?? throw new ArgumentNullException(nameof(email) + " at row " + row.ToString());
                                string address = reader["Address"]?.ToString() ?? throw new ArgumentNullException(nameof(address) + " at row " + row.ToString());
                                string course = reader["Course"]?.ToString() ?? throw new ArgumentNullException(nameof(course) + " at row " + row.ToString());
                                string section = reader["Section"]?.ToString() ?? throw new ArgumentNullException(nameof(section) + " at row " + row.ToString());
                                string use = reader["Use"]?.ToString() ?? "";
                                string? yearGraduatedStr = reader["YearGraduated"]?.ToString();

                                DocumentType type = DocumentType.DocumentTypes.First(dt => dt.Type == requestTypeStr);
                                DateTime? dateClaiming = !string.IsNullOrWhiteSpace(dateClaimingStr) ? DateTime.Parse(dateClaimingStr) : null;
                                DateTime birthDate = birthDate = DateTime.Parse(birthDateStr);
                                DateTime? yearGraduated = !string.IsNullOrWhiteSpace(yearGraduatedStr) ? DateTime.Parse(yearGraduatedStr) : null;
                                RequestStatus status = Enum.TryParse(statusStr, true, out status) ? status : throw new InvalidDataException("Invalid status type at row " + row.ToString());

                                Requests.Add(new Request(referenceNumber, type, dateClaiming, status, firstname, middlename, lastname, studentID, birthDate, gender, mobileNumber, email, address, course, section, use, yearGraduated));

                                if (RequestedCount.ContainsKey(studentID)) RequestedCount[studentID] += 1;
                                else RequestedCount[studentID] = 1;
                                row++;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        PopupForm.Show("Error loading request form " + ex.Message, "Error");
                    }
                }
            }
        }

        private string? Insert()
        {
            string connectionString = Utilities.DBString;

            string query = @"INSERT INTO Requests ([RequestType], [DateClaiming], [Status], [FirstName], [MiddleName], [LastName], [StudentID], [BirthDate], [Gender], [MobileNumber], [Email], [Address], [Course], [Section], [Use], [YearGraduated]) 
                                            VALUES (@RequestType, @DateClaiming, @Status, @FirstName, @MiddleName, @LastName, @StudentID, @BirthDate, @Gender, @MobileNumber, @Email, @Address, @Course, @Section, @Use, @YearGraduated);";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@RequestType", RequestType.Type);
                        command.Parameters.AddWithValue("@DateClaiming", DateClaiming.HasValue ? (DateTime)DateClaiming.Value : DBNull.Value);
                        command.Parameters.AddWithValue("@Status", Status.ToString());
                        command.Parameters.AddWithValue("@FirstName", FirstName);
                        command.Parameters.AddWithValue("@MiddleName", MiddleName);
                        command.Parameters.AddWithValue("@LastName", LastName);
                        command.Parameters.AddWithValue("@StudentID", StudentID);
                        command.Parameters.AddWithValue("@BirthDate", BirthDate);
                        command.Parameters.AddWithValue("@Gender", Gender);
                        command.Parameters.AddWithValue("@MobileNumber", MobileNumber);
                        command.Parameters.AddWithValue("@Email", Email);
                        command.Parameters.AddWithValue("@Address", Address);
                        command.Parameters.AddWithValue("@Course", Course);
                        command.Parameters.AddWithValue("@Section", Section);
                        command.Parameters.AddWithValue("@Use", Use);
                        command.Parameters.AddWithValue("@YearGraduated", YearGraduated.HasValue ? (DateTime) YearGraduated.Value : DBNull.Value);

                        try
                        {
                            connection.Open();
                            command.ExecuteNonQuery();

                            command.CommandText = "SELECT @@IDENTITY";

                            if (RequestedCount.ContainsKey(StudentID)) RequestedCount[StudentID] += 1;
                            else RequestedCount[StudentID] = 1;

                            return command.ExecuteScalar()?.ToString();
                        }
                        catch (Exception ex)
                        {
                            PopupForm.Show("Error: " + ex.Message, "Error");
                            return null;
                        }

                        
                    }
                    catch (Exception ex)
                    {
                        PopupForm.Show("Error: " + ex.Message, "Error");
                        return null;
                    }
                }
            }

        }

        public void Update(Request updatedRequest, DocumentRequesting.Data.User user)
        {
            string connectionString = Utilities.DBString;

            string query = @"UPDATE Requests
                     SET [RequestType] = @RequestType,
                         [DateClaiming] = @DateClaiming,
                         [Status] = @Status,
                         [FirstName] = @FirstName,
                         [MiddleName] = @MiddleName,
                         [LastName] = @LastName,
                         [StudentID] = @StudentID,
                         [BirthDate] = @BirthDate,
                         [Gender] = @Gender,
                         [MobileNumber] = @MobileNumber,
                         [Email] = @Email,
                         [Address] = @Address,
                         [Course] = @Course,
                         [Section] = @Section,
                         [Use] = @Use,
                         [YearGraduated] = @YearGraduated
                     WHERE [ReferenceNumber] = @ReferenceNumber";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        command.Parameters.AddWithValue("@RequestType", updatedRequest.RequestType.Type);
                        command.Parameters.AddWithValue("@DateClaiming", updatedRequest.DateClaiming.HasValue ? (DateTime) updatedRequest.DateClaiming.Value : DBNull.Value);
                        command.Parameters.AddWithValue("@Status", updatedRequest.Status.ToString());
                        command.Parameters.AddWithValue("@FirstName", updatedRequest.FirstName);
                        command.Parameters.AddWithValue("@MiddleName", updatedRequest.MiddleName);
                        command.Parameters.AddWithValue("@LastName", updatedRequest.LastName);
                        command.Parameters.AddWithValue("@StudentID", updatedRequest.StudentID);
                        command.Parameters.AddWithValue("@BirthDate", updatedRequest.BirthDate);
                        command.Parameters.AddWithValue("@Gender", updatedRequest.Gender);
                        command.Parameters.AddWithValue("@MobileNumber", updatedRequest.MobileNumber);
                        command.Parameters.AddWithValue("@Email", updatedRequest.Email);
                        command.Parameters.AddWithValue("@Address", updatedRequest.Address);
                        command.Parameters.AddWithValue("@Course", updatedRequest.Course);
                        command.Parameters.AddWithValue("@Section", updatedRequest.Section);
                        command.Parameters.AddWithValue("@Use", updatedRequest.Use);
                        command.Parameters.AddWithValue("@YearGraduated", updatedRequest.YearGraduated.HasValue ? (DateTime)updatedRequest.YearGraduated.Value : DBNull.Value);
                        command.Parameters.Add("@ReferenceNumber", OleDbType.Integer).Value = this.ReferenceNumber;

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected == 0)
                        {
                            throw new Exception("Update failed: No matching record found for ReferenceNumber " + updatedRequest.ReferenceNumber);
                        }

                        Request.Requests.Remove(this);
                        Request.Requests.Add(updatedRequest);
                        if (updatedRequest.Status == RequestStatus.Ready || updatedRequest.Status == RequestStatus.Declined) 
                        {
                            Utilities.SendEmail(updatedRequest);
                            Notification.Notifications.Add(new Notification(user, updatedRequest)); 
                        }
                    }
                    catch (Exception ex)
                    {
                        PopupForm.Show("Error updating request: " + ex.Message, "Error");
                    }
                }
            }
        }

        internal void UpdateToArchived()
        {
            this.Status = RequestStatus.Archived;

            string connectionString = Utilities.DBString;

            string query = @"UPDATE Requests
                     SET [Status] = @Status
                     WHERE [ReferenceNumber] = @ReferenceNumber";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        command.Parameters.AddWithValue("@Status", RequestStatus.Archived.ToString());
                        command.Parameters.Add("@ReferenceNumber", OleDbType.Integer).Value = this.ReferenceNumber;

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected == 0)
                        {
                            throw new Exception("Update failed: No matching record found for ReferenceNumber " + this.ReferenceNumber);
                        }

                    }
                    catch (Exception ex)
                    {
                        PopupForm.Show("Error updating request: " + ex.Message, "Error");
                    }
                }
            }
        }

        public void Delete()
        {
            string connectionString = Utilities.DBString;

            string query = "DELETE FROM Requests WHERE ReferenceNumber = @ReferenceNumber";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        command.Parameters.AddWithValue("@ReferenceNumber", ReferenceNumber);

                        Requests.Remove(this);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected == 0)
                        {
                            throw new Exception("Delete failed: No matching record found for ReferenceNumber " + ReferenceNumber);
                        }
                    }
                    catch (Exception ex)
                    {
                        PopupForm.Show("Error deleting request: " + ex.Message, "Error");
                    }
                }
            }
        }

        internal static void AddDataFromExcel(string filePath)
        {
            List<List<string?>> data = new List<List<string?>>();

            using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                IWorkbook workbook;

                if (Path.GetExtension(filePath).Equals(".xls", StringComparison.OrdinalIgnoreCase))
                    workbook = new HSSFWorkbook(fileStream);
                else
                    workbook = new XSSFWorkbook(fileStream);

                ISheet sheet = workbook.GetSheetAt(0);

                
                for (int row = 1; row <= sheet.LastRowNum; row++)
                {
                    List<string?> rowData = new List<string?>();

                    IRow currentRow = sheet.GetRow(row);
                    if (currentRow == null) continue;
                    for (int col = 0; col < currentRow.LastCellNum; col++)
                    {
                        ICell cell = currentRow.GetCell(col);
                        string? cellValue = cell?.ToString() ?? null;

                        rowData.Add(cellValue);
                    }
                    data.Add(rowData);
                }
            }

            int dataRow = 0;
            foreach (List<string?> col in data)
            {
                string requestTypeStr = col[1] ?? throw new ArgumentNullException(nameof(requestTypeStr) + " at row " + dataRow.ToString());
                string? dateClaimingStr = col[2]?.ToString();
                string statusStr = col[3] ?? throw new ArgumentNullException(nameof(statusStr) + " at row " + dataRow.ToString());
                string firstname = col[4] ?? throw new ArgumentNullException(nameof(firstname) + " at row " + dataRow.ToString());
                string middlename = col[5] ?? throw new ArgumentNullException(nameof(middlename) + " at row " + dataRow.ToString());
                string lastname = col[6] ?? throw new ArgumentNullException(nameof(lastname) + " at row " + dataRow.ToString());
                string studentID = col[7] ?? throw new ArgumentNullException(nameof(studentID) + " at row " + dataRow.ToString());
                string birthDateStr = col[8] ?? throw new ArgumentNullException(nameof(birthDateStr) + " at row " + dataRow.ToString());
                string gender = col[9] ?? throw new ArgumentNullException(nameof(gender) + " at row " + dataRow.ToString());
                string mobileNumber = col[10] ?? throw new ArgumentNullException(nameof(mobileNumber) + " at row " + dataRow.ToString());
                string email = col[11] ?? throw new ArgumentNullException(nameof(email) + " at row " + dataRow.ToString());
                string address = col[12] ?? throw new ArgumentNullException(nameof(address) + " at row " + dataRow.ToString());
                string course = col[13] ?? throw new ArgumentNullException(nameof(course) + " at row " + dataRow.ToString());
                string section = col[14] ?? throw new ArgumentNullException(nameof(section) + " at row " + dataRow.ToString());
                string use = col[15] ?? "";
                string? yearGraduatedStr = col[16]?.ToString();

                DocumentType type = DocumentType.DocumentTypes.First(dt => dt.Type == requestTypeStr);
                DateTime? dateClaiming = !string.IsNullOrWhiteSpace(dateClaimingStr) ? DateTime.Parse(dateClaimingStr) : null;
                DateTime birthDate = birthDate = DateTime.Parse(birthDateStr);
                DateTime? yearGraduated = !string.IsNullOrWhiteSpace(yearGraduatedStr) ? DateTime.Parse(yearGraduatedStr) : null;
                RequestStatus status = Enum.TryParse(statusStr, true, out status) ? status : throw new InvalidDataException("Invalid status type at row " + dataRow.ToString());

                Requests.Add(new Request(type, dateClaiming, status, firstname, middlename, lastname, studentID, birthDate, gender, mobileNumber, email, address, course, section, use, yearGraduated));
                dataRow++;
            }
        }

        public object Clone()
        {
            Request clonedRequest = (Request)this.MemberwiseClone();

            clonedRequest.DateClaiming = this.DateClaiming?.AddTicks(0);
            clonedRequest.YearGraduated = this.YearGraduated?.AddTicks(0);

            return clonedRequest;

        }
    }

    public enum RequestStatus
    {
        Pending,
        OnProcess,
        Declined,
        Ready,
        Archived
    }

}
