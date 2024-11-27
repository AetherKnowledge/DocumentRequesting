namespace DocumentRequesting.Popup
{
    partial class ViewRequestForm
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
            panel6 = new Panel();
            statusLabel = new Label();
            label4 = new Label();
            okBtn = new CustomControls.RoundedButton();
            panel5 = new Panel();
            requestedAmmountLabel = new Label();
            label7 = new Label();
            panel4 = new Panel();
            timeLabel = new Label();
            label5 = new Label();
            panel3 = new Panel();
            dayLabel = new Label();
            label3 = new Label();
            panel2 = new Panel();
            typeLabel = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(249, 248, 235);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(okBtn);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(404, 306);
            panel1.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.Controls.Add(statusLabel);
            panel6.Controls.Add(label4);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 192);
            panel6.Name = "panel6";
            panel6.Size = new Size(404, 48);
            panel6.TabIndex = 5;
            // 
            // statusLabel
            // 
            statusLabel.Dock = DockStyle.Fill;
            statusLabel.Font = new Font("Arial", 12F);
            statusLabel.Location = new Point(156, 0);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(248, 48);
            statusLabel.TabIndex = 1;
            statusLabel.Text = "Type of Document";
            statusLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.Dock = DockStyle.Left;
            label4.Font = new Font("Arial", 12F);
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(156, 48);
            label4.TabIndex = 0;
            label4.Text = "Status:";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // okBtn
            // 
            okBtn.BorderColor = Color.Black;
            okBtn.BorderRadius = 10;
            okBtn.BorderThickness = 1;
            okBtn.ButtonColor = Color.FromArgb(128, 175, 129);
            okBtn.FlatAppearance.BorderSize = 0;
            okBtn.FlatStyle = FlatStyle.Flat;
            okBtn.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            okBtn.ForeColor = Color.White;
            okBtn.HoverColor = Color.FromArgb(89, 122, 90);
            okBtn.IconLocation = CustomControls.RoundedButton.ImageLocation.Center;
            okBtn.Image = null;
            okBtn.ImageSize = new Size(0, 0);
            okBtn.Location = new Point(14, 260);
            okBtn.Name = "okBtn";
            okBtn.PressedColor = Color.FromArgb(62, 85, 62);
            okBtn.Size = new Size(72, 33);
            okBtn.TabIndex = 4;
            okBtn.Text = "Back";
            okBtn.UseVisualStyleBackColor = true;
            okBtn.Click += okBtn_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(requestedAmmountLabel);
            panel5.Controls.Add(label7);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 144);
            panel5.Name = "panel5";
            panel5.Size = new Size(404, 48);
            panel5.TabIndex = 3;
            // 
            // requestedAmmountLabel
            // 
            requestedAmmountLabel.Dock = DockStyle.Fill;
            requestedAmmountLabel.Font = new Font("Arial", 12F);
            requestedAmmountLabel.Location = new Point(156, 0);
            requestedAmmountLabel.Name = "requestedAmmountLabel";
            requestedAmmountLabel.Size = new Size(248, 48);
            requestedAmmountLabel.TabIndex = 1;
            requestedAmmountLabel.Text = "Type of Document";
            requestedAmmountLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.Dock = DockStyle.Left;
            label7.Font = new Font("Arial", 12F);
            label7.Location = new Point(0, 0);
            label7.Name = "label7";
            label7.Size = new Size(156, 48);
            label7.TabIndex = 0;
            label7.Text = "Previous Requested Documents:";
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel4
            // 
            panel4.Controls.Add(timeLabel);
            panel4.Controls.Add(label5);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 96);
            panel4.Name = "panel4";
            panel4.Size = new Size(404, 48);
            panel4.TabIndex = 2;
            // 
            // timeLabel
            // 
            timeLabel.Dock = DockStyle.Fill;
            timeLabel.Font = new Font("Arial", 12F);
            timeLabel.Location = new Point(156, 0);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(248, 48);
            timeLabel.TabIndex = 1;
            timeLabel.Text = "Type of Document";
            timeLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.Dock = DockStyle.Left;
            label5.Font = new Font("Arial", 12F);
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(156, 48);
            label5.TabIndex = 0;
            label5.Text = "Time of Claiming:";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel3
            // 
            panel3.Controls.Add(dayLabel);
            panel3.Controls.Add(label3);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 48);
            panel3.Name = "panel3";
            panel3.Size = new Size(404, 48);
            panel3.TabIndex = 1;
            // 
            // dayLabel
            // 
            dayLabel.Dock = DockStyle.Fill;
            dayLabel.Font = new Font("Arial", 12F);
            dayLabel.Location = new Point(162, 0);
            dayLabel.Name = "dayLabel";
            dayLabel.Size = new Size(242, 48);
            dayLabel.TabIndex = 1;
            dayLabel.Text = "Type of Document";
            dayLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Left;
            label3.Font = new Font("Arial", 12F);
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(162, 48);
            label3.TabIndex = 0;
            label3.Text = "Day of Claiming:";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            panel2.Controls.Add(typeLabel);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(404, 48);
            panel2.TabIndex = 0;
            // 
            // typeLabel
            // 
            typeLabel.Dock = DockStyle.Fill;
            typeLabel.Font = new Font("Arial", 12F);
            typeLabel.Location = new Point(162, 0);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new Size(242, 48);
            typeLabel.TabIndex = 1;
            typeLabel.Text = "Type of Document";
            typeLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Arial", 12F);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(162, 48);
            label1.TabIndex = 0;
            label1.Text = "Type of Document:";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // ViewRequestForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.Black;
            ClientSize = new Size(406, 308);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewRequestForm";
            Padding = new Padding(1);
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "ViewRequestForm";
            panel1.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Panel panel5;
        private Label requestedAmmountLabel;
        private Label label7;
        private Panel panel4;
        private Label timeLabel;
        private Label label5;
        private Panel panel3;
        private Label dayLabel;
        private Label label3;
        private Label typeLabel;
        private CustomControls.RoundedButton okBtn;
        private Panel panel6;
        private Label statusLabel;
        private Label label4;
    }
}