using DocumentRequesting.CustomControls;
using DocumentRequestingUtils.CustomControls;

namespace DocumentRequesting.UserPanels
{
    partial class PickDocumentPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PickDocumentPanel));
            panel14 = new Panel();
            panel1 = new Panel();
            scrollBar = new CustomScrollBar();
            mainPanel = new TransparentFlowLayout();
            bottomPanel = new Panel();
            topPanel = new Panel();
            topMainPanel = new Panel();
            userBtn = new RoundedButton();
            iconPanel = new Panel();
            iconPBox = new PictureBox();
            panel14.SuspendLayout();
            panel1.SuspendLayout();
            topPanel.SuspendLayout();
            topMainPanel.SuspendLayout();
            iconPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPBox).BeginInit();
            SuspendLayout();
            // 
            // panel14
            // 
            panel14.BackColor = Color.FromArgb(249, 248, 235);
            panel14.BackgroundImage = DocumentRequestingStudent.Properties.Resources.Picture1;
            panel14.BackgroundImageLayout = ImageLayout.Center;
            panel14.Controls.Add(panel1);
            panel14.Controls.Add(mainPanel);
            panel14.Controls.Add(bottomPanel);
            panel14.Controls.Add(topPanel);
            panel14.Dock = DockStyle.Fill;
            panel14.Location = new Point(1, 24);
            panel14.Name = "panel14";
            panel14.Size = new Size(1278, 695);
            panel14.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.Controls.Add(scrollBar);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(1224, 74);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(10, 10, 15, 10);
            panel1.Size = new Size(54, 563);
            panel1.TabIndex = 0;
            // 
            // scrollBar
            // 
            scrollBar.Dock = DockStyle.Right;
            scrollBar.Location = new Point(11, 10);
            scrollBar.Maximum = 80;
            scrollBar.Minimum = 0;
            scrollBar.Name = "scrollBar";
            scrollBar.Size = new Size(28, 543);
            scrollBar.TabIndex = 0;
            scrollBar.ThumbColor = Color.FromArgb(128, 175, 129);
            scrollBar.ThumbSize = 100;
            scrollBar.TrackColor = Color.LightGray;
            scrollBar.Value = 0;
            // 
            // mainPanel
            // 
            mainPanel.AutoScroll = true;
            mainPanel.BackColor = Color.Transparent;
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 74);
            mainPanel.Name = "mainPanel";
            mainPanel.Padding = new Padding(20, 20, 40, 20);
            mainPanel.Size = new Size(1278, 563);
            mainPanel.TabIndex = 0;
            // 
            // bottomPanel
            // 
            bottomPanel.BackColor = Color.FromArgb(128, 175, 129);
            bottomPanel.Dock = DockStyle.Bottom;
            bottomPanel.Location = new Point(0, 637);
            bottomPanel.Name = "bottomPanel";
            bottomPanel.Padding = new Padding(0, 1, 0, 1);
            bottomPanel.Size = new Size(1278, 58);
            bottomPanel.TabIndex = 9;
            // 
            // topPanel
            // 
            topPanel.BackColor = Color.FromArgb(249, 248, 235);
            topPanel.BorderStyle = BorderStyle.FixedSingle;
            topPanel.Controls.Add(topMainPanel);
            topPanel.Controls.Add(iconPanel);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(0, 0);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(1278, 74);
            topPanel.TabIndex = 8;
            // 
            // topMainPanel
            // 
            topMainPanel.Controls.Add(userBtn);
            topMainPanel.Dock = DockStyle.Fill;
            topMainPanel.Location = new Point(114, 0);
            topMainPanel.Name = "topMainPanel";
            topMainPanel.Size = new Size(1162, 72);
            topMainPanel.TabIndex = 3;
            // 
            // userBtn
            // 
            userBtn.BorderColor = Color.Black;
            userBtn.BorderRadius = 0;
            userBtn.BorderThickness = 0;
            userBtn.ButtonColor = Color.FromArgb(249, 248, 235);
            userBtn.Dock = DockStyle.Right;
            userBtn.FlatAppearance.BorderSize = 0;
            userBtn.FlatStyle = FlatStyle.Flat;
            userBtn.HoverColor = Color.FromArgb(174, 173, 164);
            userBtn.IconLocation = RoundedButton.ImageLocation.Center;
            userBtn.Image = DocumentRequestingStudent.Properties.Resources.admin;
            userBtn.ImageSize = new Size(80, 80);
            userBtn.Location = new Point(1065, 0);
            userBtn.Name = "userBtn";
            userBtn.PressedColor = Color.FromArgb(121, 121, 114);
            userBtn.Size = new Size(97, 72);
            userBtn.TabIndex = 4;
            userBtn.UseVisualStyleBackColor = true;
            userBtn.Visible = false;
            userBtn.Click += backBtn_Click;
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
            iconPBox.Image = (Image)resources.GetObject("iconPBox.Image");
            iconPBox.Location = new Point(0, -10);
            iconPBox.Name = "iconPBox";
            iconPBox.Size = new Size(110, 94);
            iconPBox.SizeMode = PictureBoxSizeMode.StretchImage;
            iconPBox.TabIndex = 0;
            iconPBox.TabStop = false;
            // 
            // PickDocumentPanel
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(212, 231, 197);
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1280, 720);
            Controls.Add(panel14);
            FormStyle = FormStyles.ActionBar_None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1280, 720);
            Name = "PickDocumentPanel";
            Padding = new Padding(1, 24, 1, 1);
            Text = "PickDocumentPanel";
            panel14.ResumeLayout(false);
            panel1.ResumeLayout(false);
            topPanel.ResumeLayout(false);
            topMainPanel.ResumeLayout(false);
            iconPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconPBox).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel14;
        private TransparentFlowLayout mainPanel;
        private Panel panel1;
        private Panel topPanel;
        protected Panel topMainPanel;
        private Panel iconPanel;
        private PictureBox iconPBox;
        private Panel bottomPanel;
        private DocumentRequestingUtils.CustomControls.CustomScrollBar scrollBar;
        private RoundedButton userBtn;
    }
}