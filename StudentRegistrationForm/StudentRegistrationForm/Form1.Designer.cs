namespace StudentRegistrationForm
{
    partial class Form1
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
            srf_label = new Label();
            lastName_label = new Label();
            lastName_textBox = new TextBox();
            firstName_label = new Label();
            firstName_textBox = new TextBox();
            middleName_label = new Label();
            middleName_textBox = new TextBox();
            gender_label = new Label();
            male_radioButton = new RadioButton();
            female_radioButton = new RadioButton();
            dob_label = new Label();
            regStud_button = new Button();
            clearButton = new Button();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            label1 = new Label();
            comboBox4 = new ComboBox();
            pictureBox1 = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // srf_label
            // 
            srf_label.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            srf_label.AutoSize = true;
            srf_label.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            srf_label.Location = new Point(23, 17);
            srf_label.Name = "srf_label";
            srf_label.Size = new Size(314, 32);
            srf_label.TabIndex = 0;
            srf_label.Text = "Student Registration Form";
            srf_label.TextAlign = ContentAlignment.TopCenter;
            // 
            // lastName_label
            // 
            lastName_label.AutoSize = true;
            lastName_label.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lastName_label.Location = new Point(12, 60);
            lastName_label.Name = "lastName_label";
            lastName_label.Size = new Size(98, 21);
            lastName_label.TabIndex = 1;
            lastName_label.Text = "Last name *";
            // 
            // lastName_textBox
            // 
            lastName_textBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lastName_textBox.Location = new Point(12, 84);
            lastName_textBox.Name = "lastName_textBox";
            lastName_textBox.Size = new Size(340, 29);
            lastName_textBox.TabIndex = 2;
            // 
            // firstName_label
            // 
            firstName_label.AutoSize = true;
            firstName_label.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            firstName_label.Location = new Point(12, 125);
            firstName_label.Name = "firstName_label";
            firstName_label.Size = new Size(96, 21);
            firstName_label.TabIndex = 3;
            firstName_label.Text = "First name*";
            // 
            // firstName_textBox
            // 
            firstName_textBox.Font = new Font("Segoe UI", 12F);
            firstName_textBox.Location = new Point(12, 149);
            firstName_textBox.Name = "firstName_textBox";
            firstName_textBox.Size = new Size(340, 29);
            firstName_textBox.TabIndex = 4;
            // 
            // middleName_label
            // 
            middleName_label.AutoSize = true;
            middleName_label.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            middleName_label.Location = new Point(12, 190);
            middleName_label.Name = "middleName_label";
            middleName_label.Size = new Size(118, 21);
            middleName_label.TabIndex = 5;
            middleName_label.Text = "Middle name*";
            // 
            // middleName_textBox
            // 
            middleName_textBox.Font = new Font("Segoe UI", 12F);
            middleName_textBox.Location = new Point(12, 214);
            middleName_textBox.Name = "middleName_textBox";
            middleName_textBox.Size = new Size(340, 29);
            middleName_textBox.TabIndex = 6;
            // 
            // gender_label
            // 
            gender_label.AutoSize = true;
            gender_label.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gender_label.Location = new Point(12, 246);
            gender_label.Name = "gender_label";
            gender_label.Size = new Size(76, 21);
            gender_label.TabIndex = 7;
            gender_label.Text = "Gender *";
            // 
            // male_radioButton
            // 
            male_radioButton.AutoSize = true;
            male_radioButton.Font = new Font("Segoe UI", 12F);
            male_radioButton.Location = new Point(94, 245);
            male_radioButton.Name = "male_radioButton";
            male_radioButton.Size = new Size(62, 25);
            male_radioButton.TabIndex = 8;
            male_radioButton.TabStop = true;
            male_radioButton.Text = "Male";
            male_radioButton.UseVisualStyleBackColor = true;
            // 
            // female_radioButton
            // 
            female_radioButton.AutoSize = true;
            female_radioButton.Font = new Font("Segoe UI", 12F);
            female_radioButton.Location = new Point(165, 245);
            female_radioButton.Name = "female_radioButton";
            female_radioButton.Size = new Size(78, 25);
            female_radioButton.TabIndex = 9;
            female_radioButton.TabStop = true;
            female_radioButton.Text = "Female";
            female_radioButton.UseVisualStyleBackColor = true;
            // 
            // dob_label
            // 
            dob_label.AutoSize = true;
            dob_label.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dob_label.Location = new Point(12, 276);
            dob_label.Name = "dob_label";
            dob_label.Size = new Size(118, 21);
            dob_label.TabIndex = 10;
            dob_label.Text = "Date of birth *";
            // 
            // regStud_button
            // 
            regStud_button.BackColor = Color.Crimson;
            regStud_button.FlatStyle = FlatStyle.Flat;
            regStud_button.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            regStud_button.ForeColor = SystemColors.Control;
            regStud_button.Location = new Point(15, 401);
            regStud_button.Name = "regStud_button";
            regStud_button.Size = new Size(160, 48);
            regStud_button.TabIndex = 14;
            regStud_button.Text = "Register student";
            regStud_button.UseVisualStyleBackColor = false;
            regStud_button.Click += regStud_button_Click;
            // 
            // clearButton
            // 
            clearButton.BackColor = Color.DimGray;
            clearButton.FlatStyle = FlatStyle.Flat;
            clearButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clearButton.ForeColor = SystemColors.Control;
            clearButton.Location = new Point(189, 401);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(163, 48);
            clearButton.TabIndex = 18;
            clearButton.Text = "&Clear";
            clearButton.UseVisualStyleBackColor = false;
            clearButton.Click += clearButton_Click;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(15, 300);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(95, 29);
            comboBox1.TabIndex = 20;
            comboBox1.Text = "-Day-";
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(136, 300);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(95, 29);
            comboBox2.TabIndex = 21;
            comboBox2.Text = "-Month-";
            // 
            // comboBox3
            // 
            comboBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(257, 300);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(95, 29);
            comboBox3.TabIndex = 22;
            comboBox3.Text = "-Year-";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(13, 339);
            label1.Name = "label1";
            label1.Size = new Size(154, 21);
            label1.TabIndex = 23;
            label1.Text = "Program to apply *";
            // 
            // comboBox4
            // 
            comboBox4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(15, 363);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(337, 29);
            comboBox4.TabIndex = 24;
            comboBox4.Text = "-Select program-";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackColor = Color.DarkGray;
            pictureBox1.Location = new Point(375, 84);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(218, 213);
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button1.BackColor = Color.LightGray;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(422, 303);
            button1.Name = "button1";
            button1.Size = new Size(123, 23);
            button1.TabIndex = 26;
            button1.Text = "Browse";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(615, 457);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(comboBox4);
            Controls.Add(label1);
            Controls.Add(srf_label);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(clearButton);
            Controls.Add(regStud_button);
            Controls.Add(dob_label);
            Controls.Add(female_radioButton);
            Controls.Add(male_radioButton);
            Controls.Add(gender_label);
            Controls.Add(middleName_textBox);
            Controls.Add(middleName_label);
            Controls.Add(firstName_textBox);
            Controls.Add(firstName_label);
            Controls.Add(lastName_textBox);
            Controls.Add(lastName_label);
            Name = "Form1";
            Text = "frmStudentApplication";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label srf_label;
        private Label lastName_label;
        private TextBox lastName_textBox;
        private Label firstName_label;
        private TextBox firstName_textBox;
        private Label middleName_label;
        private TextBox middleName_textBox;
        private Label gender_label;
        private RadioButton male_radioButton;
        private RadioButton female_radioButton;
        private Label dob_label;
        private Button regStud_button;
        private Button clearButton;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private Label label1;
        private ComboBox comboBox4;
        private PictureBox pictureBox1;
        private OpenFileDialog openFileDialog1;
        private Button button1;
    }
}
