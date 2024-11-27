namespace DocumentRequestingStaff.StaffPanels
{
    partial class StaffNotificationPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffNotificationPanel));
            scrollPanel = new Panel();
            scrollBar = new DocumentRequestingUtils.CustomControls.CustomScrollBar();
            notificationPanel = new Panel();
            mainPanel.SuspendLayout();
            userBtnPanel.SuspendLayout();
            scrollPanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.Controls.Add(scrollPanel);
            mainPanel.Controls.Add(notificationPanel);
            mainPanel.Padding = new Padding(10, 10, 0, 0);
            // 
            // userBtn
            // 
            userBtn.FlatAppearance.BorderSize = 0;
            userBtn.Click += userBtn_Click;
            // 
            // homeBtn
            // 
            homeBtn.BorderColor = Color.Black;
            homeBtn.BorderThickness = 0;
            homeBtn.Enabled = true;
            homeBtn.FlatAppearance.BorderSize = 0;
            homeBtn.Image = Properties.Resources.home_icon_silhouette;
            homeBtn.Click += homeBtn_Click;
            // 
            // notificationBtn
            // 
            notificationBtn.BorderColor = Color.FromArgb(68, 114, 196);
            notificationBtn.BorderThickness = 1;
            notificationBtn.Enabled = false;
            notificationBtn.FlatAppearance.BorderSize = 0;
            notificationBtn.Image = Properties.Resources.bell_blue;
            // 
            // adminBtn
            // 
            adminBtn.FlatAppearance.BorderSize = 0;
            // 
            // scrollPanel
            // 
            scrollPanel.Controls.Add(scrollBar);
            scrollPanel.Dock = DockStyle.Right;
            scrollPanel.Location = new Point(1084, 10);
            scrollPanel.Name = "scrollPanel";
            scrollPanel.Padding = new Padding(10, 10, 15, 10);
            scrollPanel.Size = new Size(50, 611);
            scrollPanel.TabIndex = 1;
            // 
            // scrollBar
            // 
            scrollBar.Dock = DockStyle.Right;
            scrollBar.Location = new Point(7, 10);
            scrollBar.Maximum = 80;
            scrollBar.Minimum = 0;
            scrollBar.Name = "scrollBar";
            scrollBar.Size = new Size(28, 591);
            scrollBar.TabIndex = 1;
            scrollBar.ThumbColor = Color.FromArgb(128, 175, 129);
            scrollBar.ThumbSize = 100;
            scrollBar.TrackColor = Color.LightGray;
            scrollBar.Value = 0;
            // 
            // notificationPanel
            // 
            notificationPanel.AutoScroll = true;
            notificationPanel.Dock = DockStyle.Fill;
            notificationPanel.Location = new Point(10, 10);
            notificationPanel.Name = "notificationPanel";
            notificationPanel.Padding = new Padding(0, 0, 35, 10);
            notificationPanel.Size = new Size(1124, 611);
            notificationPanel.TabIndex = 2;
            // 
            // StaffNotificationPanel
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1280, 720);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "StaffNotificationPanel";
            Text = "StaffNotificationPanel";
            mainPanel.ResumeLayout(false);
            userBtnPanel.ResumeLayout(false);
            scrollPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel scrollPanel;
        private DocumentRequestingUtils.CustomControls.CustomScrollBar scrollBar;
        private Panel notificationPanel;
    }
}