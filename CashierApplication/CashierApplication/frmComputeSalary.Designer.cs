namespace CashierApplication
{
    partial class frmComputeSalary
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
            firstName_label = new Label();
            lastName_label = new Label();
            ratePerHour_label = new Label();
            jobTitle_label = new Label();
            department_label = new Label();
            totalHoursWorked_label = new Label();
            FN_textBox = new TextBox();
            LN_textBox = new TextBox();
            DEPT_textBox = new TextBox();
            JT_textBox = new TextBox();
            RPH_textBox = new TextBox();
            THW_textBox = new TextBox();
            computeSalary_Button = new Button();
            firstName_bottomLabel = new Label();
            lastName_bottomLabel = new Label();
            basicSalary_bottomLabel = new Label();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            menusToolStripMenuItem = new ToolStripMenuItem();
            logotToolStripMenuItem = new ToolStripMenuItem();
            exitApplicationToolStripMenuItem = new ToolStripMenuItem();
            clear_Button = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // firstName_label
            // 
            firstName_label.AutoSize = true;
            firstName_label.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            firstName_label.Location = new Point(8, 29);
            firstName_label.Name = "firstName_label";
            firstName_label.Size = new Size(119, 30);
            firstName_label.TabIndex = 0;
            firstName_label.Text = "First Name";
            // 
            // lastName_label
            // 
            lastName_label.AutoSize = true;
            lastName_label.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lastName_label.Location = new Point(243, 29);
            lastName_label.Name = "lastName_label";
            lastName_label.Size = new Size(116, 30);
            lastName_label.TabIndex = 1;
            lastName_label.Text = "Last Name";
            // 
            // ratePerHour_label
            // 
            ratePerHour_label.AutoSize = true;
            ratePerHour_label.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ratePerHour_label.Location = new Point(9, 199);
            ratePerHour_label.Name = "ratePerHour_label";
            ratePerHour_label.Size = new Size(148, 30);
            ratePerHour_label.TabIndex = 2;
            ratePerHour_label.Text = "Rate per hour";
            // 
            // jobTitle_label
            // 
            jobTitle_label.AutoSize = true;
            jobTitle_label.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            jobTitle_label.Location = new Point(245, 98);
            jobTitle_label.Name = "jobTitle_label";
            jobTitle_label.Size = new Size(97, 30);
            jobTitle_label.TabIndex = 3;
            jobTitle_label.Text = "Job Title";
            // 
            // department_label
            // 
            department_label.AutoSize = true;
            department_label.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            department_label.Location = new Point(7, 98);
            department_label.Name = "department_label";
            department_label.Size = new Size(131, 30);
            department_label.TabIndex = 4;
            department_label.Text = "Department";
            // 
            // totalHoursWorked_label
            // 
            totalHoursWorked_label.AutoSize = true;
            totalHoursWorked_label.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalHoursWorked_label.Location = new Point(246, 199);
            totalHoursWorked_label.Name = "totalHoursWorked_label";
            totalHoursWorked_label.Size = new Size(203, 30);
            totalHoursWorked_label.TabIndex = 5;
            totalHoursWorked_label.Text = "Total hours worked";
            // 
            // FN_textBox
            // 
            FN_textBox.BorderStyle = BorderStyle.FixedSingle;
            FN_textBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FN_textBox.Location = new Point(12, 61);
            FN_textBox.Name = "FN_textBox";
            FN_textBox.Size = new Size(202, 29);
            FN_textBox.TabIndex = 6;
            // 
            // LN_textBox
            // 
            LN_textBox.BorderStyle = BorderStyle.FixedSingle;
            LN_textBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LN_textBox.Location = new Point(247, 61);
            LN_textBox.Name = "LN_textBox";
            LN_textBox.Size = new Size(202, 29);
            LN_textBox.TabIndex = 7;
            // 
            // DEPT_textBox
            // 
            DEPT_textBox.BorderStyle = BorderStyle.FixedSingle;
            DEPT_textBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DEPT_textBox.Location = new Point(12, 128);
            DEPT_textBox.Name = "DEPT_textBox";
            DEPT_textBox.Size = new Size(202, 29);
            DEPT_textBox.TabIndex = 8;
            // 
            // JT_textBox
            // 
            JT_textBox.BorderStyle = BorderStyle.FixedSingle;
            JT_textBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            JT_textBox.Location = new Point(247, 128);
            JT_textBox.Name = "JT_textBox";
            JT_textBox.Size = new Size(202, 29);
            JT_textBox.TabIndex = 9;
            // 
            // RPH_textBox
            // 
            RPH_textBox.BorderStyle = BorderStyle.FixedSingle;
            RPH_textBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RPH_textBox.Location = new Point(12, 233);
            RPH_textBox.Name = "RPH_textBox";
            RPH_textBox.Size = new Size(202, 29);
            RPH_textBox.TabIndex = 10;
            // 
            // THW_textBox
            // 
            THW_textBox.BorderStyle = BorderStyle.FixedSingle;
            THW_textBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            THW_textBox.Location = new Point(247, 233);
            THW_textBox.Name = "THW_textBox";
            THW_textBox.Size = new Size(202, 29);
            THW_textBox.TabIndex = 11;
            // 
            // computeSalary_Button
            // 
            computeSalary_Button.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            computeSalary_Button.BackColor = Color.MidnightBlue;
            computeSalary_Button.FlatStyle = FlatStyle.Popup;
            computeSalary_Button.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            computeSalary_Button.ForeColor = Color.White;
            computeSalary_Button.Location = new Point(12, 277);
            computeSalary_Button.Name = "computeSalary_Button";
            computeSalary_Button.Size = new Size(437, 43);
            computeSalary_Button.TabIndex = 12;
            computeSalary_Button.Text = "Compute Salary";
            computeSalary_Button.TextAlign = ContentAlignment.TopCenter;
            computeSalary_Button.UseVisualStyleBackColor = false;
            computeSalary_Button.Click += computeSalary_Button_Click;
            // 
            // firstName_bottomLabel
            // 
            firstName_bottomLabel.AutoSize = true;
            firstName_bottomLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            firstName_bottomLabel.Location = new Point(9, 362);
            firstName_bottomLabel.Name = "firstName_bottomLabel";
            firstName_bottomLabel.Size = new Size(112, 25);
            firstName_bottomLabel.TabIndex = 13;
            firstName_bottomLabel.Text = "First Name:";
            // 
            // lastName_bottomLabel
            // 
            lastName_bottomLabel.AutoSize = true;
            lastName_bottomLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lastName_bottomLabel.Location = new Point(9, 402);
            lastName_bottomLabel.Name = "lastName_bottomLabel";
            lastName_bottomLabel.Size = new Size(109, 25);
            lastName_bottomLabel.TabIndex = 14;
            lastName_bottomLabel.Text = "Last Name:";
            // 
            // basicSalary_bottomLabel
            // 
            basicSalary_bottomLabel.AutoSize = true;
            basicSalary_bottomLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            basicSalary_bottomLabel.Location = new Point(9, 442);
            basicSalary_bottomLabel.Name = "basicSalary_bottomLabel";
            basicSalary_bottomLabel.Size = new Size(121, 25);
            basicSalary_bottomLabel.TabIndex = 15;
            basicSalary_bottomLabel.Text = "Basic Salary:";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.LightGray;
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(466, 24);
            menuStrip1.TabIndex = 16;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menusToolStripMenuItem, logotToolStripMenuItem, exitApplicationToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // menusToolStripMenuItem
            // 
            menusToolStripMenuItem.Name = "menusToolStripMenuItem";
            menusToolStripMenuItem.Size = new Size(180, 22);
            menusToolStripMenuItem.Text = "Menu";
            menusToolStripMenuItem.Click += menusToolStripMenuItem_Click;
            // 
            // logotToolStripMenuItem
            // 
            logotToolStripMenuItem.Name = "logotToolStripMenuItem";
            logotToolStripMenuItem.Size = new Size(180, 22);
            logotToolStripMenuItem.Text = "Logout";
            logotToolStripMenuItem.Click += logotToolStripMenuItem_Click;
            // 
            // exitApplicationToolStripMenuItem
            // 
            exitApplicationToolStripMenuItem.Name = "exitApplicationToolStripMenuItem";
            exitApplicationToolStripMenuItem.Size = new Size(180, 22);
            exitApplicationToolStripMenuItem.Text = "Exit Application";
            exitApplicationToolStripMenuItem.Click += exitApplicationToolStripMenuItem_Click;
            // 
            // clear_Button
            // 
            clear_Button.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            clear_Button.BackColor = Color.Firebrick;
            clear_Button.FlatStyle = FlatStyle.Popup;
            clear_Button.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clear_Button.ForeColor = Color.White;
            clear_Button.Location = new Point(347, 326);
            clear_Button.Name = "clear_Button";
            clear_Button.Size = new Size(102, 31);
            clear_Button.TabIndex = 17;
            clear_Button.Text = "&Clear";
            clear_Button.TextAlign = ContentAlignment.TopCenter;
            clear_Button.UseVisualStyleBackColor = false;
            clear_Button.Click += clear_Button_Click;
            // 
            // frmComputeSalary
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(466, 479);
            Controls.Add(clear_Button);
            Controls.Add(basicSalary_bottomLabel);
            Controls.Add(lastName_bottomLabel);
            Controls.Add(firstName_bottomLabel);
            Controls.Add(computeSalary_Button);
            Controls.Add(THW_textBox);
            Controls.Add(RPH_textBox);
            Controls.Add(JT_textBox);
            Controls.Add(DEPT_textBox);
            Controls.Add(LN_textBox);
            Controls.Add(FN_textBox);
            Controls.Add(totalHoursWorked_label);
            Controls.Add(department_label);
            Controls.Add(jobTitle_label);
            Controls.Add(ratePerHour_label);
            Controls.Add(lastName_label);
            Controls.Add(firstName_label);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmComputeSalary";
            Text = "frmComputeSalary";
            TopMost = true;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label firstName_label;
        private Label lastName_label;
        private Label ratePerHour_label;
        private Label jobTitle_label;
        private Label department_label;
        private Label totalHoursWorked_label;
        private TextBox FN_textBox;
        private TextBox LN_textBox;
        private TextBox DEPT_textBox;
        private TextBox JT_textBox;
        private TextBox RPH_textBox;
        private TextBox THW_textBox;
        private Button computeSalary_Button;
        private Label firstName_bottomLabel;
        private Label lastName_bottomLabel;
        private Label basicSalary_bottomLabel;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem menusToolStripMenuItem;
        private ToolStripMenuItem logotToolStripMenuItem;
        private ToolStripMenuItem exitApplicationToolStripMenuItem;
        private Button clear_Button;
    }
}