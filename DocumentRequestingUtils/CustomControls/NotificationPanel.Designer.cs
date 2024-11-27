namespace DocumentRequestingUtils.CustomControls
{
    partial class NotificationPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            nameLabel = new Label();
            panel1 = new Panel();
            timeLabel = new Label();
            textBox = new RichTextBox();
            panel2 = new Panel();
            printBtnPanel = new Panel();
            printBtn = new DocumentRequesting.CustomControls.RoundedButton();
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            printBtnPanel.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = Properties.Resources.admin;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(158, 152);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // nameLabel
            // 
            nameLabel.Dock = DockStyle.Fill;
            nameLabel.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nameLabel.Location = new Point(0, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(310, 53);
            nameLabel.TabIndex = 1;
            nameLabel.Text = "Admin";
            nameLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(nameLabel);
            panel1.Controls.Add(timeLabel);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(158, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(0, 0, 10, 0);
            panel1.Size = new Size(568, 53);
            panel1.TabIndex = 2;
            // 
            // timeLabel
            // 
            timeLabel.Dock = DockStyle.Right;
            timeLabel.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            timeLabel.Location = new Point(310, 0);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(248, 53);
            timeLabel.TabIndex = 2;
            timeLabel.Text = "11:53 AM";
            timeLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBox
            // 
            textBox.BackColor = Color.White;
            textBox.BorderStyle = BorderStyle.None;
            textBox.Dock = DockStyle.Fill;
            textBox.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox.Location = new Point(158, 53);
            textBox.Name = "textBox";
            textBox.ReadOnly = true;
            textBox.Size = new Size(458, 99);
            textBox.TabIndex = 3;
            textBox.Text = "wewewew";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(textBox);
            panel2.Controls.Add(printBtnPanel);
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(1, 1);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(0, 0, 0, 10);
            panel2.Size = new Size(728, 164);
            panel2.TabIndex = 3;
            // 
            // printBtnPanel
            // 
            printBtnPanel.Controls.Add(printBtn);
            printBtnPanel.Dock = DockStyle.Right;
            printBtnPanel.Location = new Point(616, 53);
            printBtnPanel.Name = "printBtnPanel";
            printBtnPanel.Padding = new Padding(10, 40, 10, 30);
            printBtnPanel.Size = new Size(110, 99);
            printBtnPanel.TabIndex = 4;
            // 
            // printBtn
            // 
            printBtn.BorderColor = Color.Black;
            printBtn.BorderRadius = 20;
            printBtn.BorderThickness = 2;
            printBtn.ButtonColor = Color.FromArgb(208, 240, 192);
            printBtn.Dock = DockStyle.Fill;
            printBtn.FlatAppearance.BorderSize = 0;
            printBtn.FlatStyle = FlatStyle.Flat;
            printBtn.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            printBtn.HoverColor = Color.FromArgb(171, 171, 171);
            printBtn.IconLocation = DocumentRequesting.CustomControls.RoundedButton.ImageLocation.Center;
            printBtn.Image = null;
            printBtn.ImageSize = new Size(0, 0);
            printBtn.Location = new Point(10, 40);
            printBtn.Name = "printBtn";
            printBtn.PressedColor = Color.FromArgb(119, 119, 119);
            printBtn.Size = new Size(90, 29);
            printBtn.TabIndex = 0;
            printBtn.Text = "Print";
            printBtn.UseVisualStyleBackColor = true;
            printBtn.Click += printBtn_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(panel2);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(1, 1);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(1);
            panel3.Size = new Size(730, 166);
            panel3.TabIndex = 4;
            // 
            // NotificationPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel3);
            Name = "NotificationPanel";
            Padding = new Padding(1);
            Size = new Size(732, 168);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            printBtnPanel.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Label nameLabel;
        private Panel panel1;
        private Label timeLabel;
        private RichTextBox textBox;
        private Panel panel2;
        private Panel panel3;
        private Panel printBtnPanel;
        private DocumentRequesting.CustomControls.RoundedButton printBtn;
    }
}
