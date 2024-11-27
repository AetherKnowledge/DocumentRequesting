using DocumentRequesting;
using DocumentRequesting.Data;
using DocumentRequesting.StaffPanels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DocumentRequestingStaff.StaffPanels
{
    public partial class StaffInfo : StaffTemplate
    {
        public StaffInfo()
        {
            InitializeComponent();

            if (User.CurrentUser == null) return;
            nameLabel.Text = User.CurrentUser.FullName;
            emailLabel.Text = User.CurrentUser.Email;
            contactLabel.Text = User.CurrentUser.ContactNumber;
            usernameLabel.Text = User.CurrentUser.Username;

        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (Utilities.mainPanel != null) Utilities.mainPanel.Show();
            else OpenPanels.loginPanel.Show();
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            OpenPanels.staffHome.Show();
        }

        private void userBtn_Click(object sender, EventArgs e)
        {

        }

        private void notificationBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            OpenPanels.notificationPanel.Show();
        }
    }
}
