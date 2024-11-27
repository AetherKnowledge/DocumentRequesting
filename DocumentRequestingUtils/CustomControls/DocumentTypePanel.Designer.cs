namespace DocumentRequestingUtils.CustomControls
{
    partial class DocumentTypePanel
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
            Button = new DocumentRequesting.CustomControls.RoundedButton();
            SuspendLayout();
            // 
            // Button
            // 
            Button.BorderColor = Color.Black;
            Button.BorderRadius = 0;
            Button.BorderThickness = 1;
            Button.ButtonColor = Color.FromArgb(212, 231, 197);
            Button.Dock = DockStyle.Fill;
            Button.FlatAppearance.BorderSize = 0;
            Button.FlatStyle = FlatStyle.Flat;
            Button.Font = new Font("Arial", 26.25F);
            Button.HoverColor = Color.FromArgb(148, 161, 137);
            Button.IconLocation = DocumentRequesting.CustomControls.RoundedButton.ImageLocation.Center;
            Button.Image = null;
            Button.ImageSize = new Size(0, 0);
            Button.Location = new Point(20, 20);
            Button.Name = "Button";
            Button.PressedColor = Color.FromArgb(103, 112, 95);
            Button.Size = new Size(258, 258);
            Button.TabIndex = 6;
            Button.Text = "Certificate of Enrollment\r\n(COE)";
            Button.UseVisualStyleBackColor = true;
            // 
            // DocumentTypePanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(Button);
            Name = "DocumentTypePanel";
            Padding = new Padding(20);
            Size = new Size(298, 298);
            ResumeLayout(false);
        }

        #endregion

        public DocumentRequesting.CustomControls.RoundedButton Button;
    }
}
