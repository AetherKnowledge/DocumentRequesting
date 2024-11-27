namespace DocumentRequestingAdmin.Popup
{
    partial class SetDatePopup
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
            panel2 = new Panel();
            label1 = new Label();
            panel3 = new Panel();
            label3 = new Label();
            timePicker = new DateTimePicker();
            label2 = new Label();
            datePicker = new DateTimePicker();
            DeclineBtn = new DocumentRequesting.CustomControls.RoundedButton();
            acceptBtn = new DocumentRequesting.CustomControls.RoundedButton();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(249, 248, 235);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(DeclineBtn);
            panel1.Controls.Add(acceptBtn);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(454, 260);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(22, 19);
            panel2.Name = "panel2";
            panel2.Size = new Size(410, 165);
            panel2.TabIndex = 3;
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(408, 123);
            label1.TabIndex = 0;
            label1.Text = "YOUR DOCUMENT IS READY FOR CLAIMING! PLEASE PROCEED TO REGISTAR OFFICE. ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.Controls.Add(label3);
            panel3.Controls.Add(timePicker);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(datePicker);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 123);
            panel3.Name = "panel3";
            panel3.Size = new Size(408, 40);
            panel3.TabIndex = 1;
            // 
            // label3
            // 
            label3.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(203, 14);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 3;
            label3.Text = "TIME:";
            label3.TextAlign = ContentAlignment.TopRight;
            // 
            // timePicker
            // 
            timePicker.Format = DateTimePickerFormat.Time;
            timePicker.Location = new Point(262, 10);
            timePicker.Name = "timePicker";
            timePicker.ShowUpDown = true;
            timePicker.Size = new Size(122, 23);
            timePicker.TabIndex = 2;
            // 
            // label2
            // 
            label2.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 14);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 1;
            label2.Text = "DATE:";
            label2.TextAlign = ContentAlignment.TopRight;
            // 
            // datePicker
            // 
            datePicker.Format = DateTimePickerFormat.Short;
            datePicker.Location = new Point(58, 10);
            datePicker.Name = "datePicker";
            datePicker.Size = new Size(122, 23);
            datePicker.TabIndex = 0;
            // 
            // DeclineBtn
            // 
            DeclineBtn.BackImageSize = new Size(0, 0);
            DeclineBtn.BorderColor = Color.Black;
            DeclineBtn.BorderRadius = 10;
            DeclineBtn.BorderThickness = 1;
            DeclineBtn.ButtonColor = Color.FromArgb(128, 175, 129);
            DeclineBtn.FlatAppearance.BorderSize = 0;
            DeclineBtn.FlatStyle = FlatStyle.Flat;
            DeclineBtn.Font = new Font("Arial", 11F, FontStyle.Bold);
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
            DeclineBtn.Text = "CANCEL";
            DeclineBtn.UseVisualStyleBackColor = true;
            DeclineBtn.Click += DeclineBtn_Click;
            // 
            // acceptBtn
            // 
            acceptBtn.BackImageSize = new Size(0, 0);
            acceptBtn.BorderColor = Color.Black;
            acceptBtn.BorderRadius = 10;
            acceptBtn.BorderThickness = 1;
            acceptBtn.ButtonColor = Color.FromArgb(128, 175, 129);
            acceptBtn.FlatAppearance.BorderSize = 0;
            acceptBtn.FlatStyle = FlatStyle.Flat;
            acceptBtn.Font = new Font("Arial", 11F, FontStyle.Bold);
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
            acceptBtn.Text = "SET DATE";
            acceptBtn.UseVisualStyleBackColor = true;
            acceptBtn.Click += acceptBtn_Click;
            // 
            // SetDatePopup
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.Black;
            ClientSize = new Size(456, 262);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SetDatePopup";
            Padding = new Padding(1);
            StartPosition = FormStartPosition.CenterParent;
            Text = "SetDatePopup";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DocumentRequesting.CustomControls.RoundedButton DeclineBtn;
        private DocumentRequesting.CustomControls.RoundedButton acceptBtn;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private Label label3;
        private DateTimePicker timePicker;
        private Label label2;
        private DateTimePicker datePicker;
    }
}