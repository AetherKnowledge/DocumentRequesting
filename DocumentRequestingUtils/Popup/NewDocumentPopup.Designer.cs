namespace DocumentRequestingUtils.Popup
{
    partial class NewDocumentPopup
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
            label1 = new Label();
            nameBox = new TextBox();
            abvBox = new TextBox();
            label2 = new Label();
            CancelBtn = new DocumentRequesting.CustomControls.RoundedButton();
            addBtn = new DocumentRequesting.CustomControls.RoundedButton();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Arial", 9.75F);
            label1.Location = new Point(12, 31);
            label1.Name = "label1";
            label1.Size = new Size(129, 18);
            label1.TabIndex = 0;
            label1.Text = "Document Name:";
            label1.TextAlign = ContentAlignment.TopRight;
            // 
            // nameBox
            // 
            nameBox.Font = new Font("Arial", 9.75F);
            nameBox.Location = new Point(147, 28);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(280, 22);
            nameBox.TabIndex = 1;
            // 
            // abvBox
            // 
            abvBox.Font = new Font("Arial", 9.75F);
            abvBox.Location = new Point(147, 60);
            abvBox.Name = "abvBox";
            abvBox.Size = new Size(280, 22);
            abvBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.Font = new Font("Arial", 9.75F);
            label2.Location = new Point(12, 63);
            label2.Name = "label2";
            label2.Size = new Size(129, 18);
            label2.TabIndex = 2;
            label2.Text = "Abreviation:";
            label2.TextAlign = ContentAlignment.TopRight;
            // 
            // CancelBtn
            // 
            CancelBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            CancelBtn.BackColor = Color.White;
            CancelBtn.BorderColor = Color.Black;
            CancelBtn.BorderRadius = 10;
            CancelBtn.BorderThickness = 1;
            CancelBtn.ButtonColor = Color.FromArgb(128, 175, 129);
            CancelBtn.FlatAppearance.BorderSize = 0;
            CancelBtn.FlatStyle = FlatStyle.Flat;
            CancelBtn.Font = new Font("Arial", 9.75F);
            CancelBtn.ForeColor = Color.White;
            CancelBtn.HoverColor = Color.FromArgb(89, 122, 90);
            CancelBtn.IconLocation = DocumentRequesting.CustomControls.RoundedButton.ImageLocation.Left;
            CancelBtn.Image = null;
            CancelBtn.ImageSize = new Size(0, 0);
            CancelBtn.Location = new Point(359, 109);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.PressedColor = Color.FromArgb(62, 85, 62);
            CancelBtn.Size = new Size(83, 33);
            CancelBtn.TabIndex = 23;
            CancelBtn.Text = "CANCEL";
            CancelBtn.UseVisualStyleBackColor = false;
            CancelBtn.Click += CancelBtn_Click;
            // 
            // addBtn
            // 
            addBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            addBtn.BackColor = Color.White;
            addBtn.BorderColor = Color.Black;
            addBtn.BorderRadius = 10;
            addBtn.BorderThickness = 1;
            addBtn.ButtonColor = Color.FromArgb(128, 175, 129);
            addBtn.FlatAppearance.BorderSize = 0;
            addBtn.FlatStyle = FlatStyle.Flat;
            addBtn.Font = new Font("Arial", 9.75F);
            addBtn.ForeColor = Color.White;
            addBtn.HoverColor = Color.FromArgb(89, 122, 90);
            addBtn.IconLocation = DocumentRequesting.CustomControls.RoundedButton.ImageLocation.Left;
            addBtn.Image = null;
            addBtn.ImageSize = new Size(0, 0);
            addBtn.Location = new Point(270, 109);
            addBtn.Name = "addBtn";
            addBtn.PressedColor = Color.FromArgb(62, 85, 62);
            addBtn.Size = new Size(83, 33);
            addBtn.TabIndex = 22;
            addBtn.Text = "ADD";
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Click += addBtn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(249, 248, 235);
            panel1.Controls.Add(CancelBtn);
            panel1.Controls.Add(addBtn);
            panel1.Controls.Add(abvBox);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(nameBox);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(454, 154);
            panel1.TabIndex = 24;
            // 
            // NewDocumentPopup
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(456, 156);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "NewDocumentPopup";
            Padding = new Padding(1);
            StartPosition = FormStartPosition.CenterParent;
            Text = "NewDocumentPopup";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox nameBox;
        private TextBox abvBox;
        private Label label2;
        private DocumentRequesting.CustomControls.RoundedButton CancelBtn;
        private DocumentRequesting.CustomControls.RoundedButton addBtn;
        private Panel panel1;
    }
}