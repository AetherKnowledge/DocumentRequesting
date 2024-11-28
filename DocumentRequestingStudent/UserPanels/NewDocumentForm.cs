using DocumentRequesting.Data;
using DocumentRequesting.Popup;
using DocumentRequesting.UserPanels;
using DocumentRequestingUtils.Data;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace DocumentRequesting.RequestFormPanels
{
    public partial class NewDocumentForm : MaterialForm
    {
        public NewDocumentForm()
        {
            InitializeComponent();
            this.FormClosing += Utilities.MyFormClosing;

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = false;
            materialSkinManager.AddFormToManage(this);

            Utilities.InitializeTextBoxWithPlaceholder(usedBox);
            Utilities.InitializeTextBoxWithPlaceholder(firstNameBox);
            Utilities.InitializeTextBoxWithPlaceholder(midNameBox);
            Utilities.InitializeTextBoxWithPlaceholder(lastNameBox);
            Utilities.InitializeTextBoxWithPlaceholder(genderBox);
            Utilities.InitializeTextBoxWithPlaceholder(mobileNumBox);
            Utilities.InitializeTextBoxWithPlaceholder(emailBox);
            Utilities.InitializeTextBoxWithPlaceholder(addressBox);
            Utilities.InitializeTextBoxWithPlaceholder(courseBox);
            Utilities.InitializeTextBoxWithPlaceholder(sectionBox);
            Utilities.InitializeTextBoxWithPlaceholder(studentIDBox);

            RefreshItems();
        }

        public void Show(DocumentType type)
        {
            RefreshItems();
            Clear();

            base.Show();
            typeCBox.SelectedItem = type;

            this.Size = Utilities.size;
            this.Location = Utilities.location;
            this.WindowState = Utilities.windowState;
        }

        public new void Show()
        {
            RefreshItems();
            Clear();
            base.Show();
            this.Size = Utilities.size;
            this.Location = Utilities.location;
            this.WindowState = Utilities.windowState;
        }

        public new void Hide()
        {
            Utilities.size = this.Size;
            Utilities.location = this.Location;
            Utilities.windowState = this.WindowState;
            base.Hide();

        }

        private void RefreshItems()
        {

            typeCBox.Items.Clear();
            foreach (DocumentType documentType in DocumentType.DocumentTypes)
            {
                typeCBox.Items.Add(documentType);
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            SkinManager.ColorScheme = new MaterialSkin.ColorScheme(Color.FromArgb(128, 175, 129), Color.FromArgb(128, 175, 129), Color.FromArgb(249, 248, 235), Color.Black, MaterialSkin.TextShade.WHITE);
            this.Size = new Size(1280, 720);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Color borderColor = Color.Black; // Change to your preferred color
            int borderThickness = 2;

            // Draw the border
            using (Pen pen = new Pen(borderColor, borderThickness))
            {
                Rectangle rect = new Rectangle(0, 0, this.ClientSize.Width, this.ClientSize.Height);
                e.Graphics.DrawRectangle(pen, rect);
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Utilities.size = this.Size;
            Utilities.location = this.Location;
            Utilities.windowState = this.WindowState;
            if (Utilities.PreviousPanel != null) Utilities.PreviousPanel.Show();
            else
            {
                this.Hide();
                OpenPanels.pickDocumentPanel.Show();
            }
            
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            
            Clear();
        }

        private void Clear()
        {
            typeCBox.Text = "";
            studentIDBox.Text = "STUDENT ID";
            usedBox.Text = "WHERE WILL BE USED";
            firstNameBox.Text = "FIRST NAME";
            midNameBox.Text = "MIDDLE NAME";
            lastNameBox.Text = "LAST NAME";
            genderBox.Text = "GENDER";
            emailBox.Text = "EMAIL";
            addressBox.Text = "ADDRESS";
            courseBox.Text = "COURSE";
            sectionBox.Text = "SECTION";
            mobileNumBox.Text = "MOBILE NUMBER";

            studentIDBox.ForeColor = Color.Gray;
            usedBox.ForeColor = Color.Gray;
            firstNameBox.ForeColor = Color.Gray;
            midNameBox.ForeColor = Color.Gray;
            lastNameBox.ForeColor = Color.Gray;
            genderBox.ForeColor = Color.Gray;
            emailBox.ForeColor = Color.Gray;
            addressBox.ForeColor = Color.Gray;
            courseBox.ForeColor = Color.Gray;
            sectionBox.ForeColor = Color.Gray;
            mobileNumBox.ForeColor = Color.Gray;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            
            string used = usedBox.Text;
            string firstName = firstNameBox.Text;
            string midName = midNameBox.Text;
            string lastName = lastNameBox.Text;
            string studentID = studentIDBox.Text;
            string mobileNumber = mobileNumBox.Text;
            string gender = genderBox.Text;
            string email = emailBox.Text;
            string address = addressBox.Text;
            string course = courseBox.Text;
            string section = sectionBox.Text;
            DateTime birthDate = birthDatePicker.Value;

            if (typeCBox.SelectedItem == null ||
                string.IsNullOrWhiteSpace(used) ||
                string.IsNullOrWhiteSpace(firstName) ||
                string.IsNullOrWhiteSpace(midName) ||
                string.IsNullOrWhiteSpace(lastName) ||
                string.IsNullOrWhiteSpace(studentID) ||
                string.IsNullOrWhiteSpace(mobileNumber) ||
                string.IsNullOrWhiteSpace(gender) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(address) ||
                string.IsNullOrWhiteSpace(course) ||
                string.IsNullOrWhiteSpace(section) ||
                used == "WHERE WILL BE USED" ||
                firstName == "FIRST NAME" ||
                midName == "MIDDLE NAME" ||
                lastName == "LAST NAME" ||
                studentID == "STUDENT ID" ||
                mobileNumber == "MOBILE NUMBER" ||
                gender == "GENDER" ||
                email == "EMAIL" ||
                address == "ADDRESS" ||
                course == "COURSE" ||
                section == "SECTION" ||
                birthDate == DateTime.MinValue) // Optional: Validate birthDate further
            {
                PopupForm.Show("Please fill in all fields.", "Missing Information");
                return;
            }

            DocumentType type = (DocumentType)typeCBox.SelectedItem;
            Request request = new Request(type,null,RequestStatus.Pending,firstName,midName,lastName,studentID,birthDate,gender,mobileNumber,email,address,course,section,used,null);


            PopupForm popup = new PopupForm("Your request is submitted successfully.", "Success");
            popup.ShowDialog();

            this.Activate();
            this.Invalidate();
            saveBtn.Reset();

            this.Hide();
            OpenPanels.pickDocumentPanel.Show();
        }
    }
}
