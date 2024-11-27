using DocumentRequesting;
using DocumentRequesting.CustomControls;
using DocumentRequesting.StaffPanels;
using DocumentRequestingUtils.CustomControls;
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

namespace DocumentRequestingStaff.StaffPanels
{
    public partial class StaffNotificationPanel : StaffTemplate
    {
        public StaffNotificationPanel()
        {
            InitializeComponent();
            RefreshData();

            scrollBar.ValueChanged += (s, e) =>
            {
                if (scrollBar.Value == notificationPanel.VerticalScroll.Value) return;
                notificationPanel.VerticalScroll.Value = scrollBar.Value;
                notificationPanel.PerformLayout(); // Recalculate layout for smooth scrolling
            };

            notificationPanel.Layout += (s, e) =>
            {
                if (scrollBar.Value != notificationPanel.VerticalScroll.Value)
                {
                    scrollBar.Value = notificationPanel.VerticalScroll.Value;
                }

                int totalScrollableHeight = notificationPanel.VerticalScroll.Maximum - notificationPanel.ClientSize.Height;
                scrollBar.Maximum = Math.Max(0, totalScrollableHeight);

                if (scrollBar.Maximum == 0 || notificationPanel.Controls.Count < 3)
                {
                    scrollPanel.Visible = false;
                    notificationPanel.Padding = new Padding(0, 0, 10, 10);
                }
                else
                {
                    scrollPanel.Visible = true;
                    notificationPanel.Padding = new Padding(0, 0, 35, 10);
                }

                float visibleRatio = (float)notificationPanel.ClientSize.Height / (notificationPanel.VerticalScroll.Maximum + notificationPanel.ClientSize.Height);
                scrollBar.ThumbSize = (int)(visibleRatio * scrollBar.Height);

            };

            notificationPanel.MouseWheel += (s, e) =>
            {
                if (scrollBar.Value != notificationPanel.VerticalScroll.Value)
                {
                    scrollBar.Value = notificationPanel.VerticalScroll.Value;
                }
            };


        }

        public new void Show()
        {
            RefreshData();
            base.Show();
        }

        public void RefreshData()
        {
            notificationPanel.Controls.Clear();
            Utilities.RefreshData();
            NotificationPanel.LoadNotifications();

            NotificationPanel.NotificationPanels.ForEach(panel => { notificationPanel.Controls.Add(panel); });
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            OpenPanels.staffHome.Show();
        }

        private void userBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            OpenPanels.staffInfo.Show();
        }
    }
}
