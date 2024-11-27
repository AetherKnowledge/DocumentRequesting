using DocumentRequesting.Data;
using DocumentRequesting.Popup;
using DocumentRequesting.UserPanels;
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

        }

        public new void Show()
        {
            Utilities.AdminPanel = null;

            base.Show();
            User.ResetCurrentUser();
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
        }

        private void imageBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            OpenPanels.pickDocumentPanel.Show();
        }
    }
}
