namespace AccountRegistration
{
    partial class FrmConfirm
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
            this.label_studNo = new System.Windows.Forms.Label();
            this.label_program = new System.Windows.Forms.Label();
            this.label_lastName = new System.Windows.Forms.Label();
            this.label_firstName = new System.Windows.Forms.Label();
            this.label_middleName = new System.Windows.Forms.Label();
            this.label_age = new System.Windows.Forms.Label();
            this.label_contactNo = new System.Windows.Forms.Label();
            this.label_address = new System.Windows.Forms.Label();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_studNo
            // 
            this.label_studNo.AutoSize = true;
            this.label_studNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_studNo.Location = new System.Drawing.Point(22, 31);
            this.label_studNo.Name = "label_studNo";
            this.label_studNo.Size = new System.Drawing.Size(110, 20);
            this.label_studNo.TabIndex = 1;
            this.label_studNo.Text = "Student No.:";
            // 
            // label_program
            // 
            this.label_program.AutoSize = true;
            this.label_program.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_program.Location = new System.Drawing.Point(22, 77);
            this.label_program.Name = "label_program";
            this.label_program.Size = new System.Drawing.Size(81, 20);
            this.label_program.TabIndex = 5;
            this.label_program.Text = "Program:";
            // 
            // label_lastName
            // 
            this.label_lastName.AutoSize = true;
            this.label_lastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_lastName.Location = new System.Drawing.Point(22, 123);
            this.label_lastName.Name = "label_lastName";
            this.label_lastName.Size = new System.Drawing.Size(100, 20);
            this.label_lastName.TabIndex = 6;
            this.label_lastName.Text = "Last Name:";
            // 
            // label_firstName
            // 
            this.label_firstName.AutoSize = true;
            this.label_firstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_firstName.Location = new System.Drawing.Point(22, 169);
            this.label_firstName.Name = "label_firstName";
            this.label_firstName.Size = new System.Drawing.Size(101, 20);
            this.label_firstName.TabIndex = 7;
            this.label_firstName.Text = "First Name:";
            // 
            // label_middleName
            // 
            this.label_middleName.AutoSize = true;
            this.label_middleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_middleName.Location = new System.Drawing.Point(22, 215);
            this.label_middleName.Name = "label_middleName";
            this.label_middleName.Size = new System.Drawing.Size(117, 20);
            this.label_middleName.TabIndex = 8;
            this.label_middleName.Text = "Middle Name:";
            // 
            // label_age
            // 
            this.label_age.AutoSize = true;
            this.label_age.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_age.Location = new System.Drawing.Point(22, 261);
            this.label_age.Name = "label_age";
            this.label_age.Size = new System.Drawing.Size(46, 20);
            this.label_age.TabIndex = 9;
            this.label_age.Text = "Age:";
            // 
            // label_contactNo
            // 
            this.label_contactNo.AutoSize = true;
            this.label_contactNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_contactNo.Location = new System.Drawing.Point(22, 307);
            this.label_contactNo.Name = "label_contactNo";
            this.label_contactNo.Size = new System.Drawing.Size(109, 20);
            this.label_contactNo.TabIndex = 10;
            this.label_contactNo.Text = "Contact No.:";
            // 
            // label_address
            // 
            this.label_address.AutoSize = true;
            this.label_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_address.Location = new System.Drawing.Point(22, 353);
            this.label_address.Name = "label_address";
            this.label_address.Size = new System.Drawing.Size(80, 20);
            this.label_address.TabIndex = 11;
            this.label_address.Text = "Address:";
            // 
            // btn_Submit
            // 
            this.btn_Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Submit.Location = new System.Drawing.Point(301, 389);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(111, 38);
            this.btn_Submit.TabIndex = 12;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // FrmConfirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 438);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.label_address);
            this.Controls.Add(this.label_contactNo);
            this.Controls.Add(this.label_age);
            this.Controls.Add(this.label_middleName);
            this.Controls.Add(this.label_firstName);
            this.Controls.Add(this.label_lastName);
            this.Controls.Add(this.label_program);
            this.Controls.Add(this.label_studNo);
            this.Name = "FrmConfirm";
            this.Text = "FrmConfirm";
            this.Load += new System.EventHandler(this.FrmConfirm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_studNo;
        private System.Windows.Forms.Label label_program;
        private System.Windows.Forms.Label label_lastName;
        private System.Windows.Forms.Label label_firstName;
        private System.Windows.Forms.Label label_middleName;
        private System.Windows.Forms.Label label_age;
        private System.Windows.Forms.Label label_contactNo;
        private System.Windows.Forms.Label label_address;
        private System.Windows.Forms.Button btn_Submit;
    }
}