using DocumentRequesting.CustomControls;

namespace DocumentRequestingAdmin.AdminPanels
{
    partial class CreateAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateAccount));
            panel6 = new Panel();
            panel9 = new Panel();
            roleBox = new ComboBox();
            label8 = new Label();
            panel8 = new Panel();
            showPassBox = new CheckBox();
            label7 = new Label();
            panel7 = new Panel();
            passwordBox = new RoundedTextBox();
            label6 = new Label();
            panel5 = new Panel();
            usernameBox = new RoundedTextBox();
            label5 = new Label();
            panel4 = new Panel();
            mobileNumBox = new RoundedTextBox();
            label4 = new Label();
            panel3 = new Panel();
            emailBox = new RoundedTextBox();
            label2 = new Label();
            panel2 = new Panel();
            lastNameBox = new RoundedTextBox();
            midNameBox = new RoundedTextBox();
            firstNameBox = new RoundedTextBox();
            label3 = new Label();
            cancelBtn = new RoundedButton();
            saveBtn = new RoundedButton();
            panel1 = new Panel();
            label1 = new Label();
            panel6.SuspendLayout();
            panel9.SuspendLayout();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(249, 248, 235);
            panel6.Controls.Add(panel9);
            panel6.Controls.Add(panel8);
            panel6.Controls.Add(panel7);
            panel6.Controls.Add(panel5);
            panel6.Controls.Add(panel4);
            panel6.Controls.Add(panel3);
            panel6.Controls.Add(panel2);
            panel6.Controls.Add(cancelBtn);
            panel6.Controls.Add(saveBtn);
            panel6.Controls.Add(panel1);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(1, 24);
            panel6.Name = "panel6";
            panel6.Size = new Size(1278, 695);
            panel6.TabIndex = 6;
            // 
            // panel9
            // 
            panel9.Controls.Add(roleBox);
            panel9.Controls.Add(label8);
            panel9.Location = new Point(146, 328);
            panel9.Name = "panel9";
            panel9.Size = new Size(951, 39);
            panel9.TabIndex = 31;
            // 
            // roleBox
            // 
            roleBox.BackColor = Color.White;
            roleBox.Dock = DockStyle.Left;
            roleBox.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roleBox.FormattingEnabled = true;
            roleBox.Location = new Point(211, 0);
            roleBox.Name = "roleBox";
            roleBox.Size = new Size(230, 26);
            roleBox.TabIndex = 26;
            // 
            // label8
            // 
            label8.Dock = DockStyle.Left;
            label8.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            label8.Location = new Point(0, 0);
            label8.Name = "label8";
            label8.Size = new Size(211, 39);
            label8.TabIndex = 25;
            label8.Text = "ROLE:";
            label8.TextAlign = ContentAlignment.TopRight;
            // 
            // panel8
            // 
            panel8.Controls.Add(showPassBox);
            panel8.Controls.Add(label7);
            panel8.Location = new Point(357, 460);
            panel8.Name = "panel8";
            panel8.Size = new Size(426, 24);
            panel8.TabIndex = 31;
            // 
            // showPassBox
            // 
            showPassBox.AutoSize = true;
            showPassBox.CheckAlign = ContentAlignment.TopCenter;
            showPassBox.Dock = DockStyle.Right;
            showPassBox.Location = new Point(311, 0);
            showPassBox.Name = "showPassBox";
            showPassBox.Size = new Size(15, 24);
            showPassBox.TabIndex = 1;
            showPassBox.UseVisualStyleBackColor = true;
            showPassBox.CheckedChanged += showPassBox_CheckedChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Right;
            label7.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(326, 0);
            label7.Name = "label7";
            label7.Size = new Size(100, 16);
            label7.TabIndex = 0;
            label7.Text = "Show Password";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel7
            // 
            panel7.Controls.Add(passwordBox);
            panel7.Controls.Add(label6);
            panel7.Location = new Point(146, 418);
            panel7.Name = "panel7";
            panel7.Size = new Size(951, 39);
            panel7.TabIndex = 30;
            // 
            // passwordBox
            // 
            passwordBox.BackColor = Color.FromArgb(249, 248, 235);
            passwordBox.BorderColor = Color.Black;
            passwordBox.BorderRadius = 0;
            passwordBox.BorderThickness = 1;
            passwordBox.Dock = DockStyle.Left;
            passwordBox.DropShadow = false;
            passwordBox.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordBox.Lines = new string[]
    {
    "Password"
    };
            passwordBox.Location = new Point(211, 0);
            passwordBox.Multiline = false;
            passwordBox.Name = "passwordBox";
            passwordBox.Padding = new Padding(1);
            passwordBox.PlaceHolderText = "Password";
            passwordBox.ShadowColor = Color.FromArgb(128, 0, 0, 0);
            passwordBox.ShadowOffsetX = 3;
            passwordBox.ShadowOffsetY = 3;
            passwordBox.Size = new Size(362, 25);
            passwordBox.TabIndex = 15;
            passwordBox.TextAlign = HorizontalAlignment.Left;
            passwordBox.TextBoxColor = Color.White;
            passwordBox.UseSystemPasswordChar = true;
            passwordBox.WithPlaceHolder = true;
            // 
            // label6
            // 
            label6.Dock = DockStyle.Left;
            label6.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            label6.Location = new Point(0, 0);
            label6.Name = "label6";
            label6.Size = new Size(211, 39);
            label6.TabIndex = 25;
            label6.Text = "PASSWORD:";
            label6.TextAlign = ContentAlignment.TopRight;
            // 
            // panel5
            // 
            panel5.Controls.Add(usernameBox);
            panel5.Controls.Add(label5);
            panel5.Location = new Point(146, 373);
            panel5.Name = "panel5";
            panel5.Size = new Size(951, 39);
            panel5.TabIndex = 29;
            // 
            // usernameBox
            // 
            usernameBox.BackColor = Color.FromArgb(249, 248, 235);
            usernameBox.BorderColor = Color.Black;
            usernameBox.BorderRadius = 0;
            usernameBox.BorderThickness = 1;
            usernameBox.Dock = DockStyle.Left;
            usernameBox.DropShadow = false;
            usernameBox.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernameBox.Lines = new string[]
    {
    "Username"
    };
            usernameBox.Location = new Point(211, 0);
            usernameBox.Multiline = false;
            usernameBox.Name = "usernameBox";
            usernameBox.Padding = new Padding(1);
            usernameBox.PlaceHolderText = "Username";
            usernameBox.ShadowColor = Color.FromArgb(128, 0, 0, 0);
            usernameBox.ShadowOffsetX = 3;
            usernameBox.ShadowOffsetY = 3;
            usernameBox.Size = new Size(362, 25);
            usernameBox.TabIndex = 14;
            usernameBox.TextAlign = HorizontalAlignment.Left;
            usernameBox.TextBoxColor = Color.White;
            usernameBox.UseSystemPasswordChar = false;
            usernameBox.WithPlaceHolder = true;
            // 
            // label5
            // 
            label5.Dock = DockStyle.Left;
            label5.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(211, 39);
            label5.TabIndex = 24;
            label5.Text = "USERNAME:";
            label5.TextAlign = ContentAlignment.TopRight;
            // 
            // panel4
            // 
            panel4.Controls.Add(mobileNumBox);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(146, 283);
            panel4.Name = "panel4";
            panel4.Size = new Size(951, 39);
            panel4.TabIndex = 28;
            // 
            // mobileNumBox
            // 
            mobileNumBox.BackColor = Color.FromArgb(249, 248, 235);
            mobileNumBox.BorderColor = Color.Black;
            mobileNumBox.BorderRadius = 0;
            mobileNumBox.BorderThickness = 1;
            mobileNumBox.Dock = DockStyle.Left;
            mobileNumBox.DropShadow = false;
            mobileNumBox.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mobileNumBox.Lines = new string[]
    {
    "Contact Number"
    };
            mobileNumBox.Location = new Point(211, 0);
            mobileNumBox.Multiline = false;
            mobileNumBox.Name = "mobileNumBox";
            mobileNumBox.Padding = new Padding(1);
            mobileNumBox.PlaceHolderText = "Contact Number";
            mobileNumBox.ShadowColor = Color.FromArgb(128, 0, 0, 0);
            mobileNumBox.ShadowOffsetX = 3;
            mobileNumBox.ShadowOffsetY = 3;
            mobileNumBox.Size = new Size(230, 25);
            mobileNumBox.TabIndex = 11;
            mobileNumBox.TextAlign = HorizontalAlignment.Left;
            mobileNumBox.TextBoxColor = Color.White;
            mobileNumBox.UseSystemPasswordChar = false;
            mobileNumBox.WithPlaceHolder = true;
            // 
            // label4
            // 
            label4.Dock = DockStyle.Left;
            label4.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(211, 39);
            label4.TabIndex = 23;
            label4.Text = "CONTACT NO#:";
            label4.TextAlign = ContentAlignment.TopRight;
            // 
            // panel3
            // 
            panel3.Controls.Add(emailBox);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(146, 238);
            panel3.Name = "panel3";
            panel3.Size = new Size(951, 39);
            panel3.TabIndex = 27;
            // 
            // emailBox
            // 
            emailBox.BackColor = Color.FromArgb(249, 248, 235);
            emailBox.BorderColor = Color.Black;
            emailBox.BorderRadius = 0;
            emailBox.BorderThickness = 1;
            emailBox.Dock = DockStyle.Left;
            emailBox.DropShadow = false;
            emailBox.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailBox.Lines = new string[]
    {
    "Email"
    };
            emailBox.Location = new Point(211, 0);
            emailBox.Multiline = false;
            emailBox.Name = "emailBox";
            emailBox.Padding = new Padding(1);
            emailBox.PlaceHolderText = "Email";
            emailBox.ShadowColor = Color.FromArgb(128, 0, 0, 0);
            emailBox.ShadowOffsetX = 3;
            emailBox.ShadowOffsetY = 3;
            emailBox.Size = new Size(696, 25);
            emailBox.TabIndex = 12;
            emailBox.TextAlign = HorizontalAlignment.Left;
            emailBox.TextBoxColor = Color.White;
            emailBox.UseSystemPasswordChar = false;
            emailBox.WithPlaceHolder = true;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Left;
            label2.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(211, 39);
            label2.TabIndex = 22;
            label2.Text = "EMAIL:";
            label2.TextAlign = ContentAlignment.TopRight;
            // 
            // panel2
            // 
            panel2.Controls.Add(lastNameBox);
            panel2.Controls.Add(midNameBox);
            panel2.Controls.Add(firstNameBox);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(146, 193);
            panel2.Name = "panel2";
            panel2.Size = new Size(951, 39);
            panel2.TabIndex = 26;
            // 
            // lastNameBox
            // 
            lastNameBox.BackColor = Color.FromArgb(249, 248, 235);
            lastNameBox.BorderColor = Color.Black;
            lastNameBox.BorderRadius = 0;
            lastNameBox.BorderThickness = 1;
            lastNameBox.Dock = DockStyle.Left;
            lastNameBox.DropShadow = false;
            lastNameBox.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lastNameBox.Lines = new string[]
    {
    "Last Name"
    };
            lastNameBox.Location = new Point(667, 0);
            lastNameBox.Multiline = false;
            lastNameBox.Name = "lastNameBox";
            lastNameBox.Padding = new Padding(1);
            lastNameBox.PlaceHolderText = "Last Name";
            lastNameBox.ShadowColor = Color.FromArgb(128, 0, 0, 0);
            lastNameBox.ShadowOffsetX = 3;
            lastNameBox.ShadowOffsetY = 3;
            lastNameBox.Size = new Size(228, 25);
            lastNameBox.TabIndex = 8;
            lastNameBox.TextAlign = HorizontalAlignment.Left;
            lastNameBox.TextBoxColor = Color.White;
            lastNameBox.UseSystemPasswordChar = false;
            lastNameBox.WithPlaceHolder = true;
            // 
            // midNameBox
            // 
            midNameBox.BackColor = Color.FromArgb(249, 248, 235);
            midNameBox.BorderColor = Color.Black;
            midNameBox.BorderRadius = 0;
            midNameBox.BorderThickness = 1;
            midNameBox.Dock = DockStyle.Left;
            midNameBox.DropShadow = false;
            midNameBox.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            midNameBox.Lines = new string[]
    {
    "Middle Name"
    };
            midNameBox.Location = new Point(439, 0);
            midNameBox.Multiline = false;
            midNameBox.Name = "midNameBox";
            midNameBox.Padding = new Padding(1);
            midNameBox.PlaceHolderText = "Middle Name";
            midNameBox.ShadowColor = Color.FromArgb(128, 0, 0, 0);
            midNameBox.ShadowOffsetX = 3;
            midNameBox.ShadowOffsetY = 3;
            midNameBox.Size = new Size(228, 25);
            midNameBox.TabIndex = 7;
            midNameBox.TextAlign = HorizontalAlignment.Left;
            midNameBox.TextBoxColor = Color.White;
            midNameBox.UseSystemPasswordChar = false;
            midNameBox.WithPlaceHolder = true;
            // 
            // firstNameBox
            // 
            firstNameBox.BackColor = Color.FromArgb(249, 248, 235);
            firstNameBox.BorderColor = Color.Black;
            firstNameBox.BorderRadius = 0;
            firstNameBox.BorderThickness = 1;
            firstNameBox.Dock = DockStyle.Left;
            firstNameBox.DropShadow = false;
            firstNameBox.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            firstNameBox.Lines = new string[]
    {
    "First Name"
    };
            firstNameBox.Location = new Point(211, 0);
            firstNameBox.Multiline = false;
            firstNameBox.Name = "firstNameBox";
            firstNameBox.Padding = new Padding(1);
            firstNameBox.PlaceHolderText = "First Name";
            firstNameBox.ShadowColor = Color.FromArgb(128, 0, 0, 0);
            firstNameBox.ShadowOffsetX = 3;
            firstNameBox.ShadowOffsetY = 3;
            firstNameBox.Size = new Size(228, 25);
            firstNameBox.TabIndex = 6;
            firstNameBox.TextAlign = HorizontalAlignment.Left;
            firstNameBox.TextBoxColor = Color.White;
            firstNameBox.UseSystemPasswordChar = false;
            firstNameBox.WithPlaceHolder = true;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Left;
            label3.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(211, 39);
            label3.TabIndex = 2;
            label3.Text = "NAME:";
            label3.TextAlign = ContentAlignment.TopRight;
            // 
            // cancelBtn
            // 
            cancelBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cancelBtn.BackColor = Color.White;
            cancelBtn.BackImageSize = new Size(0, 0);
            cancelBtn.BorderColor = Color.Black;
            cancelBtn.BorderRadius = 10;
            cancelBtn.BorderThickness = 1;
            cancelBtn.ButtonColor = Color.FromArgb(128, 175, 129);
            cancelBtn.FlatAppearance.BorderSize = 0;
            cancelBtn.FlatStyle = FlatStyle.Flat;
            cancelBtn.Font = new Font("Arial", 12F, FontStyle.Bold);
            cancelBtn.ForeColor = Color.White;
            cancelBtn.HoverColor = Color.FromArgb(89, 122, 90);
            cancelBtn.IconLocation = RoundedButton.ImageLocation.Left;
            cancelBtn.Image = null;
            cancelBtn.ImageSize = new Size(0, 0);
            cancelBtn.Location = new Point(691, 584);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.PressedColor = Color.FromArgb(62, 85, 62);
            cancelBtn.Size = new Size(123, 49);
            cancelBtn.TabIndex = 21;
            cancelBtn.Text = "CANCEL";
            cancelBtn.UseVisualStyleBackColor = false;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // saveBtn
            // 
            saveBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            saveBtn.BackColor = Color.White;
            saveBtn.BackImageSize = new Size(0, 0);
            saveBtn.BorderColor = Color.Black;
            saveBtn.BorderRadius = 10;
            saveBtn.BorderThickness = 1;
            saveBtn.ButtonColor = Color.FromArgb(128, 175, 129);
            saveBtn.FlatAppearance.BorderSize = 0;
            saveBtn.FlatStyle = FlatStyle.Flat;
            saveBtn.Font = new Font("Arial", 12F, FontStyle.Bold);
            saveBtn.ForeColor = Color.White;
            saveBtn.HoverColor = Color.FromArgb(89, 122, 90);
            saveBtn.IconLocation = RoundedButton.ImageLocation.Left;
            saveBtn.Image = null;
            saveBtn.ImageSize = new Size(0, 0);
            saveBtn.Location = new Point(459, 584);
            saveBtn.Name = "saveBtn";
            saveBtn.PressedColor = Color.FromArgb(62, 85, 62);
            saveBtn.Size = new Size(123, 49);
            saveBtn.TabIndex = 20;
            saveBtn.Text = "SAVE";
            saveBtn.UseVisualStyleBackColor = false;
            saveBtn.Click += saveBtn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 175, 129);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1278, 74);
            panel1.TabIndex = 19;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1278, 74);
            label1.TabIndex = 0;
            label1.Text = "CREATE ACCOUNT";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CreateAccount
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1280, 720);
            Controls.Add(panel6);
            FormStyle = FormStyles.ActionBar_None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1280, 720);
            Name = "CreateAccount";
            Padding = new Padding(1, 24, 1, 1);
            Text = "CreateAccount";
            panel6.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel7.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel6;
        private Panel panel1;
        private Label label1;
        private RoundedTextBox passwordBox;
        private RoundedTextBox usernameBox;
        private RoundedTextBox mobileNumBox;
        private RoundedTextBox lastNameBox;
        private RoundedTextBox midNameBox;
        private RoundedTextBox firstNameBox;
        private Label label3;
        private DocumentRequesting.CustomControls.RoundedButton cancelBtn;
        private DocumentRequesting.CustomControls.RoundedButton saveBtn;
        private Label label6;
        private Label label5;
        private Label label4;
        private Panel panel2;
        private Panel panel4;
        private Panel panel3;
        private RoundedTextBox emailBox;
        private Label label2;
        private Panel panel5;
        private Panel panel7;
        private Panel panel8;
        private CheckBox showPassBox;
        private Label label7;
        private Panel panel9;
        private Label label8;
        private ComboBox roleBox;
    }
}