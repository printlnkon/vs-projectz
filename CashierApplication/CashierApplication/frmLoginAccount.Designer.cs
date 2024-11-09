namespace CashierApplication
{
    partial class frmLoginAccount
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
            username_label = new Label();
            login_button = new Button();
            username_textBox = new TextBox();
            password_textBox = new TextBox();
            password_label = new Label();
            showhidepassword_checkBox = new CheckBox();
            SuspendLayout();
            // 
            // username_label
            // 
            username_label.AutoSize = true;
            username_label.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            username_label.Location = new Point(12, 21);
            username_label.Name = "username_label";
            username_label.Size = new Size(106, 25);
            username_label.TabIndex = 0;
            username_label.Text = "Username:";
            // 
            // login_button
            // 
            login_button.BackColor = Color.MidnightBlue;
            login_button.FlatStyle = FlatStyle.Popup;
            login_button.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_button.ForeColor = Color.White;
            login_button.Location = new Point(12, 163);
            login_button.Name = "login_button";
            login_button.Size = new Size(209, 45);
            login_button.TabIndex = 1;
            login_button.Text = "Login";
            login_button.TextAlign = ContentAlignment.TopCenter;
            login_button.UseVisualStyleBackColor = false;
            login_button.Click += login_button_Click;
            // 
            // username_textBox
            // 
            username_textBox.BorderStyle = BorderStyle.FixedSingle;
            username_textBox.Cursor = Cursors.IBeam;
            username_textBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            username_textBox.Location = new Point(12, 54);
            username_textBox.Name = "username_textBox";
            username_textBox.Size = new Size(209, 29);
            username_textBox.TabIndex = 2;
            // 
            // password_textBox
            // 
            password_textBox.BorderStyle = BorderStyle.FixedSingle;
            password_textBox.Cursor = Cursors.IBeam;
            password_textBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            password_textBox.Location = new Point(12, 124);
            password_textBox.Name = "password_textBox";
            password_textBox.Size = new Size(209, 29);
            password_textBox.TabIndex = 4;
            password_textBox.UseSystemPasswordChar = true;
            // 
            // password_label
            // 
            password_label.AutoSize = true;
            password_label.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            password_label.Location = new Point(12, 91);
            password_label.Name = "password_label";
            password_label.Size = new Size(102, 25);
            password_label.TabIndex = 3;
            password_label.Text = "Password:";
            // 
            // showhidepassword_checkBox
            // 
            showhidepassword_checkBox.AutoSize = true;
            showhidepassword_checkBox.Location = new Point(200, 131);
            showhidepassword_checkBox.Name = "showhidepassword_checkBox";
            showhidepassword_checkBox.Size = new Size(15, 14);
            showhidepassword_checkBox.TabIndex = 5;
            showhidepassword_checkBox.UseVisualStyleBackColor = true;
            showhidepassword_checkBox.CheckedChanged += showhidepassword_checkBox_CheckedChanged;
            // 
            // frmLoginAccount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(237, 217);
            Controls.Add(showhidepassword_checkBox);
            Controls.Add(password_textBox);
            Controls.Add(password_label);
            Controls.Add(username_textBox);
            Controls.Add(login_button);
            Controls.Add(username_label);
            KeyPreview = true;
            Name = "frmLoginAccount";
            Text = "User Login";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label username_label;
        private Button login_button;
        private TextBox username_textBox;
        private TextBox password_textBox;
        private Label password_label;
        private CheckBox showhidepassword_checkBox;
    }
}