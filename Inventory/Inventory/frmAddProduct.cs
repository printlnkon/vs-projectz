using System.Text.RegularExpressions;

namespace Inventory
{
    public partial class frmAddProduct : Form
    {
        BindingSource showProductList;
        private string _ProductName, _Category, _MfgDate, _ExpDate, _Description;
        private int _Quantity;
        private double _SellPrice;

        public class StringFormatException : Exception
        {
            public StringFormatException(string productName) : base(productName) { }
        }
        public class NumberFormatException : Exception
        {
            public NumberFormatException(string productQuantity) : base(productQuantity) { }
        }
        public class CurrencyFormatException : Exception
        {
            public CurrencyFormatException(string sellingPrice) : base(sellingPrice) { }
        }

        public frmAddProduct()
        {
            InitializeComponent();
            showProductList = new BindingSource();
        }

        private void frmAddProduct_Load(object sender, EventArgs e)
        {
            string[] ListOfProductCategory = new string[] {
                "Beverages",
                "Bread/Bakery",
                "Canned/Jarred Goods",
                "Dairy",
                "Frozen Goods",
                "Meat",
                "Personal Care",
                "Other"
            };

            foreach (string products in ListOfProductCategory)
            {
                cbCategory.Items.Add(products);
            }
        }


        public string Product_Name(string productName)
        {
            try
            {
                // to ensure spacing is valid
                productName = Regex.Replace(productName.Trim(), @"\s+", " ");

                if (string.IsNullOrWhiteSpace(productName) || !Regex.IsMatch(productName, @"^[a-zA-Z\s]+$"))
                {
                    throw new StringFormatException("Invalid product name. Please fill out product name.");
                }
                return productName;
            }
            catch (StringFormatException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return string.Empty;  // return an empty string if validation fails
            }
        }

        public int Quantity(string productQuantity)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(productQuantity) || !Regex.IsMatch(productQuantity, @"^\d+$"))
                {
                    throw new NumberFormatException("Invalid quantity. Please fill out quantity.");
                }
                return Convert.ToInt32(productQuantity);
            }
            catch (NumberFormatException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;  // return -1 if validation fails
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Invalid input format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }

        public double SellingPrice(string sellingPrice)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(sellingPrice) || !Regex.IsMatch(sellingPrice, @"^\d+(\.\d{1,2})?$"))
                {
                    throw new CurrencyFormatException("Invalid selling price. Please fill out price.");
                }
                return Convert.ToDouble(sellingPrice);
            }
            catch (CurrencyFormatException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1.0;  // return -1.0 if validation fails
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Invalid input format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1.0;
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            // validate product name first
            _ProductName = Product_Name(txtProductName.Text);
            if (string.IsNullOrEmpty(_ProductName))
            {
                return;
            }

            // validate if the product category is selected
            if (cbCategory.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a product category.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // validate product quantity
            _Quantity = Quantity(txtQuantity.Text);
            if (_Quantity <= 0)
            {
                return;
            }

            // Validate selling price
            _SellPrice = SellingPrice(txtSellPrice.Text);
            if (_SellPrice <= 0)
            {
                return;  // Stop execution if validation fails
            }

            _Description = richTxtDescription.Text.Trim();

            if (string.IsNullOrWhiteSpace(_Description))
            {
                MessageBox.Show("Please fill out the product description.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;  // Stop execution if validation fails
            }

            _ProductName = Product_Name(txtProductName.Text);
            _Category = cbCategory.Text;
            _MfgDate = dtPickerMfgDate.Value.ToString("yyyy-MM-dd");
            _ExpDate = dtPickerExpDate.Value.ToString("yyyy-MM-dd");
            _Description = richTxtDescription.Text;

            _Quantity = Quantity(txtQuantity.Text);
            _SellPrice = SellingPrice(txtSellPrice.Text);

            // ensure valid inputs
            if (!string.IsNullOrEmpty(_ProductName) && _Quantity > 0 && _SellPrice > 0)
            {
                showProductList.Add(new ProductClass(_ProductName, _Category, _MfgDate, _ExpDate, _SellPrice, _Quantity, _Description));
            }

            gridViewProductList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridViewProductList.DataSource = showProductList;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // clear the textbox
            txtProductName.Clear();
            txtQuantity.Clear();
            txtSellPrice.Clear();
            // clear richboxtext
            richTxtDescription.Clear();

            // clear combobox
            cbCategory.SelectedIndex = -1;

            // Reset the DatePickers to their default value 
            dtPickerMfgDate.Value = DateTime.Now;
            dtPickerExpDate.Value = DateTime.Now;
        }

    }
}
