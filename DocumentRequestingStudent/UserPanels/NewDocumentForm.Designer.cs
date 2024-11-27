namespace DocumentRequesting.RequestFormPanels
{
    partial class NewDocumentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewDocumentForm));
            panel6 = new Panel();
            panel5 = new Panel();
            birthDatePicker = new DateTimePicker();
            label4 = new Label();
            panel4 = new Panel();
            firstNameBox = new TextBox();
            midNameBox = new TextBox();
            lastNameBox = new TextBox();
            label3 = new Label();
            panel3 = new Panel();
            studentIDBox = new TextBox();
            label5 = new Label();
            panel2 = new Panel();
            typeCBox = new ComboBox();
            label2 = new Label();
            genderBox = new TextBox();
            panel1 = new Panel();
            backBtn = new CustomControls.RoundedButton();
            label1 = new Label();
            clearBtn = new CustomControls.RoundedButton();
            saveBtn = new CustomControls.RoundedButton();
            sectionBox = new TextBox();
            courseBox = new TextBox();
            addressBox = new TextBox();
            emailBox = new TextBox();
            mobileNumBox = new TextBox();
            usedBox = new TextBox();
            bottomPanel = new Panel();
            topPanel = new Panel();
            topMainPanel = new Panel();
            iconPanel = new Panel();
            iconPBox = new PictureBox();
            mainPanel = new Panel();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            topPanel.SuspendLayout();
            iconPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPBox).BeginInit();
            mainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(panel5);
            panel6.Controls.Add(panel4);
            panel6.Controls.Add(panel3);
            panel6.Controls.Add(panel2);
            panel6.Controls.Add(genderBox);
            panel6.Controls.Add(panel1);
            panel6.Controls.Add(clearBtn);
            panel6.Controls.Add(saveBtn);
            panel6.Controls.Add(sectionBox);
            panel6.Controls.Add(courseBox);
            panel6.Controls.Add(addressBox);
            panel6.Controls.Add(emailBox);
            panel6.Controls.Add(mobileNumBox);
            panel6.Controls.Add(usedBox);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(100, 10);
            panel6.Name = "panel6";
            panel6.Size = new Size(1078, 543);
            panel6.TabIndex = 5;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top;
            panel5.Controls.Add(birthDatePicker);
            panel5.Controls.Add(label4);
            panel5.Location = new Point(11, 239);
            panel5.Name = "panel5";
            panel5.Size = new Size(1055, 35);
            panel5.TabIndex = 26;
            // 
            // birthDatePicker
            // 
            birthDatePicker.Dock = DockStyle.Left;
            birthDatePicker.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            birthDatePicker.Location = new Point(186, 0);
            birthDatePicker.Name = "birthDatePicker";
            birthDatePicker.Size = new Size(718, 29);
            birthDatePicker.TabIndex = 9;
            // 
            // label4
            // 
            label4.Dock = DockStyle.Left;
            label4.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(186, 35);
            label4.TabIndex = 3;
            label4.Text = "BIRTHDATE:";
            label4.TextAlign = ContentAlignment.TopRight;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top;
            panel4.Controls.Add(firstNameBox);
            panel4.Controls.Add(midNameBox);
            panel4.Controls.Add(lastNameBox);
            panel4.Controls.Add(label3);
            panel4.Location = new Point(11, 201);
            panel4.Name = "panel4";
            panel4.Size = new Size(1055, 35);
            panel4.TabIndex = 25;
            // 
            // firstNameBox
            // 
            firstNameBox.Dock = DockStyle.Left;
            firstNameBox.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            firstNameBox.Location = new Point(642, 0);
            firstNameBox.Name = "firstNameBox";
            firstNameBox.Size = new Size(228, 29);
            firstNameBox.TabIndex = 6;
            firstNameBox.Text = "FIRST NAME";
            firstNameBox.TextAlign = HorizontalAlignment.Center;
            // 
            // midNameBox
            // 
            midNameBox.Dock = DockStyle.Left;
            midNameBox.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            midNameBox.Location = new Point(414, 0);
            midNameBox.Name = "midNameBox";
            midNameBox.Size = new Size(228, 29);
            midNameBox.TabIndex = 7;
            midNameBox.Text = "MIDDLE NAME";
            midNameBox.TextAlign = HorizontalAlignment.Center;
            // 
            // lastNameBox
            // 
            lastNameBox.Dock = DockStyle.Left;
            lastNameBox.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lastNameBox.Location = new Point(186, 0);
            lastNameBox.Name = "lastNameBox";
            lastNameBox.Size = new Size(228, 29);
            lastNameBox.TabIndex = 8;
            lastNameBox.Text = "LAST NAME";
            lastNameBox.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Left;
            label3.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(186, 35);
            label3.TabIndex = 2;
            label3.Text = "NAME:";
            label3.TextAlign = ContentAlignment.TopRight;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top;
            panel3.Controls.Add(studentIDBox);
            panel3.Controls.Add(label5);
            panel3.Location = new Point(11, 166);
            panel3.Name = "panel3";
            panel3.Size = new Size(1058, 35);
            panel3.TabIndex = 24;
            // 
            // studentIDBox
            // 
            studentIDBox.Dock = DockStyle.Left;
            studentIDBox.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            studentIDBox.Location = new Point(186, 0);
            studentIDBox.Name = "studentIDBox";
            studentIDBox.Size = new Size(228, 29);
            studentIDBox.TabIndex = 22;
            studentIDBox.Text = "STUDENT ID";
            studentIDBox.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.Dock = DockStyle.Left;
            label5.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(186, 35);
            label5.TabIndex = 21;
            label5.Text = "STUDENT ID:";
            label5.TextAlign = ContentAlignment.TopRight;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top;
            panel2.Controls.Add(typeCBox);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(60, 90);
            panel2.Name = "panel2";
            panel2.Size = new Size(884, 35);
            panel2.TabIndex = 23;
            // 
            // typeCBox
            // 
            typeCBox.Dock = DockStyle.Left;
            typeCBox.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            typeCBox.FormattingEnabled = true;
            typeCBox.Location = new Point(273, 0);
            typeCBox.Name = "typeCBox";
            typeCBox.Size = new Size(343, 30);
            typeCBox.TabIndex = 4;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Left;
            label2.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(273, 35);
            label2.TabIndex = 1;
            label2.Text = "REQUEST FORM:";
            label2.TextAlign = ContentAlignment.TopRight;
            // 
            // genderBox
            // 
            genderBox.Anchor = AnchorStyles.Top;
            genderBox.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            genderBox.Location = new Point(251, 278);
            genderBox.Name = "genderBox";
            genderBox.Size = new Size(230, 29);
            genderBox.TabIndex = 20;
            genderBox.Text = "GENDER";
            genderBox.TextAlign = HorizontalAlignment.Center;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 175, 129);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(backBtn);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1076, 74);
            panel1.TabIndex = 19;
            // 
            // backBtn
            // 
            backBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            backBtn.BackImageSize = new Size(0, 0);
            backBtn.BorderColor = Color.Black;
            backBtn.BorderRadius = 0;
            backBtn.BorderThickness = 0;
            backBtn.ButtonColor = Color.FromArgb(128, 175, 129);
            backBtn.FlatAppearance.BorderSize = 0;
            backBtn.FlatStyle = FlatStyle.Flat;
            backBtn.HoverColor = Color.FromArgb(89, 122, 90);
            backBtn.IconLocation = CustomControls.RoundedButton.ImageLocation.Center;
            backBtn.Image = DocumentRequestingStudent.Properties.Resources.Picture2;
            backBtn.ImageSize = new Size(47, 47);
            backBtn.Location = new Point(987, 0);
            backBtn.Name = "backBtn";
            backBtn.PressedColor = Color.FromArgb(62, 85, 62);
            backBtn.Size = new Size(87, 72);
            backBtn.TabIndex = 1;
            backBtn.UseVisualStyleBackColor = true;
            backBtn.Click += backBtn_Click;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1074, 72);
            label1.TabIndex = 0;
            label1.Text = "NEW DOCUMENT FORM DETAILS";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // clearBtn
            // 
            clearBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            clearBtn.BackColor = Color.White;
            clearBtn.BackImageSize = new Size(0, 0);
            clearBtn.BorderColor = Color.Black;
            clearBtn.BorderRadius = 5;
            clearBtn.BorderThickness = 1;
            clearBtn.ButtonColor = Color.FromArgb(128, 175, 129);
            clearBtn.FlatAppearance.BorderSize = 0;
            clearBtn.FlatStyle = FlatStyle.Flat;
            clearBtn.Font = new Font("Arial", 12F);
            clearBtn.ForeColor = Color.White;
            clearBtn.HoverColor = Color.FromArgb(89, 122, 90);
            clearBtn.IconLocation = CustomControls.RoundedButton.ImageLocation.Left;
            clearBtn.Image = null;
            clearBtn.ImageSize = new Size(0, 0);
            clearBtn.Location = new Point(833, 494);
            clearBtn.Name = "clearBtn";
            clearBtn.PressedColor = Color.FromArgb(62, 85, 62);
            clearBtn.Size = new Size(91, 33);
            clearBtn.TabIndex = 18;
            clearBtn.Text = "CLEAR";
            clearBtn.UseVisualStyleBackColor = false;
            clearBtn.Click += clearBtn_Click;
            // 
            // saveBtn
            // 
            saveBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            saveBtn.BackColor = Color.White;
            saveBtn.BackImageSize = new Size(0, 0);
            saveBtn.BorderColor = Color.Black;
            saveBtn.BorderRadius = 5;
            saveBtn.BorderThickness = 1;
            saveBtn.ButtonColor = Color.FromArgb(128, 175, 129);
            saveBtn.FlatAppearance.BorderSize = 0;
            saveBtn.FlatStyle = FlatStyle.Flat;
            saveBtn.Font = new Font("Arial", 12F);
            saveBtn.ForeColor = Color.White;
            saveBtn.HoverColor = Color.FromArgb(89, 122, 90);
            saveBtn.IconLocation = CustomControls.RoundedButton.ImageLocation.Left;
            saveBtn.Image = null;
            saveBtn.ImageSize = new Size(0, 0);
            saveBtn.Location = new Point(958, 494);
            saveBtn.Name = "saveBtn";
            saveBtn.PressedColor = Color.FromArgb(62, 85, 62);
            saveBtn.Size = new Size(91, 33);
            saveBtn.TabIndex = 17;
            saveBtn.Text = "SAVE";
            saveBtn.UseVisualStyleBackColor = false;
            saveBtn.Click += saveBtn_Click;
            // 
            // sectionBox
            // 
            sectionBox.Anchor = AnchorStyles.Top;
            sectionBox.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sectionBox.Location = new Point(249, 454);
            sectionBox.Name = "sectionBox";
            sectionBox.Size = new Size(242, 29);
            sectionBox.TabIndex = 15;
            sectionBox.Text = "SECTION";
            sectionBox.TextAlign = HorizontalAlignment.Center;
            // 
            // courseBox
            // 
            courseBox.Anchor = AnchorStyles.Top;
            courseBox.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            courseBox.Location = new Point(249, 419);
            courseBox.Name = "courseBox";
            courseBox.Size = new Size(242, 29);
            courseBox.TabIndex = 14;
            courseBox.Text = "COURSE";
            courseBox.TextAlign = HorizontalAlignment.Center;
            // 
            // addressBox
            // 
            addressBox.Anchor = AnchorStyles.Top;
            addressBox.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addressBox.Location = new Point(249, 384);
            addressBox.Name = "addressBox";
            addressBox.Size = new Size(242, 29);
            addressBox.TabIndex = 13;
            addressBox.Text = "ADDRESS";
            addressBox.TextAlign = HorizontalAlignment.Center;
            // 
            // emailBox
            // 
            emailBox.Anchor = AnchorStyles.Top;
            emailBox.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailBox.Location = new Point(249, 349);
            emailBox.Name = "emailBox";
            emailBox.Size = new Size(242, 29);
            emailBox.TabIndex = 12;
            emailBox.Text = "EMAIL";
            emailBox.TextAlign = HorizontalAlignment.Center;
            // 
            // mobileNumBox
            // 
            mobileNumBox.Anchor = AnchorStyles.Top;
            mobileNumBox.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mobileNumBox.Location = new Point(319, 314);
            mobileNumBox.Name = "mobileNumBox";
            mobileNumBox.Size = new Size(230, 29);
            mobileNumBox.TabIndex = 11;
            mobileNumBox.Text = "MOBILE NUMBER";
            mobileNumBox.TextAlign = HorizontalAlignment.Center;
            // 
            // usedBox
            // 
            usedBox.Anchor = AnchorStyles.Top;
            usedBox.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usedBox.Location = new Point(197, 131);
            usedBox.Name = "usedBox";
            usedBox.Size = new Size(308, 29);
            usedBox.TabIndex = 5;
            usedBox.Text = "WHERE WILL BE USED";
            usedBox.TextAlign = HorizontalAlignment.Center;
            // 
            // bottomPanel
            // 
            bottomPanel.BackColor = Color.FromArgb(128, 175, 129);
            bottomPanel.Dock = DockStyle.Bottom;
            bottomPanel.Location = new Point(1, 661);
            bottomPanel.Name = "bottomPanel";
            bottomPanel.Padding = new Padding(0, 1, 0, 1);
            bottomPanel.Size = new Size(1278, 58);
            bottomPanel.TabIndex = 6;
            // 
            // topPanel
            // 
            topPanel.BackColor = Color.FromArgb(249, 248, 235);
            topPanel.BorderStyle = BorderStyle.FixedSingle;
            topPanel.Controls.Add(topMainPanel);
            topPanel.Controls.Add(iconPanel);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(1, 24);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(1278, 74);
            topPanel.TabIndex = 7;
            // 
            // topMainPanel
            // 
            topMainPanel.Dock = DockStyle.Fill;
            topMainPanel.Location = new Point(114, 0);
            topMainPanel.Name = "topMainPanel";
            topMainPanel.Size = new Size(1162, 72);
            topMainPanel.TabIndex = 3;
            // 
            // iconPanel
            // 
            iconPanel.Controls.Add(iconPBox);
            iconPanel.Dock = DockStyle.Left;
            iconPanel.Location = new Point(0, 0);
            iconPanel.Name = "iconPanel";
            iconPanel.Size = new Size(114, 72);
            iconPanel.TabIndex = 4;
            // 
            // iconPBox
            // 
            iconPBox.Image = (Image)resources.GetObject("iconPBox.Image");
            iconPBox.Location = new Point(0, -10);
            iconPBox.Name = "iconPBox";
            iconPBox.Size = new Size(110, 94);
            iconPBox.SizeMode = PictureBoxSizeMode.StretchImage;
            iconPBox.TabIndex = 0;
            iconPBox.TabStop = false;
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.FromArgb(249, 248, 235);
            mainPanel.Controls.Add(panel6);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(1, 98);
            mainPanel.Name = "mainPanel";
            mainPanel.Padding = new Padding(100, 10, 100, 10);
            mainPanel.Size = new Size(1278, 563);
            mainPanel.TabIndex = 8;
            // 
            // NewDocumentForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1280, 720);
            Controls.Add(mainPanel);
            Controls.Add(topPanel);
            Controls.Add(bottomPanel);
            FormStyle = FormStyles.ActionBar_None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1280, 720);
            Name = "NewDocumentForm";
            Padding = new Padding(1, 24, 1, 1);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            topPanel.ResumeLayout(false);
            iconPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconPBox).EndInit();
            mainPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel6;
        private CustomControls.RoundedButton clearBtn;
        private CustomControls.RoundedButton saveBtn;
        private TextBox sectionBox;
        private TextBox courseBox;
        private TextBox addressBox;
        private TextBox emailBox;
        private TextBox mobileNumBox;
        private DateTimePicker birthDatePicker;
        private TextBox lastNameBox;
        private TextBox midNameBox;
        private TextBox firstNameBox;
        private TextBox usedBox;
        private ComboBox typeCBox;
        private Label label4;
        private Label label3;
        private Label label2;
        private Panel panel1;
        private Label label1;
        private CustomControls.RoundedButton backBtn;
        private Panel bottomPanel;
        private Panel topPanel;
        protected Panel topMainPanel;
        private Panel iconPanel;
        private PictureBox iconPBox;
        protected Panel mainPanel;
        private TextBox genderBox;
        private TextBox studentIDBox;
        private Label label5;
        private Panel panel2;
        private Panel panel3;
        private Panel panel5;
        private Panel panel4;
    }
}