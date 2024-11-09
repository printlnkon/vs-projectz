using System.Collections;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StudentRegistrationForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void regStud_button_Click(object sender, EventArgs e)
        {
            string firstName = firstName_textBox.Text.Trim();
            string middleName = middleName_textBox.Text.Trim();
            string lastName = lastName_textBox.Text.Trim();
            if (!IsValidName(firstName, middleName, lastName))
            {
                // validation message if there's an error
                MessageBox.Show("Please enter a valid name without numbers or special characters.", "Registration Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return;
            }
            // Check if any of the name fields are blank
            if (string.IsNullOrWhiteSpace(firstName) && string.IsNullOrWhiteSpace(middleName) && string.IsNullOrWhiteSpace(lastName))
            {
                MessageBox.Show("Please enter a value for all name fields.", "Registration Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return;
            }

            // determine gender if male or female
            string? genderMorF;
            if (male_radioButton.Checked)
            {
                genderMorF = "Male";
            }
            else if (female_radioButton.Checked)
            {
                genderMorF = "Female";
            }
            else
            {
                MessageBox.Show("Please select a gender.", "Registration Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return;
                //genderMorF = "Non-binary";
            }

            // check if date of birth is selected
            if (comboBox1.SelectedIndex == -1 || comboBox2.SelectedIndex == -1 || comboBox3.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a date of birth.", "Registration Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return;
            }

            // check if program to apply is selected
            if (comboBox4.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a program to apply.", "Registration Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return;
            }

            string? selectedDayString = comboBox1.SelectedItem.ToString();
            string? selectedMonthString = comboBox2.SelectedItem.ToString();
            int? selectedYear = (int)comboBox3.SelectedItem;
            string? selectedProgramString = comboBox4.SelectedItem.ToString();

            // display all information
            MessageBox.Show($"Student name: {firstName} {middleName} {lastName}\nGender: {genderMorF}\nDate of birth: {selectedDayString}/{selectedMonthString}/{selectedYear}\nProgram: {selectedProgramString}", "Student Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // determine if the input names are valid
        private bool IsValidName(string firstName, string middleName, string lastName)
        {
            // regular expression pattern to match only letters
            string pattern = @"^[A-Za-z]+$";

            // check if the name matches the pattern
            bool isFirstNameValid = Regex.IsMatch(firstName, pattern);
            bool isMiddleNameValid = Regex.IsMatch(middleName, pattern);
            bool isLastNameValid = Regex.IsMatch(lastName, pattern);

            // return true if all parts of the name are valid, otherwise return false
            return isFirstNameValid && isMiddleNameValid && isLastNameValid;
        }

        // clear button function
        private void clearButton_Click(object sender, EventArgs e)
        {
            lastName_textBox.Text = "";
            firstName_textBox.Text = "";
            middleName_textBox.Text = "";
            male_radioButton.Checked = false;
            female_radioButton.Checked = false;

            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            comboBox4.SelectedIndex = -1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // day combobox
            // comboBox1.Items.Add("-Day-");
            for (int day = 1; day <= 31; day++)
            {
                string formattedDay = day.ToString("00");
                comboBox1.Items.Add(formattedDay);
            }
            // month combobox
            ArrayList ListofMonths = new ArrayList()
            {
                "January",
                "February",
                "March",
                "April",
                "May",
                "June",
                "July",
                "August",
                "September",
                "October",
                "November",
                "December",
            };

            // comboBox2.Items.Add("-Month-");
            foreach (string months in ListofMonths)
            {
                comboBox2.Items.Add(months);
            }

            //comboBox2.Items.Add("-Month-");
            //for (int month = 1; month <= 12; month++)
            //{
            //    string formattedMonth = month.ToString("00");
            //    comboBox2.Items.Add(formattedMonth);
            //    //mos. from 1-9 should be 01 to 09
            //}

            // year combobox
            // comboBox3.Items.Add("-Year-");
            int currentYear = DateTime.Now.Year;
            for (int year = 1900; year <= currentYear; year++)
            {
                comboBox3.Items.Add(year);
            }
            // program to apply combobox
            ArrayList ListofPrograms = new ArrayList()
            {
                "Bachelor of Science in Computer Science",
                "Bachelor of Science in Information Technology",
                "Bachelor of Science in Information Systems",
                "Bachelor of Science in Computer Engineering"
            };

            // comboBox4.Items.Add("-Select program-");
            foreach (string bsPrograms in ListofPrograms)
            {
                comboBox4.Items.Add(bsPrograms);
            }
        }
    }
}
