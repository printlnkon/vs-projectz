using OrganizationalProfile;
using System.Linq.Expressions;
using System.Text.RegularExpressions;

namespace OrganizationProfile
{
    public partial class frmRegistration : Form
    {
        private long _StudentNo;
        private int _ContactNo;
        private string _FullName = "";
        private int _Age;
        public frmRegistration()
        {
            InitializeComponent();
        }

        //return methods 
        public long StudentNumber(string studNum)
        {
            if (string.IsNullOrWhiteSpace(studNum))
            {
                MessageBox.Show("Please fill out student number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }

            try
            {
                _StudentNo = long.Parse(studNum);
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid student number format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return _StudentNo;
        }

        public string ContactNo(string contactNum)
        {
            if (string.IsNullOrWhiteSpace(contactNum))
            {
                MessageBox.Show("Please fill out contact number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return string.Empty;
            }

            if (!long.TryParse(contactNum, out long result))
            {
                MessageBox.Show("Invalid contact number format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return string.Empty;
            }

            return contactNum;
        }

        public string FullName(string lastName, string firstName, string middleInitial)
        {
            if (string.IsNullOrWhiteSpace(lastName) || string.IsNullOrWhiteSpace(firstName))
            {
                MessageBox.Show("Please fill out name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return string.Empty;
            }

            if (!Regex.IsMatch(lastName, @"^[a-zA-Z]+$") || !Regex.IsMatch(firstName, @"^[a-zA-Z]+$") ||
                (!string.IsNullOrEmpty(middleInitial) && !Regex.IsMatch(middleInitial, @"^[a-zA-Z]+$")))
            {
                MessageBox.Show("Invalid name format. Names should only contain alphabetic characters.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return string.Empty;
            }

            _FullName = $"{lastName}, {firstName}, {middleInitial}";
            return _FullName;
        }
        public int Age(string age)
        {
            if (string.IsNullOrWhiteSpace(age))
            {
                MessageBox.Show("Please fill out age.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }

            try
            {
                if (int.TryParse(age, out int parsedAge) && parsedAge > 0 && parsedAge < 120)
                {
                    _Age = parsedAge;
                }
                else
                {
                    MessageBox.Show("Invalid age. Please enter a number between 1 and 120.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid age format.", "Error");
            }

            return _Age;
        }

        private void frmRegistration_Load(object sender, EventArgs e)
        {
            // programs
            string[] ListOfProgram = new string[] {
                "BS Information Technology",
                "BS Computer Science",
                "BS Information Systems",
                "BS in Accountancy",
                "BS in Hospitality Management",
                "BS in Tourism Management"
            };

            for (int i = 0; i < 6; i++)
            {
                cbPrograms.Items.Add(ListOfProgram[i].ToString());
            }

            string[] ListOfGender = new string[] {
                "Male",
                "Female"
            };

            for (int j = 0; j < 2; j++)
            {
                cbGender.Items.Add(ListOfGender[j].ToString());
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                string.IsNullOrWhiteSpace(txtMiddleInitial.Text) ||
                string.IsNullOrWhiteSpace(txtLastName.Text) ||
                string.IsNullOrWhiteSpace(txtStudentNo.Text.ToString()) ||
                string.IsNullOrWhiteSpace(txtAge.Text.ToString()) ||
                string.IsNullOrWhiteSpace(txtContactNo.Text))
            {
                MessageBox.Show("Please fill out all fields.", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            };

            StudentInformationClass.SetGender = cbGender.Text;
            StudentInformationClass.SetFullName = FullName(txtLastName.Text, txtFirstName.Text, txtMiddleInitial.Text);
            StudentInformationClass.SetStudentNo = (int)StudentNumber(txtStudentNo.Text);
            StudentInformationClass.SetContactNo = ContactNo(txtContactNo.Text);
            StudentInformationClass.SetAge = Age(txtAge.Text);

            StudentInformationClass.SetBirthday = datePickerBirthday.Value.ToString("yyyy-MM-dd");
            StudentInformationClass.SetProgram = cbPrograms.Text;
            StudentInformationClass.SetGender = cbGender.Text;

            // show confirmation form
            frmConfirmation frmC = new frmConfirmation();
            frmC.ShowDialog();
        }

    }
}
