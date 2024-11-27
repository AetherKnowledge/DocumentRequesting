using DocumentRequesting.Data;
using DocumentRequesting.Popup;
using DocumentRequestingUtils.Data;
using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DocumentRequesting.StaffPanels
{
    public partial class StaffHome : StaffTemplate
    {
        private readonly List<Request> filteredRequest = new List<Request>();
        public StaffHome()
        {
            InitializeComponent();

            searchBox.innerTextBox.TextChanged += search_TextChanged;
            filteredRequest.AddRange(Request.Requests);
        }

        public new void Show()
        {
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

#pragma warning disable CA1416 // Validate platform compatibility
                row.Cells.Add(new DataGridViewTextBoxCell { Value = request.ReferenceNumber });
#pragma warning restore CA1416 // Validate platform compatibility
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
                row.Cells.Add(new DataGridViewTextBoxCell { Value = request.Status });

                pendingTable.Rows.Add(row);
            }

        }

        private void RefreshProcessingTable()
        {
            onProcessTable.Rows.Clear();

            foreach (Request request in filteredRequest)
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
                row.Cells.Add(new DataGridViewTextBoxCell { Value = request.DateClaiming != null ? request.DateClaiming.Value.ToString(Utilities.DateFormat) : null });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = request.DateClaiming != null ? request.DateClaiming.Value.ToString(Utilities.TimeFormat) : null });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = status });

                onProcessTable.Rows.Add(row);
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
                row.Cells.Add(new DataGridViewButtonCell { Value = "Print", FlatStyle = FlatStyle.Flat });

                readyTable.Rows.Add(row);
            }

        }

        private void RefreshArchivedTable()
        {
            archivedTable.Rows.Clear();

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

                archivedTable.Rows.Add(row);
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
            materialTabControl1.SelectedIndex = 0;
            resetLinkBtn();
            allBtn.LinkVisited = true;
            allBtn.LinkBehavior = LinkBehavior.NeverUnderline;
        }

        private void pendingBtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RefreshPendingTable();
            materialTabControl1.SelectedIndex = 1;
            resetLinkBtn();
            pendingBtn.LinkVisited = true;
            pendingBtn.LinkBehavior = LinkBehavior.NeverUnderline;
        }

        private void onProcessBtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RefreshProcessingTable();
            materialTabControl1.SelectedIndex = 2;
            resetLinkBtn();
            onProcessBtn.LinkVisited = true;
            onProcessBtn.LinkBehavior = LinkBehavior.NeverUnderline;
        }

        private void declineBtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RefreshDeclinedTable();
            materialTabControl1.SelectedIndex = 3;
            resetLinkBtn();
            declineBtn.LinkVisited = true;
            declineBtn.LinkBehavior = LinkBehavior.NeverUnderline;
        }

        private void readyBtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RefreshReadyTable();
            materialTabControl1.SelectedIndex = 4;
            resetLinkBtn();
            readyBtn.LinkVisited = true;
            readyBtn.LinkBehavior = LinkBehavior.NeverUnderline;
        }

        private void archiveBtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RefreshArchivedTable();
            materialTabControl1.SelectedIndex = 5;
            resetLinkBtn();
            archiveBtn.LinkVisited = true;
            archiveBtn.LinkBehavior = LinkBehavior.NeverUnderline;
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

        private void notificationBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            OpenPanels.notificationPanel.Show();
        }

        private void userBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            OpenPanels.staffInfo.Show();
        }

        private void readyTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (readyTable.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0) // Ensure it's not the header row
                {
                    int rowIndex = e.RowIndex;
                    string referenceNumber = readyTable.Rows[e.RowIndex].Cells[0].Value?.ToString() ?? string.Empty;
                    Request request = Request.Requests.First(request => request.ReferenceNumber == referenceNumber);
                    Utilities.Print(request);

                    RefreshReadyTable();
                }
            }
            catch (Exception ex)
            {
                PopupForm.Show(ex.Message, "Error");
            }
        }
    }
}
