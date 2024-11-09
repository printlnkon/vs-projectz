using System;
using System.Collections;
using System.Windows.Forms;

namespace BasicQueuingCashier
{
    public partial class CashierWindowQueueForm : Form
    {
        public CashierWindowQueueForm()
        {
            InitializeComponent();
            Timer timer = new Timer();
            timer.Interval = (1 * 1000);
            timer.Tick += new EventHandler(timer1_Tick);
            timer.Start();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);
        }

        public void DisplayCashierQueue(IEnumerable CashierList)
        {
            listCashierQueue.Items.Clear();
            foreach (Object obj in CashierList)
            {
                listCashierQueue.Items.Add(obj.ToString());
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                if (CashierClass.CashierQueue.Count > 0)
                {
                    // get the next number to serve
                    string nextNumber = (string)CashierClass.CashierQueue.Peek();

                    // show CustomerView form
                    if (!string.IsNullOrEmpty(nextNumber))
                    {
                        CustomerView cv = new CustomerView(nextNumber);
                        cv.Show();

                        // dequeue the first item from the queue
                        CashierClass.CashierQueue.Dequeue();

                        // refresh the queue display to reflect the updated queue
                        DisplayCashierQueue(CashierClass.CashierQueue);
                    }
                    else
                    {
                        MessageBox.Show("Error: No valid number to serve.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("The queue is empty. No one to serve.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);
        }
    }
}
