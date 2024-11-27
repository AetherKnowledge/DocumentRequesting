using DocumentRequesting.Data;
using DocumentRequesting.Popup;
using DocumentRequestingUtils.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DocumentRequestingAdmin.Popup
{
    public partial class SetDatePopup : Form
    {
        private Request request;
        public SetDatePopup(Request request)
        {
            InitializeComponent();
            this.request = request;
        }

        private void DeclineBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void acceptBtn_Click(object sender, EventArgs e)
        {
            if (User.CurrentUser == null || User.CurrentUser.Role != UserType.Admin)
            {
                PopupForm.Show("Please Log In as Admin", "Error");
                return;
            }

            DateTime? dateClaiming = null;
            TimeSpan timeClaiming = timePicker.Value.TimeOfDay;
            dateClaiming = datePicker.Value.Date.Add(timeClaiming);

            if (dateClaiming <= DateTime.Now) 
            {
                PopupForm.Show("Cannot set date below today", "Error");
                return;
            }

            Request newRequest = (Request) request.Clone();
            newRequest.DateClaiming = dateClaiming;
            newRequest.Status = RequestStatus.Ready;
            request.Update(newRequest, User.CurrentUser);

            PopupForm.Show("Setting Date Successful", "Success");
            this.Close();

        }
    }
}
