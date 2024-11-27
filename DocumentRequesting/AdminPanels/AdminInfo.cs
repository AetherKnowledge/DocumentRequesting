using DocumentRequesting;
using DocumentRequesting.AdminPanels;
using DocumentRequesting.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DocumentRequestingAdmin.AdminPanels
{
    public partial class AdminInfo : AdminTemplate
    {
        public AdminInfo()
        {
            InitializeComponent();

            if (User.CurrentUser == null) return;
            nameLabel.Text = User.CurrentUser.FullName;
            emailLabel.Text = User.CurrentUser.Email;
            contactLabel.Text = User.CurrentUser.ContactNumber;
            usernameLabel.Text = User.CurrentUser.Username;
        }

        public new void Show()
        {
            base.Show();

            if (User.CurrentUser == null) return;
            nameLabel.Text = User.CurrentUser.FullName;
            emailLabel.Text = User.CurrentUser.Email;
            contactLabel.Text = User.CurrentUser.ContactNumber;
            usernameLabel.Text = User.CurrentUser.Username;
        }

        private void userBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            OpenPanels.adminPanel.Show();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            OpenPanels.loginPanel.Show();
        }
    }
}
