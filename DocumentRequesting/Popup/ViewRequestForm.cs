using DocumentRequesting.Data;
using DocumentRequestingUtils.Data;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DocumentRequesting.Popup
{
    public partial class ViewRequestForm : Form
    {
        public ViewRequestForm(Request request)
        {
            InitializeComponent();

            typeLabel.Text = request.RequestType.ToString();
            dayLabel.Text = request.DateClaiming != null ? request.DateClaiming.Value.ToString(Utilities.DateFormat) : "N/A";
            timeLabel.Text = request.DateClaiming != null ? request.DateClaiming.Value.ToString(Utilities.TimeFormat) : "N/A";
            requestedAmmountLabel.Text = Request.RequestedCount[request.StudentID].ToString();
            string status = request.Status.ToString();

            if (request.Status == RequestStatus.OnProcess) status = "On Process";
            else if (request.Status == RequestStatus.Ready) status = "Ready for Claiming";

            statusLabel.Text = status;  
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
