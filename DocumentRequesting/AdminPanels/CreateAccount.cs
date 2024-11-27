using DocumentRequesting;
using DocumentRequesting.Data;
using DocumentRequesting.Popup;
using MaterialSkin.Controls;

namespace DocumentRequestingAdmin.AdminPanels
{
    public partial class CreateAccount : MaterialForm
    {
        public CreateAccount()
        {
            InitializeComponent();
            this.FormClosing += Utilities.MyFormClosing;

            roleBox.Items.Add(UserType.Admin);
            roleBox.Items.Add(UserType.Staff);
        }

        public new void Show()
        {
            base.Show();
            this.Size = Utilities.size;
            this.Location = Utilities.location;
            this.WindowState = Utilities.windowState;
        }

        public new void Hide()
        {
            Utilities.PreviousPanel = this;
            Utilities.size = this.Size;
            Utilities.location = this.Location;
            Utilities.windowState = this.WindowState;
            base.Hide();

            firstNameBox.Text = firstNameBox.PlaceHolderText;
            midNameBox.Text = midNameBox.PlaceHolderText;
            lastNameBox.Text = lastNameBox.PlaceHolderText;
            emailBox.Text = emailBox.PlaceHolderText;
            mobileNumBox.Text = mobileNumBox.PlaceHolderText;
            usernameBox.Text = usernameBox.PlaceHolderText;
            passwordBox.Text = passwordBox.PlaceHolderText;

            firstNameBox.ForeColor = Color.Gray;
            midNameBox.ForeColor = Color.Gray;
            lastNameBox.ForeColor = Color.Gray;
            emailBox.ForeColor = Color.Gray;
            mobileNumBox.ForeColor = Color.Gray;
            usernameBox.ForeColor = Color.Gray;
            passwordBox.ForeColor = Color.Gray;
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

        private void saveBtn_Click(object sender, EventArgs e)
        {

            try 
            {
                string fName = firstNameBox.Text;
                string mName = midNameBox.Text;
                string lName = lastNameBox.Text;
                string email = emailBox.Text;
                string contactNum = mobileNumBox.Text;
                string username = usernameBox.Text;
                string password = passwordBox.Text;
                string roleStr = roleBox.Text;

                if (string.IsNullOrWhiteSpace(fName) ||
                    string.IsNullOrWhiteSpace(mName) ||
                    string.IsNullOrWhiteSpace(lName) ||
                    string.IsNullOrWhiteSpace(email) ||
                    string.IsNullOrWhiteSpace(contactNum) ||
                    string.IsNullOrWhiteSpace(username) ||
                    string.IsNullOrWhiteSpace(password) ||
                    string.IsNullOrWhiteSpace(roleStr) ||
                    fName == firstNameBox.PlaceHolderText ||
                    mName == midNameBox.PlaceHolderText ||
                    lName == lastNameBox.PlaceHolderText ||
                    email == emailBox.PlaceHolderText ||
                    contactNum == mobileNumBox.PlaceHolderText ||
                    username == usernameBox.PlaceHolderText ||
                    password == passwordBox.PlaceHolderText)
                {
                    PopupForm.Show("Please fill in all fields.", "Missing Information");
                    return;
                }

                if (!Utilities.IsPasswordSufficient(password))
                {
                    PopupForm.Show("Please use a better password.", "Invalid Password");
                    return;
                }
               
                if (User.Exist(username, email))
                {
                    PopupForm.Show("User with the same email or username already exists.", "Invalid Password");
                    return;
                }

                UserType role = (UserType)(roleBox.SelectedItem ?? throw new Exception("Invalid Role"));
                User user = new User(fName, mName, lName, email, contactNum, username, role, password);
            
                if (role == UserType.Admin) PopupForm.Show("Admin account successfuly made.", "Success");
                else PopupForm.Show("Staff account successfuly made.", "Success");

                this.Hide();
                OpenPanels.loginPanel.Show();

                firstNameBox.Text = firstNameBox.PlaceHolderText;
                midNameBox.Text = midNameBox.PlaceHolderText;
                lastNameBox.Text = lastNameBox.PlaceHolderText;
                emailBox.Text = emailBox.PlaceHolderText;
                mobileNumBox.Text = mobileNumBox.PlaceHolderText;
                usernameBox.Text = usernameBox.PlaceHolderText;
                passwordBox.Text = passwordBox.PlaceHolderText;

                firstNameBox.ForeColor = Color.Gray;
                midNameBox.ForeColor = Color.Gray;
                lastNameBox.ForeColor = Color.Gray;
                emailBox.ForeColor = Color.Gray;
                mobileNumBox.ForeColor = Color.Gray;
                usernameBox.ForeColor = Color.Gray;
                passwordBox.ForeColor = Color.Gray;
            }
            catch (Exception ex)
            {
                PopupForm.Show(ex.Message, "Error");
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (Utilities.PreviousPanel != null) Utilities.PreviousPanel.Show();
            else OpenPanels.loginPanel.Show();
        }

        private void showPassBox_CheckedChanged(object sender, EventArgs e)
        {
            if (showPassBox.Checked) passwordBox.UseSystemPasswordChar = false;
            else passwordBox.UseSystemPasswordChar = true;
        }
    }
}

