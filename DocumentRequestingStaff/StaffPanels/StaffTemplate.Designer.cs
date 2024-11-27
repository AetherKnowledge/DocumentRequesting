namespace DocumentRequesting.StaffPanels
{
    partial class StaffTemplate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffTemplate));
            topPanel = new Panel();
            adminBtnPanel = new Panel();
            adminBtn = new CustomControls.RoundedButton();
            userBtnPanel = new Panel();
            userBtn = new CustomControls.RoundedButton();
            topBarLowerBorder = new Panel();
            topBarUpperBorder = new Panel();
            topMainPanel = new Panel();
            iconPBox = new PictureBox();
            mainPanel = new Panel();
            sidePanel = new Panel();
            homeBtn = new CustomControls.RoundedButton();
            notificationBtn = new CustomControls.RoundedButton();
            iconPanel = new Panel();
            sideBarLowerBorder = new Panel();
            sideBarUpperBorder = new Panel();
            topPanel.SuspendLayout();
            adminBtnPanel.SuspendLayout();
            userBtnPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPBox).BeginInit();
            sidePanel.SuspendLayout();
            iconPanel.SuspendLayout();
            SuspendLayout();
            // 
            // topPanel
            // 
            topPanel.BackColor = Color.White;
            topPanel.Controls.Add(adminBtnPanel);
            topPanel.Controls.Add(userBtnPanel);
            topPanel.Controls.Add(topBarLowerBorder);
            topPanel.Controls.Add(topBarUpperBorder);
            topPanel.Controls.Add(topMainPanel);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(145, 24);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(1134, 74);
            topPanel.TabIndex = 3;
            // 
            // adminBtnPanel
            // 
            adminBtnPanel.Controls.Add(adminBtn);
            adminBtnPanel.Dock = DockStyle.Right;
            adminBtnPanel.Location = new Point(940, 1);
            adminBtnPanel.Name = "adminBtnPanel";
            adminBtnPanel.Size = new Size(97, 72);
            adminBtnPanel.TabIndex = 8;
            // 
            // adminBtn
            // 
            adminBtn.BackColor = Color.White;
            adminBtn.BorderColor = Color.Black;
            adminBtn.BorderRadius = 0;
            adminBtn.BorderThickness = 0;
            adminBtn.ButtonColor = Color.White;
            adminBtn.Dock = DockStyle.Fill;
            adminBtn.FlatAppearance.BorderSize = 0;
            adminBtn.FlatStyle = FlatStyle.Flat;
            adminBtn.HoverColor = Color.Empty;
            adminBtn.IconLocation = CustomControls.RoundedButton.ImageLocation.Center;
            adminBtn.Image = DocumentRequestingStaff.Properties.Resources.admin1;
            adminBtn.ImageSize = new Size(55, 55);
            adminBtn.Location = new Point(0, 0);
            adminBtn.Name = "adminBtn";
            adminBtn.PressedColor = Color.Empty;
            adminBtn.Size = new Size(97, 72);
            adminBtn.TabIndex = 4;
            adminBtn.UseVisualStyleBackColor = false;
            adminBtn.Click += adminBtn_Click;
            // 
            // userBtnPanel
            // 
            userBtnPanel.Controls.Add(userBtn);
            userBtnPanel.Dock = DockStyle.Right;
            userBtnPanel.Location = new Point(1037, 1);
            userBtnPanel.Name = "userBtnPanel";
            userBtnPanel.Size = new Size(97, 72);
            userBtnPanel.TabIndex = 5;
            // 
            // userBtn
            // 
            userBtn.BackColor = Color.White;
            userBtn.BorderColor = Color.Black;
            userBtn.BorderRadius = 0;
            userBtn.BorderThickness = 0;
            userBtn.ButtonColor = Color.White;
            userBtn.Dock = DockStyle.Fill;
            userBtn.FlatAppearance.BorderSize = 0;
            userBtn.FlatStyle = FlatStyle.Flat;
            userBtn.HoverColor = Color.Empty;
            userBtn.IconLocation = CustomControls.RoundedButton.ImageLocation.Center;
            userBtn.Image = DocumentRequestingStaff.Properties.Resources.Picture11;
            userBtn.ImageSize = new Size(55, 55);
            userBtn.Location = new Point(0, 0);
            userBtn.Name = "userBtn";
            userBtn.PressedColor = Color.Empty;
            userBtn.Size = new Size(97, 72);
            userBtn.TabIndex = 4;
            userBtn.UseVisualStyleBackColor = false;
            // 
            // topBarLowerBorder
            // 
            topBarLowerBorder.BackColor = Color.Black;
            topBarLowerBorder.Dock = DockStyle.Top;
            topBarLowerBorder.Location = new Point(0, 0);
            topBarLowerBorder.Name = "topBarLowerBorder";
            topBarLowerBorder.Size = new Size(1134, 1);
            topBarLowerBorder.TabIndex = 7;
            // 
            // topBarUpperBorder
            // 
            topBarUpperBorder.BackColor = Color.Black;
            topBarUpperBorder.Dock = DockStyle.Bottom;
            topBarUpperBorder.Location = new Point(0, 73);
            topBarUpperBorder.Name = "topBarUpperBorder";
            topBarUpperBorder.Size = new Size(1134, 1);
            topBarUpperBorder.TabIndex = 6;
            // 
            // topMainPanel
            // 
            topMainPanel.Dock = DockStyle.Fill;
            topMainPanel.Location = new Point(0, 0);
            topMainPanel.Name = "topMainPanel";
            topMainPanel.Size = new Size(1134, 74);
            topMainPanel.TabIndex = 3;
            // 
            // iconPBox
            // 
            iconPBox.Image = DocumentRequestingStaff.Properties.Resources.Picture1;
            iconPBox.Location = new Point(16, -10);
            iconPBox.Name = "iconPBox";
            iconPBox.Size = new Size(110, 94);
            iconPBox.SizeMode = PictureBoxSizeMode.StretchImage;
            iconPBox.TabIndex = 0;
            iconPBox.TabStop = false;
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.White;
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(145, 98);
            mainPanel.Name = "mainPanel";
            mainPanel.Padding = new Padding(100, 10, 100, 10);
            mainPanel.Size = new Size(1134, 621);
            mainPanel.TabIndex = 4;
            // 
            // sidePanel
            // 
            sidePanel.BackColor = Color.FromArgb(208, 240, 192);
            sidePanel.Controls.Add(homeBtn);
            sidePanel.Controls.Add(notificationBtn);
            sidePanel.Controls.Add(iconPanel);
            sidePanel.Dock = DockStyle.Left;
            sidePanel.Location = new Point(1, 24);
            sidePanel.Name = "sidePanel";
            sidePanel.Size = new Size(144, 695);
            sidePanel.TabIndex = 0;
            // 
            // homeBtn
            // 
            homeBtn.BorderColor = Color.FromArgb(68, 114, 196);
            homeBtn.BorderRadius = 20;
            homeBtn.BorderThickness = 1;
            homeBtn.ButtonColor = Color.FromArgb(208, 240, 192);
            homeBtn.Enabled = false;
            homeBtn.FlatAppearance.BorderSize = 0;
            homeBtn.FlatStyle = FlatStyle.Flat;
            homeBtn.HoverColor = Color.FromArgb(145, 168, 134);
            homeBtn.IconLocation = CustomControls.RoundedButton.ImageLocation.Center;
            homeBtn.Image = DocumentRequestingStaff.Properties.Resources.home_icon_silhouette_blue;
            homeBtn.ImageSize = new Size(40, 40);
            homeBtn.Location = new Point(16, 178);
            homeBtn.Name = "homeBtn";
            homeBtn.PressedColor = Color.FromArgb(101, 117, 93);
            homeBtn.Size = new Size(110, 110);
            homeBtn.TabIndex = 5;
            homeBtn.UseVisualStyleBackColor = true;
            // 
            // notificationBtn
            // 
            notificationBtn.BorderColor = Color.Black;
            notificationBtn.BorderRadius = 20;
            notificationBtn.BorderThickness = 0;
            notificationBtn.ButtonColor = Color.FromArgb(208, 240, 192);
            notificationBtn.FlatAppearance.BorderSize = 0;
            notificationBtn.FlatStyle = FlatStyle.Flat;
            notificationBtn.HoverColor = Color.FromArgb(145, 168, 134);
            notificationBtn.IconLocation = CustomControls.RoundedButton.ImageLocation.Center;
            notificationBtn.Image = DocumentRequestingStaff.Properties.Resources.bell;
            notificationBtn.ImageSize = new Size(40, 40);
            notificationBtn.Location = new Point(16, 471);
            notificationBtn.Name = "notificationBtn";
            notificationBtn.PressedColor = Color.FromArgb(101, 117, 93);
            notificationBtn.Size = new Size(110, 110);
            notificationBtn.TabIndex = 4;
            notificationBtn.UseVisualStyleBackColor = true;
            // 
            // iconPanel
            // 
            iconPanel.Controls.Add(sideBarLowerBorder);
            iconPanel.Controls.Add(sideBarUpperBorder);
            iconPanel.Controls.Add(iconPBox);
            iconPanel.Dock = DockStyle.Top;
            iconPanel.Location = new Point(0, 0);
            iconPanel.Name = "iconPanel";
            iconPanel.Size = new Size(144, 74);
            iconPanel.TabIndex = 1;
            // 
            // sideBarLowerBorder
            // 
            sideBarLowerBorder.BackColor = Color.Black;
            sideBarLowerBorder.Dock = DockStyle.Bottom;
            sideBarLowerBorder.Location = new Point(0, 73);
            sideBarLowerBorder.Name = "sideBarLowerBorder";
            sideBarLowerBorder.Size = new Size(144, 1);
            sideBarLowerBorder.TabIndex = 0;
            // 
            // sideBarUpperBorder
            // 
            sideBarUpperBorder.BackColor = Color.Black;
            sideBarUpperBorder.Dock = DockStyle.Top;
            sideBarUpperBorder.Location = new Point(0, 0);
            sideBarUpperBorder.Name = "sideBarUpperBorder";
            sideBarUpperBorder.Size = new Size(144, 1);
            sideBarUpperBorder.TabIndex = 1;
            // 
            // StaffTemplate
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1280, 720);
            Controls.Add(mainPanel);
            Controls.Add(topPanel);
            Controls.Add(sidePanel);
            FormStyle = FormStyles.ActionBar_None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1280, 720);
            Name = "StaffTemplate";
            Padding = new Padding(1, 24, 1, 1);
            Text = "StaffTemplate";
            topPanel.ResumeLayout(false);
            adminBtnPanel.ResumeLayout(false);
            userBtnPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconPBox).EndInit();
            sidePanel.ResumeLayout(false);
            iconPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel topPanel;
        protected Panel topMainPanel;
        private PictureBox iconPBox;
        protected Panel mainPanel;
        private Panel sidePanel;
        private Panel iconPanel;
        private Panel topBarLowerBorder;
        private Panel topBarUpperBorder;
        private Panel sideBarUpperBorder;
        private Panel sideBarLowerBorder;
        protected CustomControls.RoundedButton userBtn;
        public CustomControls.RoundedButton homeBtn;
        public CustomControls.RoundedButton notificationBtn;
        private Panel adminBtnPanel;
        protected CustomControls.RoundedButton adminBtn;
        protected Panel userBtnPanel;
    }
}