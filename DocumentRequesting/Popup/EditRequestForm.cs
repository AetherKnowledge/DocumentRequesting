using DocumentRequesting.Data;
using DocumentRequestingUtils.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DocumentRequesting.Popup
{
    internal partial class EditRequestForm : Form
    {
        private Request request;
        public EditRequestForm(Request request)
        {
            this.request = request;

            InitializeComponent();

            statusCBox.Items.Add(RequestStatus.Pending);
            statusCBox.Items.Add(RequestStatus.OnProcess);
            statusCBox.Items.Add(RequestStatus.Ready);
            statusCBox.Items.Add(RequestStatus.Declined);
            statusCBox.Items.Add(RequestStatus.Archived);

            foreach (DocumentType documentType in DocumentType.DocumentTypes)
            {
                typeCBox.Items.Add(documentType);
            }

            this.StartPosition = FormStartPosition.CenterParent;
            referenceNumberBox.Text = request.ReferenceNumber;
            firstNameBox.Text = request.FirstName;
            middleNameBox.Text = request.MiddleName;
            lastNameBox.Text = request.LastName;
            idNumberBox.Text = request.StudentID;
            courseBox.Text = request.Course;
            sectionBox.Text = request.Section;
            genderBox.Text = request.Gender;
            typeCBox.SelectedItem = request.RequestType;
            statusCBox.SelectedItem = request.Status;

            if ((request.Status == RequestStatus.Archived || request.Status == RequestStatus.Ready) && request.DateClaiming != null)
            {
                dateNALabel.Visible = false;
                timeNALabel.Visible = false;
                datePicker.Visible = true;
                timePicker.Visible = true;

                datePicker.Value = request.DateClaiming.Value;
                timePicker.Value = request.DateClaiming.Value;
            }
            else
            {
                dateNALabel.Visible = true;
                timeNALabel.Visible = true;
                datePicker.Visible = false;
                timePicker.Visible = false;
            }

            this.Invalidated += (o, e) => datePicker.RemoveBorder();
            this.Invalidated += (o, e) => timePicker.RemoveBorder();
        }

        private void RefreshData()
        {
            RequestStatus status = (RequestStatus) statusCBox.SelectedItem;
            if ((status == RequestStatus.Archived || status == RequestStatus.Ready))
            {
                dateNALabel.Visible = false;
                timeNALabel.Visible = false;
                datePicker.Visible = true;
                timePicker.Visible = true;
            }
            else
            {
                dateNALabel.Visible = true;
                timeNALabel.Visible = true;
                datePicker.Visible = false;
                timePicker.Visible = false;
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (User.CurrentUser == null || User.CurrentUser.Role != UserType.Admin)
            {
                PopupForm.Show("Please Log In as Admin", "Error");
                return;
            }

            string refNumber = referenceNumberBox.Text;
            string firstName = firstNameBox.Text;
            string middleName = middleNameBox.Text;
            string lastName = lastNameBox.Text;
            string idNumber = idNumberBox.Text;
            string course = courseBox.Text;
            string section = sectionBox.Text;
            RequestStatus status = (RequestStatus) statusCBox.SelectedItem;

            if (string.IsNullOrWhiteSpace(refNumber) ||
                string.IsNullOrWhiteSpace(firstName) ||
                string.IsNullOrWhiteSpace(middleName) ||
                string.IsNullOrWhiteSpace(lastName) ||
                string.IsNullOrWhiteSpace(idNumber) ||
                string.IsNullOrWhiteSpace(course) ||
                string.IsNullOrWhiteSpace(section) ||
                refNumber == referenceNumberBox.PlaceHolderText ||
                firstName == firstNameBox.PlaceHolderText ||
                middleName == middleNameBox.PlaceHolderText ||
                lastName == lastNameBox.PlaceHolderText ||
                idNumber == idNumberBox.PlaceHolderText ||
                course == courseBox.PlaceHolderText ||
                section == sectionBox.PlaceHolderText ||
                statusCBox.SelectedItem == null)
            {
                PopupForm.Show("Please fill in all fields.", "Missing Information");
                return;
            }

            DateTime? dateClaiming = null;
            if (status == RequestStatus.Archived || status == RequestStatus.Ready)
            {
                TimeSpan timeClaiming = timePicker.Value.TimeOfDay;
                dateClaiming = datePicker.Value.Date.Add(timeClaiming);
            }

            if (dateClaiming != null && dateClaiming <= DateTime.Now) status = RequestStatus.Archived;

            DocumentType type = (DocumentType) typeCBox.SelectedItem;
            Request newRequest = (Request) request.Clone();
            newRequest.ReferenceNumber = refNumber;
            newRequest.FirstName = firstName;
            newRequest.MiddleName = middleName;
            newRequest.LastName = lastName;
            newRequest.StudentID = idNumber;
            newRequest.Section = section;
            newRequest.Course = course;
            newRequest.Section = section;
            newRequest.RequestType = type;
            newRequest.Status = status;
            newRequest.DateClaiming = dateClaiming;

            request.Update(newRequest, User.CurrentUser);
            PopupForm.Show("Updating document successful", "Success");

            this.Close();
            OpenPanels.adminPanel.Show();
        }
    }
}
