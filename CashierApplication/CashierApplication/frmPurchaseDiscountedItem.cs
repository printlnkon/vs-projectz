using System;
using System.Text.RegularExpressions;
using ItemNamespace;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CashierApplication
{
    public partial class frmPurchaseDiscountedItem : Form
    {
        private DiscountedItem? Item;

        public frmPurchaseDiscountedItem()
        {
            InitializeComponent();
        }

        private void computeDiscount_Button_Click(object sender, EventArgs e)
        {
            string itemnameInput = item_textBox.Text.Trim();
            string priceInput = price_textBox.Text.Trim().Replace(",", ""); // comma are allowed if inputting amount
            string quantityInput = quantity_textBox.Text.Trim();
            string discountInput = discount_textBox.Text.Trim();

            if (string.IsNullOrEmpty(itemnameInput) || Regex.IsMatch(itemnameInput, @"\d")) // invalidate if there are whitespace or numbers
            {
                MessageBox.Show("Invalid input. Please input a item name.", "Invalid Item Name", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(priceInput, out double itemPrice) || itemPrice < 1) // invalidate if there's no price
            {
                MessageBox.Show("Invalid input. Please input a price.", "Invalid Price", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(discountInput, out double itemDiscount) || itemDiscount < 0 || itemDiscount > 100) // invalidate if there's no discount
            {
                MessageBox.Show("Invalid input. Please input a discount.", "Invalid Discount", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(quantityInput, out int itemQuantity) || itemQuantity < 1) // invalidate if there's no quantity
            {
                MessageBox.Show("Invalid input. Please input a quantity.", "Invalid Quantity", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return;
            }

            Item = new DiscountedItem(itemnameInput, itemPrice, itemQuantity, itemDiscount); // set the values into DiscountedItems parameters
            double totalPrice = Item.getTotalPrice(); // get the total price that was set by the user
            label5.Text = $"Total amount: {totalPrice:C}"; // show the total amount
        }

        private void clear_Button_Click(object sender, EventArgs e)
        {
            item_textBox.Clear();
            discount_textBox.Clear();
            price_textBox.Clear();
            quantity_textBox.Clear();
            label5.Text = "Total amount: ";
            label7.Text = "Change: ";
            paymentreceived_textBox.Clear();
        }

        private void submit_Button_Click(object sender, EventArgs e)
        {
            if (Item == null) // invalidate if the required fields (item name, price, discount, and quantity are empty
            {
                MessageBox.Show("Please compute the total amount first.", "Invalid Input Fields", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return;
            }

            string paymentInput = paymentreceived_textBox.Text.Trim().Replace(",", ""); // comma are allowed if inputting amount
            double paymentAmount;

            if (!double.TryParse(paymentInput, out paymentAmount) || paymentAmount < 0) // invalidate if the input is not valid
            {
                MessageBox.Show("Please enter a payment amount.", "Invalid Amount", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return;
            }

            Item.setPayment(paymentAmount); // set the values into setPayment parameters
            double change = Item.getChange(); // get the change that was calculated
            label7.Text = $"Change: {change:C}"; // show the change
        }


        private void menusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide(); // hide frmpurchasediscounteditem
            Menus menus = new Menus();
            menus.ShowDialog();
        }
        private void file_toolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have successfully logged out.", "Logout", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide(); // hide the frmpurchasediscounteditem
            frmLoginAccount loginAccount = new frmLoginAccount();
            loginAccount.ShowDialog(); // display frmLoginAccount
        }

        private void exitApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); // directly exit program
        }
    }
}

namespace ItemNamespace
{
    public abstract class Item
    {
        protected string item_name;
        protected double item_price;
        protected int item_quantity;
        protected double total_price;

        public Item(string name, double price, int quantity)
        {
            this.item_name = name;
            this.item_price = price;
            this.item_quantity = quantity;
            total_price = item_price * item_quantity;
        }

        public abstract double getTotalPrice();
        public abstract void setPayment(double amount);
    }

    public class DiscountedItem : Item
    {
        private double item_discount;
        private double discounted_price;
        private double payment_amount;
        private double change;

        public DiscountedItem(string name, double price, int quantity, double discount) : base (name, price, quantity)
        {
            this.item_discount = discount;
            discounted_price = price - (price * (discount * 0.01));
        }

        public override double getTotalPrice()
        {
            return discounted_price * item_quantity;
        }

        public override void setPayment(double amount)
        {
            this.payment_amount = amount;
            change = payment_amount - getTotalPrice();
        }

        public double getChange()
        {
            return change;
        }

        public double getDiscountedPrice()
        {
            return discounted_price;
        }
    }
}
