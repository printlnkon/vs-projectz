using System;
using System.Windows.Forms;

namespace BasicQueuingCashier
{
    public partial class CustomerView : Form
    {

        public CustomerView(string nextNumber)
        {
            InitializeComponent();

            if (!string.IsNullOrEmpty(nextNumber))
            {
                lblNextServing.Text = nextNumber;
            }
            else
            {
                MessageBox.Show("Error: No valid queue number to display.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
