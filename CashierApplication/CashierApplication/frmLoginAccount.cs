using System;
using ItemNamespace;
using UserAccountNamespace;

namespace CashierApplication
{
    public partial class frmLoginAccount : Form
    {
        public frmLoginAccount()
        {
            InitializeComponent();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            string username = username_textBox.Text;
            string password = password_textBox.Text;

            Cashier c = new Cashier("Kalfontein Cruz", "Graphic Design Department", "kon", "kon123"); // set the values into Cashier parameters

            if (c.validateLogin(username, password))
            {
                MessageBox.Show($"Welcome {c.getFullName()} of {c.getDepartment()}", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide(); // hide the frmloginaccount
                //frmPurchaseDiscountedItem purchaseForm = new frmPurchaseDiscountedItem();
                //purchaseForm.ShowDialog(); // display frmpurchasediscounteditem
                Menus menus = new Menus();
                menus.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }

        private void showhidepassword_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (password_textBox.UseSystemPasswordChar)
            {
                password_textBox.UseSystemPasswordChar = false; // hide password
            }
            else
            {
                password_textBox.UseSystemPasswordChar = true; // show password
            }
        }

    }
}

namespace UserAccountNamespace
{
    public abstract class UserAccount
    {
        private string full_name;
        protected string user_name;
        protected string user_password;

        public UserAccount(string name, string uName, string password)
        {
            this.full_name = name;
            this.user_name = uName;
            this.user_password = password;
        }

        public abstract bool validateLogin(string uName, string password);

        public string getFullName()
        {
            return full_name;
        }

    }

    public class Cashier : UserAccount
    {
        private string department;
        public Cashier(string name, string department, string uName, string password) : base (name,uName, password)
        {
            this.department = department;
        }
        public override bool validateLogin(string uName, string password)
        {
            return this.user_name == uName && this.user_password == password;
        }

        public string getDepartment()
        {
            return department;
        }
    }
}
