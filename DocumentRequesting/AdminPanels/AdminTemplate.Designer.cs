namespace DocumentRequesting.AdminPanels
{
    partial class AdminTemplate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminTemplate));
            bottomPanel = new Panel();
            addAccountBtn = new CustomControls.RoundedButton();
            showFormsBtn = new CustomControls.RoundedButton();
            toStaffBtn = new CustomControls.RoundedButton();
            topPanel = new Panel();
            topMainPanel = new Panel();
            userBtnPanel = new Panel();
            userBtn = new CustomControls.RoundedButton();
            iconPanel = new Panel();
            iconPBox = new PictureBox();
            mainPanel = new Panel();
            bottomPanel.SuspendLayout();
            topPanel.SuspendLayout();
            userBtnPanel.SuspendLayout();
            iconPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPBox).BeginInit();
            SuspendLayout();
            // 
            // bottomPanel
            // 
            bottomPanel.BackColor = Color.FromArgb(128, 175, 129);
            bottomPanel.Controls.Add(addAccountBtn);
            bottomPanel.Controls.Add(showFormsBtn);
            bottomPanel.Controls.Add(toStaffBtn);
            bottomPanel.Dock = DockStyle.Bottom;
            bottomPanel.Location = new Point(1, 661);
            bottomPanel.Name = "bottomPanel";
            bottomPanel.Padding = new Padding(0, 1, 0, 1);
            bottomPanel.Size = new Size(1278, 58);
            bottomPanel.TabIndex = 1;
            // 
            // addAccountBtn
            // 
            addAccountBtn.BackImageSize = new Size(0, 0);
            addAccountBtn.BorderColor = Color.Black;
            addAccountBtn.BorderRadius = 0;
            addAccountBtn.BorderThickness = 0;
            addAccountBtn.ButtonColor = Color.FromArgb(128, 175, 129);
            addAccountBtn.Dock = DockStyle.Right;
            addAccountBtn.FlatAppearance.BorderSize = 0;
            addAccountBtn.FlatStyle = FlatStyle.Flat;
            addAccountBtn.HoverColor = Color.FromArgb(89, 122, 90);
            addAccountBtn.IconLocation = CustomControls.RoundedButton.ImageLocation.Center;
            addAccountBtn.Image = DocumentRequestingAdmin.Properties.Resources.adduser;
            addAccountBtn.ImageSize = new Size(45, 45);
            addAccountBtn.Location = new Point(1044, 1);
            addAccountBtn.Name = "addAccountBtn";
            addAccountBtn.PressedColor = Color.FromArgb(62, 85, 62);
            addAccountBtn.Size = new Size(78, 56);
            addAccountBtn.TabIndex = 4;
            addAccountBtn.UseVisualStyleBackColor = true;
            addAccountBtn.Click += addAccountBtn_Click;
            // 
            // showFormsBtn
            // 
            showFormsBtn.BackImageSize = new Size(0, 0);
            showFormsBtn.BorderColor = Color.Black;
            showFormsBtn.BorderRadius = 0;
            showFormsBtn.BorderThickness = 0;
            showFormsBtn.ButtonColor = Color.FromArgb(128, 175, 129);
            showFormsBtn.Dock = DockStyle.Right;
            showFormsBtn.FlatAppearance.BorderSize = 0;
            showFormsBtn.FlatStyle = FlatStyle.Flat;
            showFormsBtn.HoverColor = Color.FromArgb(89, 122, 90);
            showFormsBtn.IconLocation = CustomControls.RoundedButton.ImageLocation.Center;
            showFormsBtn.Image = DocumentRequestingAdmin.Properties.Resources.user_edit;
            showFormsBtn.ImageSize = new Size(45, 45);
            showFormsBtn.Location = new Point(1122, 1);
            showFormsBtn.Name = "showFormsBtn";
            showFormsBtn.PressedColor = Color.FromArgb(62, 85, 62);
            showFormsBtn.Size = new Size(78, 56);
            showFormsBtn.TabIndex = 1;
            showFormsBtn.UseVisualStyleBackColor = true;
            showFormsBtn.Click += showFormsBtn_Click;
            // 
            // toStaffBtn
            // 
            toStaffBtn.BackImageSize = new Size(0, 0);
            toStaffBtn.BorderColor = Color.Black;
            toStaffBtn.BorderRadius = 0;
            toStaffBtn.BorderThickness = 0;
            toStaffBtn.ButtonColor = Color.FromArgb(128, 175, 129);
            toStaffBtn.Dock = DockStyle.Right;
            toStaffBtn.FlatAppearance.BorderSize = 0;
            toStaffBtn.FlatStyle = FlatStyle.Flat;
            toStaffBtn.HoverColor = Color.FromArgb(89, 122, 90);
            toStaffBtn.IconLocation = CustomControls.RoundedButton.ImageLocation.Center;
            toStaffBtn.Image = DocumentRequestingAdmin.Properties.Resources.staff;
            toStaffBtn.ImageSize = new Size(40, 40);
            toStaffBtn.Location = new Point(1200, 1);
            toStaffBtn.Name = "toStaffBtn";
            toStaffBtn.PressedColor = Color.FromArgb(62, 85, 62);
            toStaffBtn.Size = new Size(78, 56);
            toStaffBtn.TabIndex = 3;
            toStaffBtn.UseVisualStyleBackColor = true;
            toStaffBtn.Click += toStaffBtn_Click;
            // 
            // topPanel
            // 
            topPanel.BackColor = Color.FromArgb(249, 248, 235);
            topPanel.BorderStyle = BorderStyle.FixedSingle;
            topPanel.Controls.Add(topMainPanel);
            topPanel.Controls.Add(userBtnPanel);
            topPanel.Controls.Add(iconPanel);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(1, 24);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(1278, 74);
            topPanel.TabIndex = 2;
            // 
            // topMainPanel
            // 
            topMainPanel.Dock = DockStyle.Fill;
            topMainPanel.Location = new Point(114, 0);
            topMainPanel.Name = "topMainPanel";
            topMainPanel.Size = new Size(1065, 72);
            topMainPanel.TabIndex = 3;
            // 
            // userBtnPanel
            // 
            userBtnPanel.Controls.Add(userBtn);
            userBtnPanel.Dock = DockStyle.Right;
            userBtnPanel.Location = new Point(1179, 0);
            userBtnPanel.Name = "userBtnPanel";
            userBtnPanel.Size = new Size(97, 72);
            userBtnPanel.TabIndex = 5;
            // 
            // userBtn
            // 
            userBtn.BackImageSize = new Size(0, 0);
            userBtn.BorderColor = Color.Black;
            userBtn.BorderRadius = 0;
            userBtn.BorderThickness = 0;
            userBtn.ButtonColor = Color.FromArgb(249, 248, 235);
            userBtn.Dock = DockStyle.Fill;
            userBtn.FlatAppearance.BorderSize = 0;
            userBtn.FlatStyle = FlatStyle.Flat;
            userBtn.HoverColor = Color.FromArgb(174, 173, 164);
            userBtn.IconLocation = CustomControls.RoundedButton.ImageLocation.Center;
            userBtn.Image = DocumentRequestingAdmin.Properties.Resources.Picture11;
            userBtn.ImageSize = new Size(55, 55);
            userBtn.Location = new Point(0, 0);
            userBtn.Name = "userBtn";
            userBtn.PressedColor = Color.FromArgb(121, 121, 114);
            userBtn.Size = new Size(97, 72);
            userBtn.TabIndex = 3;
            userBtn.UseVisualStyleBackColor = true;
            userBtn.Click += userBtn_Click;
            // 
            // iconPanel
            // 
            iconPanel.Controls.Add(iconPBox);
            iconPanel.Dock = DockStyle.Left;
            iconPanel.Location = new Point(0, 0);
            iconPanel.Name = "iconPanel";
            iconPanel.Size = new Size(114, 72);
            iconPanel.TabIndex = 4;
            // 
            // iconPBox
            // 
            iconPBox.Image = DocumentRequestingAdmin.Properties.Resources.Picture1;
            iconPBox.Location = new Point(0, -10);
            iconPBox.Name = "iconPBox";
            iconPBox.Size = new Size(110, 94);
            iconPBox.SizeMode = PictureBoxSizeMode.StretchImage;
            iconPBox.TabIndex = 0;
            iconPBox.TabStop = false;
            iconPBox.Click += iconPBox_Click;
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.FromArgb(249, 248, 235);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(1, 98);
            mainPanel.Name = "mainPanel";
            mainPanel.Padding = new Padding(100, 10, 100, 10);
            mainPanel.Size = new Size(1278, 563);
            mainPanel.TabIndex = 3;
            // 
            // AdminTemplate
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.Black;
            ClientSize = new Size(1280, 720);
            Controls.Add(mainPanel);
            Controls.Add(topPanel);
            Controls.Add(bottomPanel);
            FormStyle = FormStyles.ActionBar_None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1280, 720);
            Name = "AdminTemplate";
            Padding = new Padding(1, 24, 1, 1);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminTemplate";
            bottomPanel.ResumeLayout(false);
            topPanel.ResumeLayout(false);
            userBtnPanel.ResumeLayout(false);
            iconPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconPBox).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel topPanel;
        private PictureBox iconPBox;
        private Panel userBtnPanel;
        private Panel iconPanel;
        protected Panel mainPanel;
        protected Panel topMainPanel;
        private CustomControls.RoundedButton showFormsBtn;
        protected CustomControls.RoundedButton userBtn;
        private CustomControls.RoundedButton toStaffBtn;
        protected Panel bottomPanel;
        private CustomControls.RoundedButton addAccountBtn;
    }
}