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
            imageBtn = new CustomControls.RoundedButton();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
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
            tableLayoutPanel1.Location = new Point(0, 24);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1280, 696);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(214, 239, 216);
            panel2.Controls.Add(imageBtn);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(640, 0);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(640, 696);
            panel2.TabIndex = 1;
            // 
            // imageBtn
            // 
            imageBtn.BackColor = Color.Transparent;
            imageBtn.BackgroundImage = DocumentRequestingStudent.Properties.Resources.Picture21;
            imageBtn.BackImageSize = new Size(664, 720);
            imageBtn.BorderColor = Color.Black;
            imageBtn.BorderRadius = 0;
            imageBtn.BorderThickness = 0;
            imageBtn.ButtonColor = Color.FromArgb(214, 239, 216);
            imageBtn.Cursor = Cursors.Hand;
            imageBtn.Dock = DockStyle.Fill;
            imageBtn.FlatAppearance.BorderSize = 0;
            imageBtn.FlatStyle = FlatStyle.Flat;
            imageBtn.HoverColor = Color.FromArgb(158, 177, 160);
            imageBtn.IconLocation = CustomControls.RoundedButton.ImageLocation.Center;
            imageBtn.Image = null;
            imageBtn.ImageSize = new Size(664, 720);
            imageBtn.Location = new Point(0, 0);
            imageBtn.Name = "imageBtn";
            imageBtn.PressedColor = Color.FromArgb(110, 123, 112);
            imageBtn.Size = new Size(640, 696);
            imageBtn.TabIndex = 0;
            imageBtn.UseVisualStyleBackColor = false;
            imageBtn.Click += imageBtn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(227, 253, 229);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(640, 696);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = DocumentRequestingStudent.Properties.Resources.Picture1;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(640, 696);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // LoginPanel
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1280, 720);
            Controls.Add(tableLayoutPanel1);
            FormStyle = FormStyles.ActionBar_None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1280, 720);
            Name = "LoginPanel";
            Padding = new Padding(0, 24, 0, 0);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginPanel";
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private CustomControls.RoundedButton imageBtn;
    }
}