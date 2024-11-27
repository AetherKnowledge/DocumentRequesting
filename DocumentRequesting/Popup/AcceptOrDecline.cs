using DocumentRequesting.Data;
using DocumentRequesting.Popup;
using DocumentRequestingUtils.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DocumentRequestingAdmin.Popup
{
    public partial class AcceptOrDecline : Form
    {

        private Request request;
        public AcceptOrDecline(Request request)
        {
            InitializeComponent();
            this.request = request;
        }

        private void acceptBtn_Click(object sender, EventArgs e)
        {
            if (User.CurrentUser == null || User.CurrentUser.Role != UserType.Admin)
            {
                PopupForm.Show("Please Log In as Admin", "Error");
                return;
            }

            Request newRequest = (Request)request.Clone();
            newRequest.Status = RequestStatus.OnProcess;

            request.Update(newRequest, User.CurrentUser);

            PopupForm.Show("Accepting Document Successful", "Success");
            this.Close();
        }

        private void DeclineBtn_Click(object sender, EventArgs e)
        {
            if (User.CurrentUser == null || User.CurrentUser.Role != UserType.Admin)
            {
                PopupForm.Show("Please Log In as Admin", "Error");
                return;
            }

            Request newRequest = (Request)request.Clone();
            newRequest.Status = RequestStatus.Declined;
            request.Update(newRequest, User.CurrentUser);

            PopupForm.Show("Declining Document Successful", "Success");
            this.Close();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
