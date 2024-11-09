namespace StudentGradeApplication
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
            label1 = new Label();
            name_textBox1 = new TextBox();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            eng_textBox2 = new TextBox();
            math_textBox3 = new TextBox();
            sci_textBox4 = new TextBox();
            fil_textBox5 = new TextBox();
            his_textBox6 = new TextBox();
            resultLabel = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 25);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            // 
            // name_textBox1
            // 
            name_textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            name_textBox1.Location = new Point(70, 22);
            name_textBox1.Name = "name_textBox1";
            name_textBox1.Size = new Size(384, 23);
            name_textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button1.Location = new Point(16, 264);
            button1.Name = "button1";
            button1.Size = new Size(438, 64);
            button1.TabIndex = 2;
            button1.Text = "Generate Average";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 58);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 3;
            label2.Text = "Grades";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 79);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 4;
            label3.Text = "English";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 118);
            label4.Name = "label4";
            label4.Size = new Size(35, 15);
            label4.TabIndex = 5;
            label4.Text = "Math";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 152);
            label5.Name = "label5";
            label5.Size = new Size(47, 15);
            label5.TabIndex = 6;
            label5.Text = "Science";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 185);
            label6.Name = "label6";
            label6.Size = new Size(46, 15);
            label6.TabIndex = 7;
            label6.Text = "Filipino";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(16, 217);
            label7.Name = "label7";
            label7.Size = new Size(45, 15);
            label7.TabIndex = 8;
            label7.Text = "History";
            // 
            // eng_textBox2
            // 
            eng_textBox2.Location = new Point(70, 76);
            eng_textBox2.Name = "eng_textBox2";
            eng_textBox2.Size = new Size(78, 23);
            eng_textBox2.TabIndex = 9;
            // 
            // math_textBox3
            // 
            math_textBox3.Location = new Point(70, 115);
            math_textBox3.Name = "math_textBox3";
            math_textBox3.Size = new Size(78, 23);
            math_textBox3.TabIndex = 10;
            // 
            // sci_textBox4
            // 
            sci_textBox4.Location = new Point(70, 149);
            sci_textBox4.Name = "sci_textBox4";
            sci_textBox4.Size = new Size(78, 23);
            sci_textBox4.TabIndex = 11;
            // 
            // fil_textBox5
            // 
            fil_textBox5.Location = new Point(70, 185);
            fil_textBox5.Name = "fil_textBox5";
            fil_textBox5.Size = new Size(78, 23);
            fil_textBox5.TabIndex = 12;
            // 
            // his_textBox6
            // 
            his_textBox6.Location = new Point(70, 214);
            his_textBox6.Name = "his_textBox6";
            his_textBox6.Size = new Size(78, 23);
            his_textBox6.TabIndex = 13;
            // 
            // resultLabel
            // 
            resultLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            resultLabel.AutoSize = true;
            resultLabel.Location = new Point(183, 149);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(0, 15);
            resultLabel.TabIndex = 14;
            resultLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(475, 344);
            Controls.Add(resultLabel);
            Controls.Add(his_textBox6);
            Controls.Add(fil_textBox5);
            Controls.Add(sci_textBox4);
            Controls.Add(math_textBox3);
            Controls.Add(eng_textBox2);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(name_textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "frmStudentGradeApplication";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox name_textBox1;
        private Button button1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox eng_textBox2;
        private TextBox math_textBox3;
        private TextBox sci_textBox4;
        private TextBox fil_textBox5;
        private TextBox his_textBox6;
        private Label resultLabel;
    }
}
