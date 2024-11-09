using System.Text.RegularExpressions;

namespace StudentGradeApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // validate input for name
            string nameText = name_textBox1.Text.Trim(); // Remove leading and trailing whitespaces
            if (!IsValidName(nameText))
            {
                resultLabel.Text = "Invalid input. \nPlease enter a valid name without numbers or special characters.";
                return;
            }

            // validate input for grades
            if (!ValidateGrades())
            {
                resultLabel.Text = "Invalid input. \nPlease enter a valid numeric grades.";
                //MessageBox.Show("Please enter valid numeric grades.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // extract grades from textboxes
            double[] grades = {
                double.Parse(eng_textBox2.Text),
                double.Parse(math_textBox3.Text),
                double.Parse(sci_textBox4.Text),
                double.Parse(fil_textBox5.Text),
                double.Parse(his_textBox6.Text)
            };

            double sum = 0;
            foreach (double grade in grades)
            {
                sum += grade;
            }

            // calculate average grade
            double averageGrade = sum / grades.Length;

            // determine pass or fail using ternary operator
            string result = averageGrade >= 50 ? "The student passed." : "The student failed.";

            // display result
            //MessageBox.Show($"Average Grade: {averageGrade:F2}\nResult: {result}", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            resultLabel.Text = $"{result}\nThe general average of {nameText} is {averageGrade:F2}";
        }

        private bool ValidateGrades()
        {
            // Validate each grade textbox for numeric input
            if (!double.TryParse(eng_textBox2.Text, out _))
                return false;
            if (!double.TryParse(math_textBox3.Text, out _))
                return false;
            if (!double.TryParse(sci_textBox4.Text, out _))
                return false;
            if (!double.TryParse(fil_textBox5.Text, out _))
                return false;
            if (!double.TryParse(his_textBox6.Text, out _))
                return false;

            return true;
        }

        private bool IsValidName(string name)
        {
            // Regular expression pattern to match only letters
            string pattern = @"^[A-Za-z]+$";

            // Check if the name matches the pattern
            return Regex.IsMatch(name, pattern);
        }
    }
}
