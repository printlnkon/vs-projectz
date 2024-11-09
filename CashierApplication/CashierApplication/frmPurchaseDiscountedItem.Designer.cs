namespace CashierApplication
{
    partial class frmPurchaseDiscountedItem
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
            item_textBox = new TextBox();
            label2 = new Label();
            price_textBox = new TextBox();
            label3 = new Label();
            discount_textBox = new TextBox();
            label4 = new Label();
            quantity_textBox = new TextBox();
            computeDiscount_Button = new Button();
            clear_Button = new Button();
            label5 = new Label();
            label6 = new Label();
            paymentreceived_textBox = new TextBox();
            submit_Button = new Button();
            label7 = new Label();
            file_menuStrip = new MenuStrip();
            file_ToolStripMenuItem = new ToolStripMenuItem();
            menusToolStripMenuItem = new ToolStripMenuItem();
            logout_toolStripMenuItem = new ToolStripMenuItem();
            exitApplicationToolStripMenuItem = new ToolStripMenuItem();
            file_menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(9, 33);
            label1.Name = "label1";
            label1.Size = new Size(64, 30);
            label1.TabIndex = 0;
            label1.Text = "Item:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // item_textBox
            // 
            item_textBox.BorderStyle = BorderStyle.FixedSingle;
            item_textBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            item_textBox.Location = new Point(14, 63);
            item_textBox.Name = "item_textBox";
            item_textBox.Size = new Size(188, 29);
            item_textBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(9, 95);
            label2.Name = "label2";
            label2.Size = new Size(67, 30);
            label2.TabIndex = 2;
            label2.Text = "Price:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // price_textBox
            // 
            price_textBox.BorderStyle = BorderStyle.FixedSingle;
            price_textBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            price_textBox.Location = new Point(81, 96);
            price_textBox.Name = "price_textBox";
            price_textBox.Size = new Size(121, 29);
            price_textBox.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(218, 33);
            label3.Name = "label3";
            label3.Size = new Size(146, 30);
            label3.TabIndex = 4;
            label3.Text = "Discount (%):";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // discount_textBox
            // 
            discount_textBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            discount_textBox.BorderStyle = BorderStyle.FixedSingle;
            discount_textBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            discount_textBox.Location = new Point(223, 66);
            discount_textBox.Name = "discount_textBox";
            discount_textBox.Size = new Size(222, 29);
            discount_textBox.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(220, 102);
            label4.Name = "label4";
            label4.Size = new Size(105, 30);
            label4.TabIndex = 6;
            label4.Text = "Quantity:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // quantity_textBox
            // 
            quantity_textBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            quantity_textBox.BorderStyle = BorderStyle.FixedSingle;
            quantity_textBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            quantity_textBox.Location = new Point(329, 102);
            quantity_textBox.Name = "quantity_textBox";
            quantity_textBox.Size = new Size(116, 29);
            quantity_textBox.TabIndex = 7;
            // 
            // computeDiscount_Button
            // 
            computeDiscount_Button.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            computeDiscount_Button.BackColor = Color.MidnightBlue;
            computeDiscount_Button.FlatStyle = FlatStyle.Popup;
            computeDiscount_Button.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            computeDiscount_Button.ForeColor = Color.White;
            computeDiscount_Button.Location = new Point(14, 148);
            computeDiscount_Button.Name = "computeDiscount_Button";
            computeDiscount_Button.Size = new Size(431, 43);
            computeDiscount_Button.TabIndex = 8;
            computeDiscount_Button.Text = "Compute Discount";
            computeDiscount_Button.TextAlign = ContentAlignment.TopCenter;
            computeDiscount_Button.UseVisualStyleBackColor = false;
            computeDiscount_Button.Click += computeDiscount_Button_Click;
            // 
            // clear_Button
            // 
            clear_Button.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            clear_Button.BackColor = Color.Firebrick;
            clear_Button.FlatStyle = FlatStyle.Popup;
            clear_Button.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clear_Button.ForeColor = Color.White;
            clear_Button.Location = new Point(343, 197);
            clear_Button.Name = "clear_Button";
            clear_Button.Size = new Size(102, 31);
            clear_Button.TabIndex = 9;
            clear_Button.Text = "&Clear";
            clear_Button.TextAlign = ContentAlignment.TopCenter;
            clear_Button.UseVisualStyleBackColor = false;
            clear_Button.Click += clear_Button_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(9, 231);
            label5.Name = "label5";
            label5.Size = new Size(150, 30);
            label5.TabIndex = 10;
            label5.Text = "Total amount:";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(9, 269);
            label6.Name = "label6";
            label6.Size = new Size(191, 30);
            label6.TabIndex = 11;
            label6.Text = "Payment received:";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // paymentreceived_textBox
            // 
            paymentreceived_textBox.BorderStyle = BorderStyle.FixedSingle;
            paymentreceived_textBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            paymentreceived_textBox.Location = new Point(200, 269);
            paymentreceived_textBox.Name = "paymentreceived_textBox";
            paymentreceived_textBox.Size = new Size(125, 29);
            paymentreceived_textBox.TabIndex = 12;
            // 
            // submit_Button
            // 
            submit_Button.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            submit_Button.BackColor = Color.SlateGray;
            submit_Button.FlatStyle = FlatStyle.Popup;
            submit_Button.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            submit_Button.ForeColor = Color.White;
            submit_Button.Location = new Point(343, 269);
            submit_Button.Name = "submit_Button";
            submit_Button.Size = new Size(102, 30);
            submit_Button.TabIndex = 13;
            submit_Button.Text = "Submit";
            submit_Button.TextAlign = ContentAlignment.TopCenter;
            submit_Button.UseVisualStyleBackColor = false;
            submit_Button.Click += submit_Button_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(10, 309);
            label7.Name = "label7";
            label7.Size = new Size(93, 30);
            label7.TabIndex = 14;
            label7.Text = "Change:";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // file_menuStrip
            // 
            file_menuStrip.BackColor = Color.LightGray;
            file_menuStrip.Items.AddRange(new ToolStripItem[] { file_ToolStripMenuItem });
            file_menuStrip.Location = new Point(0, 0);
            file_menuStrip.Name = "file_menuStrip";
            file_menuStrip.Size = new Size(463, 24);
            file_menuStrip.TabIndex = 15;
            // 
            // file_ToolStripMenuItem
            // 
            file_ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menusToolStripMenuItem, logout_toolStripMenuItem, exitApplicationToolStripMenuItem });
            file_ToolStripMenuItem.Name = "file_ToolStripMenuItem";
            file_ToolStripMenuItem.Size = new Size(37, 20);
            file_ToolStripMenuItem.Text = "File";
            // 
            // menusToolStripMenuItem
            // 
            menusToolStripMenuItem.Name = "menusToolStripMenuItem";
            menusToolStripMenuItem.Size = new Size(180, 22);
            menusToolStripMenuItem.Text = "Menu";
            menusToolStripMenuItem.Click += menusToolStripMenuItem_Click;
            // 
            // logout_toolStripMenuItem
            // 
            logout_toolStripMenuItem.Name = "logout_toolStripMenuItem";
            logout_toolStripMenuItem.Size = new Size(180, 22);
            logout_toolStripMenuItem.Text = "Logout";
            logout_toolStripMenuItem.Click += file_toolStripMenuItem_Click;
            // 
            // exitApplicationToolStripMenuItem
            // 
            exitApplicationToolStripMenuItem.Name = "exitApplicationToolStripMenuItem";
            exitApplicationToolStripMenuItem.Size = new Size(180, 22);
            exitApplicationToolStripMenuItem.Text = "Exit Application";
            exitApplicationToolStripMenuItem.Click += exitApplicationToolStripMenuItem_Click;
            // 
            // frmPurchaseDiscountedItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(463, 349);
            Controls.Add(file_menuStrip);
            Controls.Add(label7);
            Controls.Add(submit_Button);
            Controls.Add(paymentreceived_textBox);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(clear_Button);
            Controls.Add(computeDiscount_Button);
            Controls.Add(quantity_textBox);
            Controls.Add(label4);
            Controls.Add(discount_textBox);
            Controls.Add(label3);
            Controls.Add(price_textBox);
            Controls.Add(label2);
            Controls.Add(item_textBox);
            Controls.Add(label1);
            MainMenuStrip = file_menuStrip;
            Name = "frmPurchaseDiscountedItem";
            Text = "frmPurchaseDiscountedItem";
            TopMost = true;
            file_menuStrip.ResumeLayout(false);
            file_menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox item_textBox;
        private Label label2;
        private TextBox price_textBox;
        private Label label3;
        private TextBox discount_textBox;
        private Label label4;
        private TextBox quantity_textBox;
        private Button computeDiscount_Button;
        private Button clear_Button;
        private Label label5;
        private Label label6;
        private TextBox paymentreceived_textBox;
        private Button submit_Button;
        private Label label7;
        private MenuStrip file_menuStrip;
        private ToolStripMenuItem file_ToolStripMenuItem;
        private ToolStripMenuItem logout_toolStripMenuItem;
        private ToolStripMenuItem exitApplicationToolStripMenuItem;
        private ToolStripMenuItem menusToolStripMenuItem;
    }
}
