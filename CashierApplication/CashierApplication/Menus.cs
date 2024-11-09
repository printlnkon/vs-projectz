using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashierApplication
{
    public partial class Menus : Form
    {
        public Menus()
        {
            InitializeComponent();
        }

        private void PurchaseDiscountItem_buttton_Click(object sender, EventArgs e)
        {
            this.Hide(); // hide the frmloginaccount
            frmPurchaseDiscountedItem purchaseForm = new frmPurchaseDiscountedItem();
            purchaseForm.ShowDialog(); // display frmpurchasediscounteditem
        }

        private void ComputeSalary_button_Click(object sender, EventArgs e)
        {
            this.Hide(); // hide the frmloginaccount
            frmComputeSalary salaryForm = new frmComputeSalary();
            salaryForm.ShowDialog();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have successfully logged out.", "Logout", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide(); // hide the menus
            frmLoginAccount loginAccount = new frmLoginAccount();
            loginAccount.ShowDialog(); // display frmLoginAccount
        }

        private void exitApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); // directly exit program
        }
 
    }
}
