using DocumentRequestingUtils.CustomControls;

namespace DocumentRequesting.Popup
{
    partial class EditRequestForm
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
            panel12 = new Panel();
            updateBtn = new CustomControls.RoundedButton();
            panel11 = new Panel();
            timeNALabel = new Label();
            timePicker = new NoBorderDatePicker();
            label9 = new Label();
            panel10 = new Panel();
            dateNALabel = new Label();
            datePicker = new NoBorderDatePicker();
            label8 = new Label();
            panel9 = new Panel();
            statusCBox = new CustomControls.RoundedComboBox();
            label7 = new Label();
            panel8 = new Panel();
            typeCBox = new CustomControls.RoundedComboBox();
            label6 = new Label();
            panel7 = new Panel();
            genderBox = new CustomControls.RoundedTextBox();
            label5 = new Label();
            panel6 = new Panel();
            sectionBox = new CustomControls.RoundedTextBox();
            courseBox = new CustomControls.RoundedTextBox();
            label4 = new Label();
            panel5 = new Panel();
            idNumberBox = new CustomControls.RoundedTextBox();
            label3 = new Label();
            panel4 = new Panel();
            lastNameBox = new CustomControls.RoundedTextBox();
            middleNameBox = new CustomControls.RoundedTextBox();
            firstNameBox = new CustomControls.RoundedTextBox();
            label2 = new Label();
            panel3 = new Panel();
            referenceNumberBox = new CustomControls.RoundedTextBox();
            label1 = new Label();
            panel2 = new Panel();
            backBtn = new CustomControls.RoundedButton();
            panel1.SuspendLayout();
            panel12.SuspendLayout();
            panel11.SuspendLayout();
            panel10.SuspendLayout();
            panel9.SuspendLayout();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel12);
            panel1.Controls.Add(panel11);
            panel1.Controls.Add(panel10);
            panel1.Controls.Add(panel9);
            panel1.Controls.Add(panel8);
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(798, 506);
            panel1.TabIndex = 0;
            // 
            // panel12
            // 
            panel12.BorderStyle = BorderStyle.FixedSingle;
            panel12.Controls.Add(updateBtn);
            panel12.Dock = DockStyle.Top;
            panel12.Location = new Point(0, 460);
            panel12.Name = "panel12";
            panel12.Size = new Size(798, 46);
            panel12.TabIndex = 10;
            // 
            // updateBtn
            // 
            updateBtn.BorderColor = Color.Black;
            updateBtn.BorderRadius = 10;
            updateBtn.BorderThickness = 1;
            updateBtn.ButtonColor = Color.FromArgb(128, 175, 129);
            updateBtn.FlatAppearance.BorderSize = 0;
            updateBtn.FlatStyle = FlatStyle.Flat;
            updateBtn.Font = new Font("Arial", 11F, FontStyle.Bold);
            updateBtn.ForeColor = Color.White;
            updateBtn.HoverColor = Color.FromArgb(89, 122, 90);
            updateBtn.IconLocation = CustomControls.RoundedButton.ImageLocation.Center;
            updateBtn.Image = null;
            updateBtn.ImageSize = new Size(0, 0);
            updateBtn.Location = new Point(683, 5);
            updateBtn.Name = "updateBtn";
            updateBtn.PressedColor = Color.FromArgb(62, 85, 62);
            updateBtn.Size = new Size(99, 36);
            updateBtn.TabIndex = 0;
            updateBtn.Text = "UPDATE";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += updateBtn_Click;
            // 
            // panel11
            // 
            panel11.BorderStyle = BorderStyle.FixedSingle;
            panel11.Controls.Add(timeNALabel);
            panel11.Controls.Add(timePicker);
            panel11.Controls.Add(label9);
            panel11.Dock = DockStyle.Top;
            panel11.Location = new Point(0, 414);
            panel11.Name = "panel11";
            panel11.Size = new Size(798, 46);
            panel11.TabIndex = 9;
            // 
            // timeNALabel
            // 
            timeNALabel.Dock = DockStyle.Left;
            timeNALabel.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            timeNALabel.Location = new Point(214, 0);
            timeNALabel.Name = "timeNALabel";
            timeNALabel.Padding = new Padding(8, 0, 0, 0);
            timeNALabel.Size = new Size(240, 44);
            timeNALabel.TabIndex = 3;
            timeNALabel.Text = "N/A";
            timeNALabel.TextAlign = ContentAlignment.MiddleLeft;
            timeNALabel.Visible = false;
            // 
            // timePicker
            // 
            timePicker.CalendarFont = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            timePicker.Font = new Font("Arial", 12F);
            timePicker.Format = DateTimePickerFormat.Time;
            timePicker.Location = new Point(220, 7);
            timePicker.Name = "timePicker";
            timePicker.ShowUpDown = true;
            timePicker.Size = new Size(573, 26);
            timePicker.TabIndex = 9;
            // 
            // label9
            // 
            label9.Dock = DockStyle.Left;
            label9.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(0, 0);
            label9.Name = "label9";
            label9.Size = new Size(214, 44);
            label9.TabIndex = 0;
            label9.Text = "TIME OF CLAIMING:";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel10
            // 
            panel10.BorderStyle = BorderStyle.FixedSingle;
            panel10.Controls.Add(dateNALabel);
            panel10.Controls.Add(datePicker);
            panel10.Controls.Add(label8);
            panel10.Dock = DockStyle.Top;
            panel10.Location = new Point(0, 368);
            panel10.Name = "panel10";
            panel10.Size = new Size(798, 46);
            panel10.TabIndex = 8;
            // 
            // dateNALabel
            // 
            dateNALabel.Dock = DockStyle.Left;
            dateNALabel.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateNALabel.Location = new Point(214, 0);
            dateNALabel.Name = "dateNALabel";
            dateNALabel.Padding = new Padding(8, 0, 0, 0);
            dateNALabel.Size = new Size(240, 44);
            dateNALabel.TabIndex = 4;
            dateNALabel.Text = "N/A";
            dateNALabel.TextAlign = ContentAlignment.MiddleLeft;
            dateNALabel.Visible = false;
            // 
            // datePicker
            // 
            datePicker.BackColor = Color.White;
            datePicker.DropDownAlign = LeftRightAlignment.Right;
            datePicker.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            datePicker.Location = new Point(220, 7);
            datePicker.Name = "datePicker";
            datePicker.RightToLeft = RightToLeft.No;
            datePicker.Size = new Size(576, 26);
            datePicker.TabIndex = 1;
            // 
            // label8
            // 
            label8.Dock = DockStyle.Left;
            label8.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(0, 0);
            label8.Name = "label8";
            label8.Size = new Size(214, 44);
            label8.TabIndex = 0;
            label8.Text = "DAY OF CLAIMING:";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel9
            // 
            panel9.BorderStyle = BorderStyle.FixedSingle;
            panel9.Controls.Add(statusCBox);
            panel9.Controls.Add(label7);
            panel9.Dock = DockStyle.Top;
            panel9.Location = new Point(0, 322);
            panel9.Name = "panel9";
            panel9.Size = new Size(798, 46);
            panel9.TabIndex = 7;
            // 
            // statusCBox
            // 
            statusCBox.BackColor = Color.White;
            statusCBox.BorderColor = Color.White;
            statusCBox.BorderRadius = 1;
            statusCBox.BorderThickness = 1;
            statusCBox.DropdownBackgroundColor = Color.White;
            statusCBox.DropdownBorderColor = Color.Gray;
            statusCBox.DropShadow = false;
            statusCBox.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            statusCBox.Location = new Point(220, -2);
            statusCBox.Name = "statusCBox";
            statusCBox.SelectedIndex = -1;
            statusCBox.SelectedItem = null;
            statusCBox.ShadowColor = Color.FromArgb(128, 0, 0, 0);
            statusCBox.ShadowOffsetX = 3;
            statusCBox.ShadowOffsetY = 3;
            statusCBox.Size = new Size(579, 48);
            statusCBox.TabIndex = 2;
            statusCBox.Text = "roundedComboBox2";
            statusCBox.TextBoxColor = Color.White;
            statusCBox.TextDirection = CustomControls.Direction.Left;
            // 
            // label7
            // 
            label7.Dock = DockStyle.Left;
            label7.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(0, 0);
            label7.Name = "label7";
            label7.Size = new Size(214, 44);
            label7.TabIndex = 0;
            label7.Text = "STATUS:";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel8
            // 
            panel8.BorderStyle = BorderStyle.FixedSingle;
            panel8.Controls.Add(typeCBox);
            panel8.Controls.Add(label6);
            panel8.Dock = DockStyle.Top;
            panel8.Location = new Point(0, 276);
            panel8.Name = "panel8";
            panel8.Size = new Size(798, 46);
            panel8.TabIndex = 6;
            // 
            // typeCBox
            // 
            typeCBox.BackColor = Color.White;
            typeCBox.BorderColor = Color.White;
            typeCBox.BorderRadius = 1;
            typeCBox.BorderThickness = 1;
            typeCBox.DropdownBackgroundColor = Color.White;
            typeCBox.DropdownBorderColor = Color.Gray;
            typeCBox.DropShadow = false;
            typeCBox.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            typeCBox.Location = new Point(220, -2);
            typeCBox.Name = "typeCBox";
            typeCBox.SelectedIndex = -1;
            typeCBox.SelectedItem = null;
            typeCBox.ShadowColor = Color.FromArgb(128, 0, 0, 0);
            typeCBox.ShadowOffsetX = 3;
            typeCBox.ShadowOffsetY = 3;
            typeCBox.Size = new Size(578, 48);
            typeCBox.TabIndex = 1;
            typeCBox.Text = "roundedComboBox1";
            typeCBox.TextBoxColor = Color.White;
            typeCBox.TextDirection = CustomControls.Direction.Left;
            // 
            // label6
            // 
            label6.Dock = DockStyle.Left;
            label6.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(0, 0);
            label6.Name = "label6";
            label6.Size = new Size(214, 44);
            label6.TabIndex = 0;
            label6.Text = "REQUESTING DOCUMENT:";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel7
            // 
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(genderBox);
            panel7.Controls.Add(label5);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(0, 230);
            panel7.Name = "panel7";
            panel7.Size = new Size(798, 46);
            panel7.TabIndex = 5;
            // 
            // genderBox
            // 
            genderBox.BackColor = Color.White;
            genderBox.BorderColor = Color.Black;
            genderBox.BorderRadius = 1;
            genderBox.BorderThickness = 0;
            genderBox.DropShadow = false;
            genderBox.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            genderBox.Lines = new string[]
    {
    "Gender"
    };
            genderBox.Location = new Point(220, 12);
            genderBox.Multiline = true;
            genderBox.Name = "genderBox";
            genderBox.Padding = new Padding(1);
            genderBox.PlaceHolderText = "Gender";
            genderBox.ShadowColor = Color.FromArgb(128, 0, 0, 0);
            genderBox.ShadowOffsetX = 3;
            genderBox.ShadowOffsetY = 3;
            genderBox.Size = new Size(577, 33);
            genderBox.TabIndex = 1;
            genderBox.TextAlign = HorizontalAlignment.Left;
            genderBox.TextBoxColor = Color.White;
            genderBox.UseSystemPasswordChar = false;
            genderBox.WithPlaceHolder = true;
            // 
            // label5
            // 
            label5.Dock = DockStyle.Left;
            label5.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(214, 44);
            label5.TabIndex = 0;
            label5.Text = "GENDER";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(sectionBox);
            panel6.Controls.Add(courseBox);
            panel6.Controls.Add(label4);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 184);
            panel6.Name = "panel6";
            panel6.Size = new Size(798, 46);
            panel6.TabIndex = 4;
            // 
            // sectionBox
            // 
            sectionBox.BackColor = Color.White;
            sectionBox.BorderColor = Color.Black;
            sectionBox.BorderRadius = 1;
            sectionBox.BorderThickness = 0;
            sectionBox.DropShadow = false;
            sectionBox.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sectionBox.Lines = new string[]
    {
    "Section"
    };
            sectionBox.Location = new Point(451, 11);
            sectionBox.Multiline = true;
            sectionBox.Name = "sectionBox";
            sectionBox.Padding = new Padding(1);
            sectionBox.PlaceHolderText = "Year";
            sectionBox.ShadowColor = Color.FromArgb(128, 0, 0, 0);
            sectionBox.ShadowOffsetX = 3;
            sectionBox.ShadowOffsetY = 3;
            sectionBox.Size = new Size(234, 33);
            sectionBox.TabIndex = 2;
            sectionBox.TextAlign = HorizontalAlignment.Left;
            sectionBox.TextBoxColor = Color.White;
            sectionBox.UseSystemPasswordChar = false;
            sectionBox.WithPlaceHolder = true;
            // 
            // courseBox
            // 
            courseBox.BackColor = Color.White;
            courseBox.BorderColor = Color.Black;
            courseBox.BorderRadius = 1;
            courseBox.BorderThickness = 0;
            courseBox.DropShadow = false;
            courseBox.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            courseBox.Lines = new string[]
    {
    "Course"
    };
            courseBox.Location = new Point(220, 12);
            courseBox.Multiline = true;
            courseBox.Name = "courseBox";
            courseBox.Padding = new Padding(1);
            courseBox.PlaceHolderText = "Course";
            courseBox.ShadowColor = Color.FromArgb(128, 0, 0, 0);
            courseBox.ShadowOffsetX = 3;
            courseBox.ShadowOffsetY = 3;
            courseBox.Size = new Size(234, 33);
            courseBox.TabIndex = 1;
            courseBox.TextAlign = HorizontalAlignment.Left;
            courseBox.TextBoxColor = Color.White;
            courseBox.UseSystemPasswordChar = false;
            courseBox.WithPlaceHolder = true;
            // 
            // label4
            // 
            label4.Dock = DockStyle.Left;
            label4.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(214, 44);
            label4.TabIndex = 0;
            label4.Text = "COURSE AND SECTION:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(idNumberBox);
            panel5.Controls.Add(label3);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 138);
            panel5.Name = "panel5";
            panel5.Size = new Size(798, 46);
            panel5.TabIndex = 3;
            // 
            // idNumberBox
            // 
            idNumberBox.BackColor = Color.White;
            idNumberBox.BorderColor = Color.Black;
            idNumberBox.BorderRadius = 1;
            idNumberBox.BorderThickness = 0;
            idNumberBox.DropShadow = false;
            idNumberBox.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            idNumberBox.Lines = new string[]
    {
    "ID Number"
    };
            idNumberBox.Location = new Point(220, 12);
            idNumberBox.Multiline = true;
            idNumberBox.Name = "idNumberBox";
            idNumberBox.Padding = new Padding(1);
            idNumberBox.PlaceHolderText = "ID Number";
            idNumberBox.ShadowColor = Color.FromArgb(128, 0, 0, 0);
            idNumberBox.ShadowOffsetX = 3;
            idNumberBox.ShadowOffsetY = 3;
            idNumberBox.Size = new Size(577, 33);
            idNumberBox.TabIndex = 1;
            idNumberBox.TextAlign = HorizontalAlignment.Left;
            idNumberBox.TextBoxColor = Color.White;
            idNumberBox.UseSystemPasswordChar = false;
            idNumberBox.WithPlaceHolder = true;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Left;
            label3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(214, 44);
            label3.TabIndex = 0;
            label3.Text = "ID NUMBER:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(lastNameBox);
            panel4.Controls.Add(middleNameBox);
            panel4.Controls.Add(firstNameBox);
            panel4.Controls.Add(label2);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 92);
            panel4.Name = "panel4";
            panel4.Size = new Size(798, 46);
            panel4.TabIndex = 2;
            // 
            // lastNameBox
            // 
            lastNameBox.BackColor = Color.White;
            lastNameBox.BorderColor = Color.Black;
            lastNameBox.BorderRadius = 1;
            lastNameBox.BorderThickness = 0;
            lastNameBox.DropShadow = false;
            lastNameBox.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lastNameBox.Lines = new string[]
    {
    "Last Name"
    };
            lastNameBox.Location = new Point(582, 12);
            lastNameBox.Multiline = true;
            lastNameBox.Name = "lastNameBox";
            lastNameBox.Padding = new Padding(1);
            lastNameBox.PlaceHolderText = "Last Name";
            lastNameBox.ShadowColor = Color.FromArgb(128, 0, 0, 0);
            lastNameBox.ShadowOffsetX = 3;
            lastNameBox.ShadowOffsetY = 3;
            lastNameBox.Size = new Size(175, 33);
            lastNameBox.TabIndex = 3;
            lastNameBox.TextAlign = HorizontalAlignment.Left;
            lastNameBox.TextBoxColor = Color.White;
            lastNameBox.UseSystemPasswordChar = false;
            lastNameBox.WithPlaceHolder = true;
            // 
            // middleNameBox
            // 
            middleNameBox.BackColor = Color.White;
            middleNameBox.BorderColor = Color.Black;
            middleNameBox.BorderRadius = 1;
            middleNameBox.BorderThickness = 0;
            middleNameBox.DropShadow = false;
            middleNameBox.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            middleNameBox.Lines = new string[]
    {
    "Middle Name"
    };
            middleNameBox.Location = new Point(401, 12);
            middleNameBox.Multiline = true;
            middleNameBox.Name = "middleNameBox";
            middleNameBox.Padding = new Padding(1);
            middleNameBox.PlaceHolderText = "Middle Name";
            middleNameBox.ShadowColor = Color.FromArgb(128, 0, 0, 0);
            middleNameBox.ShadowOffsetX = 3;
            middleNameBox.ShadowOffsetY = 3;
            middleNameBox.Size = new Size(175, 33);
            middleNameBox.TabIndex = 2;
            middleNameBox.TextAlign = HorizontalAlignment.Left;
            middleNameBox.TextBoxColor = Color.White;
            middleNameBox.UseSystemPasswordChar = false;
            middleNameBox.WithPlaceHolder = true;
            // 
            // firstNameBox
            // 
            firstNameBox.BackColor = Color.White;
            firstNameBox.BorderColor = Color.Black;
            firstNameBox.BorderRadius = 1;
            firstNameBox.BorderThickness = 0;
            firstNameBox.DropShadow = false;
            firstNameBox.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            firstNameBox.Lines = new string[]
    {
    "First Name"
    };
            firstNameBox.Location = new Point(220, 12);
            firstNameBox.Multiline = true;
            firstNameBox.Name = "firstNameBox";
            firstNameBox.Padding = new Padding(1);
            firstNameBox.PlaceHolderText = "First Name";
            firstNameBox.ShadowColor = Color.FromArgb(128, 0, 0, 0);
            firstNameBox.ShadowOffsetX = 3;
            firstNameBox.ShadowOffsetY = 3;
            firstNameBox.Size = new Size(175, 33);
            firstNameBox.TabIndex = 1;
            firstNameBox.TextAlign = HorizontalAlignment.Left;
            firstNameBox.TextBoxColor = Color.White;
            firstNameBox.UseSystemPasswordChar = false;
            firstNameBox.WithPlaceHolder = true;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Left;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(214, 44);
            label2.TabIndex = 0;
            label2.Text = "STUDENT NAME:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(referenceNumberBox);
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 46);
            panel3.Name = "panel3";
            panel3.Size = new Size(798, 46);
            panel3.TabIndex = 1;
            // 
            // referenceNumberBox
            // 
            referenceNumberBox.BackColor = Color.White;
            referenceNumberBox.BorderColor = Color.Black;
            referenceNumberBox.BorderRadius = 1;
            referenceNumberBox.BorderThickness = 0;
            referenceNumberBox.DropShadow = false;
            referenceNumberBox.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            referenceNumberBox.Lines = new string[]
    {
    "Reference Number"
    };
            referenceNumberBox.Location = new Point(220, 11);
            referenceNumberBox.Multiline = true;
            referenceNumberBox.Name = "referenceNumberBox";
            referenceNumberBox.Padding = new Padding(1);
            referenceNumberBox.PlaceHolderText = "Reference Number";
            referenceNumberBox.ShadowColor = Color.FromArgb(128, 0, 0, 0);
            referenceNumberBox.ShadowOffsetX = 3;
            referenceNumberBox.ShadowOffsetY = 3;
            referenceNumberBox.Size = new Size(577, 33);
            referenceNumberBox.TabIndex = 1;
            referenceNumberBox.TextAlign = HorizontalAlignment.Left;
            referenceNumberBox.TextBoxColor = Color.White;
            referenceNumberBox.UseSystemPasswordChar = false;
            referenceNumberBox.WithPlaceHolder = true;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(214, 44);
            label1.TabIndex = 0;
            label1.Text = "REFERENCE NUMBER:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(backBtn);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(798, 46);
            panel2.TabIndex = 0;
            // 
            // backBtn
            // 
            backBtn.BorderColor = Color.Black;
            backBtn.BorderRadius = 0;
            backBtn.BorderThickness = 0;
            backBtn.ButtonColor = Color.White;
            backBtn.Dock = DockStyle.Right;
            backBtn.FlatAppearance.BorderSize = 0;
            backBtn.FlatStyle = FlatStyle.Flat;
            backBtn.HoverColor = Color.Empty;
            backBtn.IconLocation = CustomControls.RoundedButton.ImageLocation.Center;
            backBtn.Image = DocumentRequestingAdmin.Properties.Resources.Picture2;
            backBtn.ImageSize = new Size(40, 40);
            backBtn.Location = new Point(737, 0);
            backBtn.Name = "backBtn";
            backBtn.Padding = new Padding(1);
            backBtn.PressedColor = Color.Empty;
            backBtn.Size = new Size(59, 44);
            backBtn.TabIndex = 1;
            backBtn.UseVisualStyleBackColor = true;
            backBtn.Click += backBtn_Click;
            // 
            // EditRequestForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.Black;
            ClientSize = new Size(800, 508);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EditRequestForm";
            Padding = new Padding(1);
            ShowInTaskbar = false;
            Text = "EditRequestForm";
            panel1.ResumeLayout(false);
            panel12.ResumeLayout(false);
            panel11.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel7.ResumeLayout(false);
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
        private CustomControls.RoundedButton backBtn;
        private Panel panel3;
        private CustomControls.RoundedTextBox referenceNumberBox;
        private Label label1;
        private Panel panel12;
        private Panel panel11;
        private Label label9;
        private Panel panel10;
        private NoBorderDatePicker datePicker;
        private Label label8;
        private Panel panel9;
        private Label label7;
        private Panel panel8;
        private Label label6;
        private Panel panel7;
        private CustomControls.RoundedTextBox genderBox;
        private Label label5;
        private Panel panel6;
        private CustomControls.RoundedTextBox courseBox;
        private Label label4;
        private Panel panel5;
        private CustomControls.RoundedTextBox idNumberBox;
        private Label label3;
        private Panel panel4;
        private CustomControls.RoundedTextBox firstNameBox;
        private Label label2;
        private CustomControls.RoundedButton updateBtn;
        private CustomControls.RoundedComboBox typeCBox;
        private CustomControls.RoundedComboBox statusCBox;
        private Label timeNALabel;
        private Label dateNALabel;
        private CustomControls.RoundedTextBox sectionBox;
        private CustomControls.RoundedTextBox lastNameBox;
        private CustomControls.RoundedTextBox middleNameBox;
        private NoBorderDatePicker timePicker;
    }
}