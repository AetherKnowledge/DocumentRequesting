namespace DocumentRequestingAdmin.AdminPanels
{
    partial class AdminInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminInfo));
            logoutBtn = new DocumentRequesting.CustomControls.RoundedButton();
            pictureBox1 = new PictureBox();
            nameLabel = new Label();
            label1 = new Label();
            emailLabel = new Label();
            contactLabel = new Label();
            label3 = new Label();
            usernameLabel = new Label();
            label5 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.Controls.Add(panel2);
            mainPanel.Controls.Add(panel3);
            mainPanel.Controls.Add(panel1);
            mainPanel.Controls.Add(nameLabel);
            mainPanel.Controls.Add(pictureBox1);
            mainPanel.Controls.Add(logoutBtn);
            // 
            // userBtn
            // 
            userBtn.FlatAppearance.BorderSize = 0;
            userBtn.Image = Properties.Resources.home_icon_silhouette;
            userBtn.ImageSize = new Size(40, 40);
            userBtn.Click += userBtn_Click;
            // 
            // logoutBtn
            // 
            logoutBtn.Anchor = AnchorStyles.Bottom;
            logoutBtn.BorderColor = Color.Black;
            logoutBtn.BorderRadius = 20;
            logoutBtn.BorderThickness = 2;
            logoutBtn.ButtonColor = Color.White;
            logoutBtn.FlatAppearance.BorderSize = 0;
            logoutBtn.FlatStyle = FlatStyle.Flat;
            logoutBtn.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            logoutBtn.HoverColor = Color.Empty;
            logoutBtn.IconLocation = DocumentRequesting.CustomControls.RoundedButton.ImageLocation.Center;
            logoutBtn.Image = null;
            logoutBtn.ImageSize = new Size(0, 0);
            logoutBtn.Location = new Point(456, 499);
            logoutBtn.Name = "logoutBtn";
            logoutBtn.PressedColor = Color.Empty;
            logoutBtn.Size = new Size(405, 51);
            logoutBtn.TabIndex = 0;
            logoutBtn.Text = "LOG OUT";
            logoutBtn.UseVisualStyleBackColor = true;
            logoutBtn.Click += logoutBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.admin;
            pictureBox1.Location = new Point(42, 33);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(144, 144);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Arial", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nameLabel.Location = new Point(222, 89);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(201, 34);
            nameLabel.TabIndex = 2;
            nameLabel.Text = "ADMIN NAME";
            // 
            // label1
            // 
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(192, 42);
            label1.TabIndex = 3;
            label1.Text = "EMAIL:";
            label1.TextAlign = ContentAlignment.TopRight;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Dock = DockStyle.Left;
            emailLabel.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailLabel.Location = new Point(192, 0);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(72, 24);
            emailLabel.TabIndex = 4;
            emailLabel.Text = "EMAIL";
            // 
            // contactLabel
            // 
            contactLabel.AutoSize = true;
            contactLabel.Dock = DockStyle.Left;
            contactLabel.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            contactLabel.Location = new Point(192, 0);
            contactLabel.Name = "contactLabel";
            contactLabel.Size = new Size(72, 24);
            contactLabel.TabIndex = 6;
            contactLabel.Text = "EMAIL";
            // 
            // label3
            // 
            label3.Dock = DockStyle.Left;
            label3.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(192, 42);
            label3.TabIndex = 5;
            label3.Text = "CONTACT NO#:";
            label3.TextAlign = ContentAlignment.TopRight;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Dock = DockStyle.Left;
            usernameLabel.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernameLabel.Location = new Point(192, 0);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(72, 24);
            usernameLabel.TabIndex = 8;
            usernameLabel.Text = "EMAIL";
            // 
            // label5
            // 
            label5.Dock = DockStyle.Left;
            label5.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(192, 42);
            label5.TabIndex = 7;
            label5.Text = "USERNAME:";
            label5.TextAlign = ContentAlignment.TopRight;
            // 
            // panel1
            // 
            panel1.Controls.Add(emailLabel);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(42, 232);
            panel1.Name = "panel1";
            panel1.Size = new Size(933, 42);
            panel1.TabIndex = 9;
            // 
            // panel2
            // 
            panel2.Controls.Add(contactLabel);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(42, 280);
            panel2.Name = "panel2";
            panel2.Size = new Size(933, 42);
            panel2.TabIndex = 10;
            // 
            // panel3
            // 
            panel3.Controls.Add(usernameLabel);
            panel3.Controls.Add(label5);
            panel3.Location = new Point(42, 329);
            panel3.Name = "panel3";
            panel3.Size = new Size(933, 42);
            panel3.TabIndex = 10;
            // 
            // AdminInfo
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1280, 720);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AdminInfo";
            Text = "AdminInfo";
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DocumentRequesting.CustomControls.RoundedButton logoutBtn;
        private Label nameLabel;
        private PictureBox pictureBox1;
        private Label label1;
        private Label emailLabel;
        private Label usernameLabel;
        private Label label5;
        private Label contactLabel;
        private Label label3;
        private Panel panel2;
        private Panel panel3;
        private Panel panel1;
    }
}