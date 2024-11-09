using System;
using System.Windows.Forms;

namespace BasicQueuingCashier
{
    public partial class QueuingForm : Form
    {
        CashierClass cashier;
        public QueuingForm()
        {
            InitializeComponent();
            cashier = new CashierClass();
        }

        private void btnCashier_Click(object sender, EventArgs e)
        {
            try
            {
                string generatedNumber = cashier.CashierGeneratedNumber("P - ");
                if (!string.IsNullOrEmpty(generatedNumber))
                {
                    lblQueue.Text = generatedNumber;
                    CashierClass.getNumberInQueue = lblQueue.Text;
                    CashierClass.CashierQueue.Enqueue(CashierClass.getNumberInQueue);
                }
                else
                {
                    MessageBox.Show("Error: Unable to generate queue number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
