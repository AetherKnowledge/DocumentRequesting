namespace DocumentRequestingAdmin.Popup
{
    partial class AcceptOrDecline
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
            panel1 = new Panel();
            backBtn = new DocumentRequesting.CustomControls.RoundedButton();
            DeclineBtn = new DocumentRequesting.CustomControls.RoundedButton();
            acceptBtn = new DocumentRequesting.CustomControls.RoundedButton();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(249, 248, 235);
            panel1.Controls.Add(backBtn);
            panel1.Controls.Add(DeclineBtn);
            panel1.Controls.Add(acceptBtn);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(456, 280);
            panel1.TabIndex = 0;
            // 
            // backBtn
            // 
            backBtn.BorderColor = Color.Black;
            backBtn.BorderRadius = 20;
            backBtn.BorderThickness = 0;
            backBtn.ButtonColor = Color.FromArgb(249, 248, 235);
            backBtn.FlatAppearance.BorderSize = 0;
            backBtn.FlatStyle = FlatStyle.Flat;
            backBtn.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            backBtn.HoverColor = Color.FromArgb(178, 178, 178);
            backBtn.IconLocation = DocumentRequesting.CustomControls.RoundedButton.ImageLocation.Center;
            backBtn.Image = null;
            backBtn.ImageSize = new Size(0, 0);
            backBtn.Location = new Point(398, 258);
            backBtn.Name = "backBtn";
            backBtn.PressedColor = Color.FromArgb(124, 124, 124);
            backBtn.Size = new Size(55, 19);
            backBtn.TabIndex = 3;
            backBtn.Text = "Back";
            backBtn.UseVisualStyleBackColor = true;
            backBtn.Click += backBtn_Click;
            // 
            // DeclineBtn
            // 
            DeclineBtn.BorderColor = Color.Black;
            DeclineBtn.BorderRadius = 10;
            DeclineBtn.BorderThickness = 1;
            DeclineBtn.ButtonColor = Color.FromArgb(128, 175, 129);
            DeclineBtn.FlatAppearance.BorderSize = 0;
            DeclineBtn.FlatStyle = FlatStyle.Flat;
            DeclineBtn.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            DeclineBtn.ForeColor = Color.White;
            DeclineBtn.HoverColor = Color.FromArgb(89, 122, 90);
            DeclineBtn.IconLocation = DocumentRequesting.CustomControls.RoundedButton.ImageLocation.Center;
            DeclineBtn.Image = null;
            DeclineBtn.ImageSize = new Size(0, 0);
            DeclineBtn.Location = new Point(333, 200);
            DeclineBtn.Name = "DeclineBtn";
            DeclineBtn.PressedColor = Color.FromArgb(62, 85, 62);
            DeclineBtn.Size = new Size(99, 36);
            DeclineBtn.TabIndex = 2;
            DeclineBtn.Text = "DECLINE";
            DeclineBtn.UseVisualStyleBackColor = true;
            DeclineBtn.Click += DeclineBtn_Click;
            // 
            // acceptBtn
            // 
            acceptBtn.BorderColor = Color.Black;
            acceptBtn.BorderRadius = 10;
            acceptBtn.BorderThickness = 1;
            acceptBtn.ButtonColor = Color.FromArgb(128, 175, 129);
            acceptBtn.FlatAppearance.BorderSize = 0;
            acceptBtn.FlatStyle = FlatStyle.Flat;
            acceptBtn.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            acceptBtn.ForeColor = Color.White;
            acceptBtn.HoverColor = Color.FromArgb(89, 122, 90);
            acceptBtn.IconLocation = DocumentRequesting.CustomControls.RoundedButton.ImageLocation.Center;
            acceptBtn.Image = null;
            acceptBtn.ImageSize = new Size(0, 0);
            acceptBtn.Location = new Point(22, 200);
            acceptBtn.Name = "acceptBtn";
            acceptBtn.PressedColor = Color.FromArgb(62, 85, 62);
            acceptBtn.Size = new Size(99, 36);
            acceptBtn.TabIndex = 1;
            acceptBtn.Text = "ACCEPT";
            acceptBtn.UseVisualStyleBackColor = true;
            acceptBtn.Click += acceptBtn_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 19);
            label1.Name = "label1";
            label1.Size = new Size(410, 165);
            label1.TabIndex = 0;
            label1.Text = "Thank you for considering us. We must decline your request, but we´re here to help with other inquiries.";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AcceptOrDecline
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.Black;
            ClientSize = new Size(458, 282);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AcceptOrDecline";
            Padding = new Padding(1);
            StartPosition = FormStartPosition.CenterParent;
            Text = "AcceptOrDecline";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private DocumentRequesting.CustomControls.RoundedButton backBtn;
        private DocumentRequesting.CustomControls.RoundedButton DeclineBtn;
        private DocumentRequesting.CustomControls.RoundedButton acceptBtn;
    }
}