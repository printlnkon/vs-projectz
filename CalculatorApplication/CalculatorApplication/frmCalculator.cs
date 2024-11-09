using System;
using System.Windows.Forms;

namespace CalculatorApplication
{
    public partial class frmCalculator : Form
    {
        CalculatorClass cal;
        public string select;
        public double num1, num2, output;

        public frmCalculator()
        {
            InitializeComponent();

            // add arithmetic operators to combobox
            cbOperator.Items.Add("+");
            cbOperator.Items.Add("-");
            cbOperator.Items.Add("*");
            cbOperator.Items.Add("/");

            cal = new CalculatorClass();
        }

        private void cbOperator_SelectedIndexChanged(object sender, EventArgs e)
        {
            select = cbOperator.SelectedItem?.ToString(); // assign the select variable to cbOperator's value
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            try
            {
                // parse input values
                if (!double.TryParse(txtBoxInput1.Text, out num1) ||
                    !double.TryParse(txtBoxInput2.Text, out num2))
                {
                    MessageBox.Show("Please enter valid numbers.", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrEmpty(select))
                {
                    MessageBox.Show("Please select an operation.", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    return;
                }

                if (select == "+")
                {
                    cal.Formula = cal.GetSum;
                }
                else if (select == "-")
                {
                    cal.Formula = cal.GetDifference;
                }
                else if (select == "*")
                {
                    cal.Formula = cal.GetProduct;
                }
                else if (select == "/")
                {
                    if (num2 == 0)
                    {
                        MessageBox.Show("Cannot divide by zero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    cal.Formula = cal.GetQuotient;
                }
                else
                {
                    MessageBox.Show("Please select a valid operation.", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    return;
                }

                output = cal.Formula(num1, num2);
                lblDisplayTotal.Text = output.ToString("F2"); // display total w/ 2 decimals displayed
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // clear the inputs
            txtBoxInput1.Clear();
            txtBoxInput2.Clear();
            lblDisplayTotal.Text = "";

            // reset the combobox
            cbOperator.SelectedIndex = -1; // unselect the combobox
            select = string.Empty; // set select/cbOperator to an empty string to prevent errors
        }
    }

    public delegate T Formula<T>(T arg1, T arg2);

    public class CalculatorClass
    {
        public Formula<double> Formula;

        public event Formula<double> CalculateEvent
        {
            add
            {
                Console.WriteLine("Added the Delegate");
            }
            remove
            {
                Console.WriteLine("Removed the Delegate");
            }
        }

        public double GetSum(double a, double b) 
        {
            return a + b;
        }

        public double GetDifference(double a, double b)
        {
            return a - b;
        }

        public double GetProduct(double a, double b)
        {
            return a * b;
        }

        public double GetQuotient(double a, double b)
        {
            return a / b;
        }
    }
}
