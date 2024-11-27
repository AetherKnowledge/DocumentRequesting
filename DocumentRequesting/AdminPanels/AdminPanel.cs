using DocumentRequesting.Popup;
using DocumentRequestingAdmin.Popup;
using DocumentRequestingUtils.Data;
using System.ComponentModel;

namespace DocumentRequesting.AdminPanels
{
    public partial class AdminPanel : AdminTemplate
    {
        private DataGridView selectedTable;
        private readonly List<Request> filteredRequest = new List<Request>();
        public AdminPanel()
        {
            InitializeComponent();
            selectedTable = allTable;

            allTable.CellClick += CellContentClick;
            pendingTable.CellClick += CellContentClick;
            onProcessTable.CellClick += CellContentClick;
            declinedTable.CellClick += CellContentClick;
            readyTable.CellClick += CellContentClick;
            archiveTable.CellClick += CellContentClick;

            searchBox.innerTextBox.TextChanged += search_TextChanged;
            filteredRequest.AddRange(Request.Requests);
        }

        public new void Show()
        {
            Utilities.AdminPanel = this;
            base.Show();
            RefreshTables();
        }

        private void RefreshTables()
        {

            Utilities.RefreshData();
            Search();

            RefreshAllTable();
            RefreshPendingTable();
            RefreshProcessingTable();
            RefreshDeclinedTable();
            RefreshReadyTable();
            RefreshArchivedTable();

        }

