namespace OrganizationProfile
{
    partial class frmRegistration
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            StudentNo = new Label();
            LastName = new Label();
            FirstName = new Label();
            Birthday = new Label();
            datePickerBirthday = new DateTimePicker();
            Program = new Label();
            Gender = new Label();
            MI = new Label();
            btnRegister = new Button();
            txtStudentNo = new TextBox();
            txtLastName = new TextBox();
            txtAge = new TextBox();
            cbPrograms = new ComboBox();
            txtFirstName = new TextBox();
            txtMiddleInitial = new TextBox();
            cbGender = new ComboBox();
            txtContactNo = new TextBox();
            lblAge = new Label();
            lblContactNo = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(221, 47);
            label1.TabIndex = 0;
            label1.Text = "Registration";
            // 
            // StudentNo
            // 
            StudentNo.AutoSize = true;
            StudentNo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            StudentNo.Location = new Point(23, 79);
            StudentNo.Name = "StudentNo";
            StudentNo.Size = new Size(110, 25);
            StudentNo.TabIndex = 1;
            StudentNo.Text = "Student No.";
            // 
            // LastName
            // 
            LastName.AutoSize = true;
            LastName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LastName.Location = new Point(33, 129);
            LastName.Name = "LastName";
            LastName.Size = new Size(100, 25);
            LastName.TabIndex = 2;
            LastName.Text = "Last Name";
            // 
            // FirstName
            // 
            FirstName.AutoSize = true;
            FirstName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FirstName.Location = new Point(379, 129);
            FirstName.Name = "FirstName";
            FirstName.Size = new Size(102, 25);
            FirstName.TabIndex = 3;
            FirstName.Text = "First Name";
            // 
            // Birthday
            // 
            Birthday.AutoSize = true;
            Birthday.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Birthday.Location = new Point(51, 229);
            Birthday.Name = "Birthday";
            Birthday.Size = new Size(82, 25);
            Birthday.TabIndex = 5;
            Birthday.Text = "Birthday";
            // 
            // datePickerBirthday
            // 
            datePickerBirthday.Location = new Point(139, 231);
            datePickerBirthday.Name = "datePickerBirthday";
            datePickerBirthday.Size = new Size(200, 23);
            datePickerBirthday.TabIndex = 6;
            // 
            // Program
            // 
            Program.AutoSize = true;
            Program.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Program.Location = new Point(396, 79);
            Program.Name = "Program";
            Program.Size = new Size(85, 25);
            Program.TabIndex = 7;
            Program.Text = "Program";
            // 
            // Gender
            // 
            Gender.AutoSize = true;
            Gender.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Gender.Location = new Point(407, 179);
            Gender.Name = "Gender";
            Gender.Size = new Size(74, 25);
            Gender.TabIndex = 8;
            Gender.Text = "Gender";
            // 
            // MI
            // 
            MI.AutoSize = true;
            MI.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MI.Location = new Point(663, 129);
            MI.Name = "MI";
            MI.Size = new Size(38, 25);
            MI.TabIndex = 9;
            MI.Text = "M.I";
            // 
            // btnRegister
            // 
            btnRegister.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.Location = new Point(310, 283);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(171, 45);
            btnRegister.TabIndex = 11;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // txtStudentNo
            // 
            txtStudentNo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStudentNo.Location = new Point(139, 75);
            txtStudentNo.Name = "txtStudentNo";
            txtStudentNo.Size = new Size(200, 29);
            txtStudentNo.TabIndex = 12;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLastName.Location = new Point(139, 129);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(200, 29);
            txtLastName.TabIndex = 13;
            // 
            // txtAge
            // 
            txtAge.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAge.Location = new Point(139, 179);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(82, 29);
            txtAge.TabIndex = 14;
            // 
            // cbPrograms
            // 
            cbPrograms.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbPrograms.FormattingEnabled = true;
            cbPrograms.Location = new Point(487, 75);
            cbPrograms.Name = "cbPrograms";
            cbPrograms.Size = new Size(302, 29);
            cbPrograms.TabIndex = 15;
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFirstName.Location = new Point(487, 129);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(170, 29);
            txtFirstName.TabIndex = 16;
            // 
            // txtMiddleInitial
            // 
            txtMiddleInitial.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMiddleInitial.Location = new Point(707, 129);
            txtMiddleInitial.Name = "txtMiddleInitial";
            txtMiddleInitial.Size = new Size(82, 29);
            txtMiddleInitial.TabIndex = 20;
            // 
            // cbGender
            // 
            cbGender.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbGender.FormattingEnabled = true;
            cbGender.Location = new Point(487, 179);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(82, 29);
            cbGender.TabIndex = 21;
            // 
            // txtContactNo
            // 
            txtContactNo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContactNo.Location = new Point(487, 231);
            txtContactNo.Name = "txtContactNo";
            txtContactNo.Size = new Size(170, 29);
            txtContactNo.TabIndex = 22;
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAge.Location = new Point(88, 183);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(45, 25);
            lblAge.TabIndex = 23;
            lblAge.Text = "Age";
            // 
            // lblContactNo
            // 
            lblContactNo.AutoSize = true;
            lblContactNo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblContactNo.Location = new Point(370, 235);
            lblContactNo.Name = "lblContactNo";
            lblContactNo.Size = new Size(111, 25);
            lblContactNo.TabIndex = 24;
            lblContactNo.Text = "Contact No.";
            // 
            // frmRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(811, 343);
            Controls.Add(lblContactNo);
            Controls.Add(lblAge);
            Controls.Add(txtContactNo);
            Controls.Add(cbGender);
            Controls.Add(txtMiddleInitial);
            Controls.Add(txtFirstName);
            Controls.Add(cbPrograms);
            Controls.Add(txtAge);
            Controls.Add(txtLastName);
            Controls.Add(txtStudentNo);
            Controls.Add(btnRegister);
            Controls.Add(MI);
            Controls.Add(Gender);
            Controls.Add(Program);
            Controls.Add(datePickerBirthday);
            Controls.Add(Birthday);
            Controls.Add(FirstName);
            Controls.Add(LastName);
            Controls.Add(StudentNo);
            Controls.Add(label1);
            Name = "frmRegistration";
            Text = "Organization Profile";
            Load += frmRegistration_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label StudentNo;
        private Label LastName;
        private Label FirstName;
        private Label Birthday;
        private DateTimePicker datePickerBirthday;
        private Label Program;
        private Label Gender;
        private Label MI;
        private Button btnRegister;
        private TextBox txtStudentNo;
        private TextBox txtLastName;
        private TextBox txtAge;
        private ComboBox cbPrograms;
        private TextBox txtFirstName;
        private TextBox txtMiddleInitial;
        private ComboBox cbGender;
        private TextBox txtContactNo;
        private Label lblAge;
        private Label lblContactNo;
    }
}
