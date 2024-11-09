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

            // check if any of the name fields are blank
            if (string.IsNullOrWhiteSpace(firstName) && string.IsNullOrWhiteSpace(middleName) && string.IsNullOrWhiteSpace(lastName))
            {
                MessageBox.Show("Please enter a value for all name fields.", "Registration Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return;
            }

            // determine gender if male or female
            string? genderMorF = null;
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
            }

            // check if date of birth is selected
            // check if day is selected
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a valid day.", "Registration Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return;
            }
            // check if month is selected
            if (comboBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a valid month.", "Registration Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return;
            }
            // check if year is selected
            if (comboBox3.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a valid year.", "Registration Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return;
            }

            // check if program to apply is selected
            if (comboBox4.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a program to apply.", "Registration Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return;
            }

            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Please upload a image.", "Registration Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return;
            }

            string? selectedDay = comboBox1.SelectedItem.ToString();
            string? selectedMonth = comboBox2.SelectedItem.ToString();
            int? selectedYear = (int)comboBox3.SelectedItem;
            string? selectedProgram = comboBox4.SelectedItem.ToString();

            // display information
            DisplayStudInfo(firstName, middleName, lastName, genderMorF, selectedDay, selectedMonth, (int)selectedYear, selectedProgram);
            DisplayStudInfo(firstName, middleName, lastName, selectedProgram);
            DisplayStudInfo("Photo uploaded successfully.");
        }

        // overloaded that display full information
        private void DisplayStudInfo(string firstName, string middleName, string lastName, string gender, string day, string month, int year, string program)
        {
            MessageBox.Show($"Student name: {firstName} {middleName} {lastName}\nGender: {gender}\nDate of birth: {day}/{month}/{year}\nProgram: {program}", "Student Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // overloaded method that display full name and program
        private void DisplayStudInfo(string firstName, string middleName, string lastName, string program)
        {
            MessageBox.Show($"Student name: {firstName} {middleName} {lastName}\nProgram: {program}", "Student Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // overloaded method that the photo has been uploaded
        private void DisplayStudInfo(string message)
        {
            MessageBox.Show($"{message}", "Student Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            pictureBox1.Image = null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // day combobox
            for (int day = 1; day <= 31; day++)
            {
                string formattedDay = day.ToString("00");
                comboBox1.Items.Add(formattedDay);
            }

            // month combobox
            string[] ListofMonths = new string[]
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
                "December"
            };

            foreach (string month in ListofMonths)
            {
                comboBox2.Items.Add(month);
            }

            // year combobox
            int currentYear = DateTime.Now.Year;
            // two-dimensional array to hold years from 1900 to current year
            int[,] yearsArray = new int[currentYear - 1899, 1]; // size is currentYear - 1900 + 1

            // add the array with years from 1900 to current year
            for (int year = 1900; year <= currentYear; year++)
            {
                yearsArray[year - 1900, 0] = year;
            }

            // add years from the array to the comboBox3
            for (int i = 0; i < yearsArray.GetLength(0); i++)
            {
                comboBox3.Items.Add(yearsArray[i, 0]);
            }

            // program to apply combobox
            ArrayList ListofPrograms = new ArrayList()
            {
                "Bachelor of Science in Computer Science",
                "Bachelor of Science in Information Technology",
                "Bachelor of Science in Information Systems",
                "Bachelor of Science in Computer Engineering"
            };

            foreach (string bsPrograms in ListofPrograms)
            {
                comboBox4.Items.Add(bsPrograms);
            }
        }
        // browse photo function
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Image img = Image.FromFile(ofd.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Image = img;
            }
        }
    }
}