        private void RefreshAllTable()
        {
            allTable.Rows.Clear();

            foreach (Request request in filteredRequest)
            {
                DataGridViewRow row = new DataGridViewRow();
                string status = request.Status.ToString();
                if (request.Status == RequestStatus.OnProcess) status = "On Process";
                else if (request.Status == RequestStatus.Ready) status = "Ready for Claiming";

                row.Cells.Add(new DataGridViewTextBoxCell { Value = request.ReferenceNumber });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = request.FullName });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = request.StudentID });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = request.Course + "-" + request.Section });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = request.YearGraduated != null ? request.YearGraduated.Value.ToString(Utilities.DateFormat) : null });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = request.Gender });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = request.RequestType.Abv });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = request.DateClaiming != null ? request.DateClaiming.Value.ToString(Utilities.DateFormat) : null });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = request.DateClaiming != null ? request.DateClaiming.Value.ToString(Utilities.TimeFormat) : null });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = status });

                allTable.Rows.Add(row);
                allTable.Sort(allTable.Columns[0], ListSortDirection.Ascending);
                allTable.Invalidate();
            }

        }

        private void RefreshPendingTable()
        {
            pendingTable.Rows.Clear();

            foreach (Request request in filteredRequest)
            {
                if (request.Status != RequestStatus.Pending) continue;
                DataGridViewRow row = new DataGridViewRow();

                row.Cells.Add(new DataGridViewTextBoxCell { Value = request.ReferenceNumber });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = request.FullName });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = request.StudentID });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = request.Course + "-" + request.Section });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = request.YearGraduated != null ? request.YearGraduated.Value.ToString(Utilities.DateFormat) : null });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = request.Gender });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = request.RequestType.Abv });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = request.DateClaiming != null ? request.DateClaiming.Value.ToString(Utilities.DateFormat) : null });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = request.DateClaiming != null ? request.DateClaiming.Value.ToString(Utilities.TimeFormat) : null });
                row.Cells.Add(new DataGridViewButtonCell { Value = request.Status, FlatStyle = FlatStyle.Flat });

                pendingTable.Rows.Add(row);
                pendingTable.Sort(pendingTable.Columns[0], ListSortDirection.Ascending);
                pendingTable.Invalidate();
            }

        }

        private void RefreshProcessingTable()
        {
            onProcessTable.Rows.Clear();

            foreach (Request request in Request.Requests)
            {
                if (request.Status != RequestStatus.OnProcess) continue;
                DataGridViewRow row = new DataGridViewRow();

                string status = "On Process";

                row.Cells.Add(new DataGridViewTextBoxCell { Value = request.ReferenceNumber });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = request.FullName });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = request.StudentID });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = request.Course + "-" + request.Section });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = request.YearGraduated != null ? request.YearGraduated.Value.ToString(Utilities.DateFormat) : null });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = request.Gender });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = request.RequestType.Abv });
                row.Cells.Add(new DataGridViewButtonCell { Value = request.DateClaiming != null ? request.DateClaiming.Value.ToString(Utilities.DateFormat) : null, FlatStyle = FlatStyle.Flat });
                row.Cells.Add(new DataGridViewButtonCell { Value = request.DateClaiming != null ? request.DateClaiming.Value.ToString(Utilities.TimeFormat) : null, FlatStyle = FlatStyle.Flat });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = status });

                onProcessTable.Rows.Add(row);
                onProcessTable.Sort(onProcessTable.Columns[0], ListSortDirection.Ascending);
                onProcessTable.Invalidate();
            }

        }

        private void RefreshDeclinedTable()
        {
            declinedTable.Rows.Clear();

            foreach (Request request in filteredRequest)
            {
                if (request.Status != RequestStatus.Declined) continue;
                DataGridViewRow row = new DataGridViewRow();

                row.Cells.Add(new DataGridViewTextBoxCell { Value = request.ReferenceNumber });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = request.FullName });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = request.StudentID });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = request.Course + "-" + request.Section });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = request.YearGraduated != null ? request.YearGraduated.Value.ToString(Utilities.DateFormat) : null });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = request.Gender });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = request.RequestType.Abv });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = request.DateClaiming != null ? request.DateClaiming.Value.ToString(Utilities.DateFormat) : null });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = request.DateClaiming != null ? request.DateClaiming.Value.ToString(Utilities.TimeFormat) : null });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = request.Status });

                declinedTable.Rows.Add(row);
                declinedTable.Sort(declinedTable.Columns[0], ListSortDirection.Ascending);
                declinedTable.Invalidate();
            }

        }

        private void RefreshReadyTable()
        {
            readyTable.Rows.Clear();

            foreach (Request request in filteredRequest)
            {
                if (request.Status != RequestStatus.Ready) continue;
                DataGridViewRow row = new DataGridViewRow();

                string status = "Ready for Claiming";

                row.Cells.Add(new DataGridViewTextBoxCell { Value = request.ReferenceNumber });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = request.FullName });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = request.StudentID });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = request.Course + "-" + request.Section });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = request.YearGraduated != null ? request.YearGraduated.Value.ToString(Utilities.DateFormat) : null });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = request.Gender });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = request.RequestType.Abv });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = request.DateClaiming != null ? request.DateClaiming.Value.ToString(Utilities.DateFormat) : null });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = request.DateClaiming != null ? request.DateClaiming.Value.ToString(Utilities.TimeFormat) : null });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = status });

                readyTable.Rows.Add(row);
                readyTable.Sort(readyTable.Columns[0], ListSortDirection.Ascending);
                readyTable.Invalidate();
            }

        }

        private void RefreshArchivedTable()
        {
            archiveTable.Rows.Clear();

            foreach (Request request in filteredRequest)
            {
                if (request.Status != RequestStatus.Archived) continue;
                DataGridViewRow row = new DataGridViewRow();

                row.Cells.Add(new DataGridViewTextBoxCell { Value = request.ReferenceNumber });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = request.FullName });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = request.StudentID });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = request.Course + "-" + request.Section });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = request.YearGraduated != null ? request.YearGraduated.Value.ToString(Utilities.DateFormat) : null });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = request.Gender });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = request.RequestType.Abv });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = request.DateClaiming != null ? request.DateClaiming.Value.ToString(Utilities.DateFormat) : null });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = request.DateClaiming != null ? request.DateClaiming.Value.ToString(Utilities.TimeFormat) : null });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = request.Status });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = Request.RequestedCount[request.StudentID].ToString() });


                archiveTable.Rows.Add(row);
                archiveTable.Sort(archiveTable.Columns[0], ListSortDirection.Ascending);
                archiveTable.Invalidate();
            }

        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            allBtn.LinkVisited = true;
            allBtn.LinkBehavior = LinkBehavior.NeverUnderline;
        }

        private void allBtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RefreshAllTable();
            tabControl.SelectedIndex = 0;
            resetLinkBtn();
            allBtn.LinkVisited = true;
            allBtn.LinkBehavior = LinkBehavior.NeverUnderline;
            selectedTable = allTable;
        }

        private void pendingBtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RefreshPendingTable();
            tabControl.SelectedIndex = 1;
            resetLinkBtn();
            pendingBtn.LinkVisited = true;
            pendingBtn.LinkBehavior = LinkBehavior.NeverUnderline;
            selectedTable = pendingTable;
        }

        private void onProcessBtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RefreshProcessingTable();
            tabControl.SelectedIndex = 2;
            resetLinkBtn();
            onProcessBtn.LinkVisited = true;
            onProcessBtn.LinkBehavior = LinkBehavior.NeverUnderline;
            selectedTable = onProcessTable;
        }

        private void declineBtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RefreshDeclinedTable();
            tabControl.SelectedIndex = 3;
            resetLinkBtn();
            declineBtn.LinkVisited = true;
            declineBtn.LinkBehavior = LinkBehavior.NeverUnderline;
            selectedTable = declinedTable;
        }

        private void readyBtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RefreshReadyTable();
            tabControl.SelectedIndex = 4;
            resetLinkBtn();
            readyBtn.LinkVisited = true;
            readyBtn.LinkBehavior = LinkBehavior.NeverUnderline;
            selectedTable = readyTable;
        }

        private void archiveBtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RefreshArchivedTable();
            tabControl.SelectedIndex = 5;
            resetLinkBtn();
            archiveBtn.LinkVisited = true;
            archiveBtn.LinkBehavior = LinkBehavior.NeverUnderline;
            selectedTable = archiveTable;
        }

        private void resetLinkBtn()
        {
            allBtn.LinkVisited = false;
            pendingBtn.LinkVisited = false;
            onProcessBtn.LinkVisited = false;
            declineBtn.LinkVisited = false;
            readyBtn.LinkVisited = false;
            archiveBtn.LinkVisited = false;

            allBtn.LinkBehavior = LinkBehavior.AlwaysUnderline;
            pendingBtn.LinkBehavior = LinkBehavior.AlwaysUnderline;
            onProcessBtn.LinkBehavior = LinkBehavior.AlwaysUnderline;
            declineBtn.LinkBehavior = LinkBehavior.AlwaysUnderline;
            readyBtn.LinkBehavior = LinkBehavior.AlwaysUnderline;
            archiveBtn.LinkBehavior = LinkBehavior.AlwaysUnderline;
        }

        private void allEditBtn_Click(object sender, EventArgs e)
        {
            Edit();
        }


        private void archiveViewBtn_Click(object sender, EventArgs e)
        {
            View();
        }

        private void CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            //if (sender is not DataGridView) return;
            //DataGridView table = (DataGridView) sender;
            //if (table.SelectedRows.Count == 0 && table.SelectedCells.Count > 0)
            //{
            //    table.Rows[selectedTable.SelectedCells[0].RowIndex].Selected = true;
            //}

            if (selectedTable is null) return;
            if (selectedTable == pendingTable && selectedTable.SelectedRows.Count == 0 && selectedTable.SelectedCells.Count > 0 && e.RowIndex >= 0 && selectedTable.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                ChangePending();
            }
            else if (selectedTable == onProcessTable && selectedTable.SelectedRows.Count == 0 && selectedTable.SelectedCells.Count > 0 && e.RowIndex >= 0 && selectedTable.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                SetDate();
            }


        }

        private void onProcessSetDateBtn_Click(object sender, EventArgs e)
        {
            SetDate();
        }

        private void declinedViewBtn_Click(object sender, EventArgs e)
        {
            View();
        }

        private void pendingUpdateBtn_Click(object sender, EventArgs e)
        {
            ChangePending();
        }

        private void ChangePending()
        {
            if (selectedTable is null) return;
            if (selectedTable.SelectedCells.Count == 0 || selectedTable.SelectedCells[0] == null)
            {
                PopupForm.Show("Please select a cell.", "Error");
                return;
            }

            DataGridViewCell cell = selectedTable.SelectedCells[0];
            string selectedReferenceNumber = selectedTable.Rows[cell.RowIndex].Cells[0].Value.ToString();
            Request selectedRequest = Request.Requests.FirstOrDefault(request => request.ReferenceNumber == selectedReferenceNumber);

            if (selectedRequest == null)
            {
                PopupForm.Show("Request not found.", "Error");
                return;
            }

            AcceptOrDecline acceptOrDecline = new AcceptOrDecline(selectedRequest);
            acceptOrDecline.ShowDialog();

            RefreshTables();
        }

        private void View()
        {
            if (selectedTable == null) return;
            if (selectedTable.SelectedCells.Count == 0 || selectedTable.SelectedCells[0] == null)
            {
                PopupForm.Show("Please select a cell.", "Error");
                return;
            }

            DataGridViewCell cell = selectedTable.SelectedCells[0];
            string selectedReferenceNumber = selectedTable.Rows[cell.RowIndex].Cells[0].Value.ToString();
            Request selectedRequest = Request.Requests.FirstOrDefault(request => request.ReferenceNumber == selectedReferenceNumber);

            if (selectedRequest == null)
            {
                PopupForm.Show("Request not found.", "Error");
                return;
            }

            ViewRequestForm viewRequestForm = new ViewRequestForm(selectedRequest);
            viewRequestForm.ShowDialog();

        }

        private void Edit()
        {
            if (selectedTable is null) return;
            if (selectedTable.SelectedCells.Count == 0 || selectedTable.SelectedCells[0] == null)
            {
                PopupForm.Show("Please select a cell.", "Error");
                return;
            }

            DataGridViewCell cell = selectedTable.SelectedCells[0];
            string selectedReferenceNumber = selectedTable.Rows[cell.RowIndex].Cells[0].Value.ToString();
            Request selectedRequest = Request.Requests.FirstOrDefault(request => request.ReferenceNumber == selectedReferenceNumber);

            if (selectedRequest == null)
            {
                PopupForm.Show("Request not found.", "Error");
                return;
            }

            EditRequestForm editForm = new EditRequestForm(selectedRequest);
            editForm.ShowDialog();

            RefreshTables();
        }

        private void SetDate()
        {
            if (selectedTable == null) return;
            if (selectedTable.SelectedCells.Count == 0 || selectedTable.SelectedCells[0] == null)
            {
                PopupForm.Show("Please select a cell.", "Error");
                return;
            }

            DataGridViewCell cell = selectedTable.SelectedCells[0];
            string selectedReferenceNumber = selectedTable.Rows[cell.RowIndex].Cells[0].Value.ToString();
            Request selectedRequest = Request.Requests.FirstOrDefault(request => request.ReferenceNumber == selectedReferenceNumber);

            if (selectedRequest == null)
            {
                PopupForm.Show("Request not found.", "Error");
                return;
            }

            SetDatePopup dateSelector = new SetDatePopup(selectedRequest);
            dateSelector.ShowDialog();

            RefreshTables();
        }

        private void search_TextChanged(object? sender, EventArgs e)
        {
            Search();
            RefreshTables();
        }

        public void Search()
        {
            filteredRequest.Clear();
            if (string.IsNullOrWhiteSpace(searchBox.Text) || searchBox.Text == searchBox.PlaceHolderText)
            {
                filteredRequest.AddRange(Request.Requests);
                return;
            }

            foreach (Request request in Request.Requests)
            {
                if (request.ReferenceNumber.Contains(searchBox.Text) || request.FullName.Contains(searchBox.Text))
                {
                    filteredRequest.Add(request);
                }
            }
        }

        public void Delete()
        {
            if (selectedTable == null) return;
            if (selectedTable.SelectedCells.Count == 0 || selectedTable.SelectedCells[0] == null)
            {
                PopupForm.Show("Please select a cell.", "Error");
                return;
            }

            DataGridViewCell cell = selectedTable.SelectedCells[0];
            string selectedReferenceNumber = selectedTable.Rows[cell.RowIndex].Cells[0].Value.ToString();
            Request selectedRequest = Request.Requests.FirstOrDefault(request => request.ReferenceNumber == selectedReferenceNumber);

            if (selectedRequest == null)
            {
                PopupForm.Show("Request not found.", "Error");
                return;
            }

            DialogResult result = PopupForm.Show("Are you sure you want to delete this row?", "Delete", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                selectedRequest.Delete();
                RefreshTables();
                PopupForm.Show("Deleting Row Successful", "Success");
            }
        }

        private void importExcelBtn_Click(object sender, EventArgs e)
        {
            if (Utilities.AddDataFromExcel())
            {
                RefreshAllTable();
                this.Invalidate();
                PopupForm.Show("Data successfully inserted from excel datasheet", "Success");

                searchBox.innerTextBox.Text = "";
                searchBox.innerTextBox.Text = "Search";
                searchBox.innerTextBox.ForeColor = Color.Gray;

                RefreshTables();
            }
        }

        private void allDeleteBtn_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void pendingDeleteBtn_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void processingDeleteBtn_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void declineDeleteBtn_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void readyDeleteBtn_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void archivedDeleteBtn_Click(object sender, EventArgs e)
        {
            Delete();
        }
    }
}
