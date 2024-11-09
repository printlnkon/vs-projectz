namespace CashierApplication
{
    partial class Menus
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
            menuStrip = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            exitApplicationToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            PurchaseDiscountItem_buttton = new Button();
            ComputeSalary_button = new Button();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.BackColor = Color.LightGray;
            menuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(295, 24);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { logoutToolStripMenuItem, exitApplicationToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(157, 22);
            logoutToolStripMenuItem.Text = "Logout";
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
            // 
            // exitApplicationToolStripMenuItem
            // 
            exitApplicationToolStripMenuItem.Name = "exitApplicationToolStripMenuItem";
            exitApplicationToolStripMenuItem.Size = new Size(157, 22);
            exitApplicationToolStripMenuItem.Text = "Exit Application";
            exitApplicationToolStripMenuItem.Click += exitApplicationToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(8, 37);
            label1.Name = "label1";
            label1.Size = new Size(70, 30);
            label1.TabIndex = 1;
            label1.Text = "Menu";
            // 
            // PurchaseDiscountItem_buttton
            // 
            PurchaseDiscountItem_buttton.BackColor = Color.DarkBlue;
            PurchaseDiscountItem_buttton.FlatStyle = FlatStyle.Popup;
            PurchaseDiscountItem_buttton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PurchaseDiscountItem_buttton.ForeColor = Color.White;
            PurchaseDiscountItem_buttton.Location = new Point(13, 81);
            PurchaseDiscountItem_buttton.Name = "PurchaseDiscountItem_buttton";
            PurchaseDiscountItem_buttton.Size = new Size(270, 45);
            PurchaseDiscountItem_buttton.TabIndex = 2;
            PurchaseDiscountItem_buttton.Text = "Purchase Discounted Item";
            PurchaseDiscountItem_buttton.UseVisualStyleBackColor = false;
            PurchaseDiscountItem_buttton.Click += PurchaseDiscountItem_buttton_Click;
            // 
            // ComputeSalary_button
            // 
            ComputeSalary_button.BackColor = Color.Goldenrod;
            ComputeSalary_button.FlatStyle = FlatStyle.Popup;
            ComputeSalary_button.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ComputeSalary_button.ForeColor = Color.White;
            ComputeSalary_button.Location = new Point(12, 132);
            ComputeSalary_button.Name = "ComputeSalary_button";
            ComputeSalary_button.Size = new Size(270, 45);
            ComputeSalary_button.TabIndex = 3;
            ComputeSalary_button.Text = "Compute Salary";
            ComputeSalary_button.UseVisualStyleBackColor = false;
            ComputeSalary_button.Click += ComputeSalary_button_Click;
            // 
            // Menus
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(295, 188);
            Controls.Add(ComputeSalary_button);
            Controls.Add(PurchaseDiscountItem_buttton);
            Controls.Add(label1);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            Name = "Menus";
            Text = "Main Menu";
            TopMost = true;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ToolStripMenuItem exitApplicationToolStripMenuItem;
        private Label label1;
        private Button PurchaseDiscountItem_buttton;
        private Button ComputeSalary_button;
    }
}