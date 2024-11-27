using DocumentRequesting.Data;
using DocumentRequesting.Popup;
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

namespace DocumentRequesting
{
    internal partial class LoginPanel : MaterialForm
    {
        public LoginPanel()
        {
            InitializeComponent();
            this.FormClosing += Utilities.MyFormClosing;

            Utilities.InitializeTextBoxWithPlaceholder(usernameBox);
            Utilities.InitializeTextBoxWithPlaceholder(passwordBox);

            if (User.Users.FirstOrDefault(user => user.Role == UserType.Admin) == null) createAccBtn.Visible = true;
            else createAccBtn.Visible = false;


        }

        public new void Show()
        {
            Utilities.AdminPanel = null;

            if (User.Users.FirstOrDefault(user => user.Role == UserType.Admin) == null) createAccBtn.Visible = true;
            else createAccBtn.Visible = false;

            usernameBox.Text = "Username";
            passwordBox.Text = "Password";
            usernameBox.ForeColor = Color.Gray;
            passwordBox.ForeColor = Color.Gray;

            base.Show();
            User.ResetCurrentUser();
            this.Size = Utilities.size;
            this.Location = Utilities.location;
            this.WindowState = Utilities.windowState;
        }

        public new void Hide()
        {
            usernameBox.Text = "Username";
            passwordBox.Text = "Password";
            usernameBox.ForeColor = Color.Gray;
            passwordBox.ForeColor = Color.Gray;

            Utilities.PreviousPanel = this;
            Utilities.size = this.Size;
            Utilities.location = this.Location;
            Utilities.windowState = this.WindowState;
            base.Hide();
        }

        private void createAccBtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            OpenPanels.createAccount.Show();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string username = usernameBox.Text;
            string password = passwordBox.Text;

            if (username == null || password == null || username == "Username" || password == "Password")
            {
                PopupForm.Show("Invalid Input", "Error");
                return;
            }

            if (!User.Login(username, password) || User.CurrentUser == null)
            {
                (new PopupForm("Invalid Credentials", "Error")).ShowDialog();
                return;
            }
            PopupForm.Show("Login Successful.", "Success");
            this.Hide();

            if (User.CurrentUser.Role == UserType.Admin) OpenPanels.adminPanel.Show();
            else if (User.CurrentUser.Role == UserType.Staff) OpenPanels.staffHome.Show();

        }

        private void showPassBox_CheckedChanged(object sender, EventArgs e)
        {
            if (showPassBox.Checked) passwordBox.UseSystemPasswordChar = false;
            else passwordBox.UseSystemPasswordChar = true;
        }
    }
}
