using static DocumentRequesting.CustomControls.CustomControlUtilities;
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
using System.Windows.Forms.VisualStyles;
using DocumentRequesting.Data;
using DocumentRequesting.Popup;
using DocumentRequesting;

namespace DocumentRequestingUtils.CustomControls
{
    public partial class NotificationPanel : UserControl
    {
        public static readonly List<NotificationPanel> NotificationPanels = new List<NotificationPanel>();
        public Notification Notification { get; set; }
        internal NotificationPanel(Notification notification)
        {
            InitializeComponent();
            this.Notification = notification;
            string status;
            if (notification.Request.Status == RequestStatus.Ready || notification.Request.Status == RequestStatus.Archived) status = "Accepted";
            else status = "Declined";

            string pronoun = notification.Request.Gender == "Male" ? "Mr." : "Ms.";
            string name = notification.Request.LastName.ToUpper() + ", " + notification.Request.FirstName.ToUpper();

            AppendStyledText(textBox, notification.User.FullName + " ", FontStyle.Regular);
            AppendStyledText(textBox, status + " ", FontStyle.Bold);
            AppendStyledText(textBox, "the request of " + pronoun + " " + name, FontStyle.Regular);

            if (notification.Request.Status != RequestStatus.Declined)
            {
                AppendStyledText(textBox, " pick up at " + notification.Request.DateClaiming.Value.ToString("MM/dd/yyyy hh:mm tt"), FontStyle.Regular);
            }

            nameLabel.Text = notification.User.FullName;
            timeLabel.Text = notification.DateAdded.ToString("MM/dd/yyyy hh:mm tt");

            //textBox.SelectAll();
            //textBox.SelectionAlignment = HorizontalAlignment.Center;
            //textBox.DeselectAll(); // Deselect text for a clean look

            CenterRichTextBoxVertically(textBox);

            this.Dock = DockStyle.Top;

            if (Notification.Request.Status == RequestStatus.Declined) printBtnPanel.Visible = false;
            else printBtnPanel.Visible = true;
        }

        private void CenterRichTextBoxVertically(RichTextBox richTextBox)
        {
            int lineCount = richTextBox.GetLineFromCharIndex(richTextBox.TextLength) + 1;
            int lineHeight = TextRenderer.MeasureText("A", richTextBox.Font).Height;

            // Calculate padding for vertical centering
            int totalTextHeight = lineCount * lineHeight;
            int topPadding = (richTextBox.ClientSize.Height - totalTextHeight) / 2;

            richTextBox.Margin = new Padding(0); // Reset margin
            richTextBox.Padding = new Padding(0, Math.Max(0, topPadding), 0, 0);
        }

        public static void LoadNotifications()
        {
            NotificationPanels.Clear();
            foreach (Notification notification in Notification.Notifications)
            {
                NotificationPanels.Add(new NotificationPanel(notification));
            }
        }

        public static void ClearNotifications()
        {
            NotificationPanels.Clear();
        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            if (User.CurrentUser == null)
            {
                PopupForm.Show("Please log in first", "Error");
                return;
            }

            Utilities.Print(Notification.Request);
        }
    }
}
