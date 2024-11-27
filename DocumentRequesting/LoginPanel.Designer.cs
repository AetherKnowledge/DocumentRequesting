namespace DocumentRequesting
{
    partial class LoginPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPanel));
            tableLayoutPanel1 = new TableLayoutPanel();
            panel2 = new Panel();
            panel6 = new Panel();
            showPassBox = new CheckBox();
            label4 = new Label();
            panel5 = new Panel();
            usernameBox = new TextBox();
            label2 = new Label();
            panel4 = new Panel();
            passwordBox = new TextBox();
            label3 = new Label();
            createAccBtn = new LinkLabel();
            loginBtn = new CustomControls.RoundedButton();
            panel3 = new Panel();
            label1 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel2, 1, 0);
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 24);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1274, 693);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(214, 239, 216);
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(createAccBtn);
            panel2.Controls.Add(loginBtn);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(637, 0);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(637, 693);
            panel2.TabIndex = 1;
            // 
            // panel6
            // 
            panel6.Controls.Add(showPassBox);
            panel6.Controls.Add(label4);
            panel6.Location = new Point(183, 315);
            panel6.Name = "panel6";
            panel6.Size = new Size(426, 24);
            panel6.TabIndex = 13;
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Right;
            label4.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(326, 0);
            label4.Name = "label4";
            label4.Size = new Size(100, 16);
            label4.TabIndex = 0;
            label4.Text = "Show Password";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            panel5.Controls.Add(usernameBox);
            panel5.Controls.Add(label2);
            panel5.Location = new Point(35, 209);
            panel5.Name = "panel5";
            panel5.Size = new Size(574, 50);
            panel5.TabIndex = 9;
            // 
            // usernameBox
            // 
            usernameBox.Dock = DockStyle.Fill;
            usernameBox.Font = new Font("Aptos Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernameBox.Location = new Point(148, 0);
            usernameBox.Name = "usernameBox";
            usernameBox.Size = new Size(426, 33);
            usernameBox.TabIndex = 2;
            usernameBox.Text = "Username";
            // 
            // label2
            // 
            label2.Dock = DockStyle.Left;
            label2.Font = new Font("Aptos Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(148, 50);
            label2.TabIndex = 1;
            label2.Text = "Username:";
            label2.TextAlign = ContentAlignment.TopRight;
            // 
            // panel4
            // 
            panel4.Controls.Add(passwordBox);
            panel4.Controls.Add(label3);
            panel4.Location = new Point(35, 265);
            panel4.Name = "panel4";
            panel4.Size = new Size(574, 47);
            panel4.TabIndex = 8;
            // 
            // passwordBox
            // 
            passwordBox.Dock = DockStyle.Fill;
            passwordBox.Font = new Font("Aptos Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordBox.Location = new Point(148, 0);
            passwordBox.Name = "passwordBox";
            passwordBox.Size = new Size(426, 33);
            passwordBox.TabIndex = 4;
            passwordBox.Text = "Password";
            passwordBox.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Left;
            label3.Font = new Font("Aptos Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(148, 47);
            label3.TabIndex = 3;
            label3.Text = "Password:";
            label3.TextAlign = ContentAlignment.TopRight;
            // 
            // createAccBtn
            // 
            createAccBtn.ActiveLinkColor = Color.FromArgb(255, 128, 128);
            createAccBtn.Anchor = AnchorStyles.Top;
            createAccBtn.Font = new Font("Aptos Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            createAccBtn.LinkColor = Color.Black;
            createAccBtn.Location = new Point(65, 440);
            createAccBtn.Name = "createAccBtn";
            createAccBtn.Size = new Size(544, 24);
            createAccBtn.TabIndex = 7;
            createAccBtn.TabStop = true;
            createAccBtn.Text = "Create New Account";
            createAccBtn.TextAlign = ContentAlignment.MiddleCenter;
            createAccBtn.LinkClicked += createAccBtn_LinkClicked;
            // 
            // loginBtn
            // 
            loginBtn.Anchor = AnchorStyles.Top;
            loginBtn.BackColor = Color.Transparent;
            loginBtn.BackImageSize = new Size(0, 0);
            loginBtn.BorderColor = Color.Black;
            loginBtn.BorderRadius = 10;
            loginBtn.BorderThickness = 2;
            loginBtn.ButtonColor = Color.FromArgb(128, 175, 129);
            loginBtn.FlatAppearance.BorderSize = 0;
            loginBtn.FlatStyle = FlatStyle.Flat;
            loginBtn.Font = new Font("Aptos SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginBtn.ForeColor = Color.White;
            loginBtn.HoverColor = Color.FromArgb(89, 122, 90);
            loginBtn.IconLocation = CustomControls.RoundedButton.ImageLocation.Center;
            loginBtn.Image = null;
            loginBtn.ImageSize = new Size(0, 0);
            loginBtn.Location = new Point(266, 360);
            loginBtn.Name = "loginBtn";
            loginBtn.PressedColor = Color.FromArgb(62, 85, 62);
            loginBtn.Size = new Size(133, 53);
            loginBtn.TabIndex = 5;
            loginBtn.Text = "LOGIN";
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += loginBtn_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(637, 100);
            panel3.TabIndex = 0;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Aptos", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(637, 100);
            label1.TabIndex = 0;
            label1.Text = "Login";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(227, 253, 229);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(637, 693);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = DocumentRequestingAdmin.Properties.Resources.Picture1;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(637, 693);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // LoginPanel
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1280, 720);
            Controls.Add(tableLayoutPanel1);
            FormStyle = FormStyles.ActionBar_None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1280, 720);
            Name = "LoginPanel";
            Padding = new Padding(3, 24, 3, 3);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginPanel";
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Panel panel3;
        private Label label1;
        private TextBox passwordBox;
        private Label label3;
        private TextBox usernameBox;
        private Label label2;
        private CustomControls.RoundedButton loginBtn;
        private LinkLabel createAccBtn;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private CheckBox showPassBox;
        private Label label4;
    }
}