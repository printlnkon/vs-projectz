using System;
using System.Text.RegularExpressions;
using StudentNamespace;

namespace StudentInfoApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // submit button
        private void submitButton_Click(object sender, EventArgs e)
        {
            string studID = textBox1.Text;
            studID = Regex.Replace(studID, @"\s", ""); // it will remove any whitespace characters from the textbox1
            string lastName = textBox2.Text;
            string firstName = textBox3.Text;

            if (!int.TryParse(studID, out int studentID) || studentID <= 0) // it will check if the student id is valid
            {
                MessageBox.Show("Please enter a valid Student ID.", "Error Submission", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return;
            }

            if (!Regex.IsMatch(lastName, @"^[A-Za-zñÑ.\s]+$")) // it will check if last name is valid
            {
                MessageBox.Show("Please enter a valid Last name.", "Error Submission", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return;
            }

            if (!Regex.IsMatch(firstName, @"^[A-Za-z]+$")) // it will check if first name is valid
            {
                MessageBox.Show("Please enter a valid First name.", "Error Submission", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return;
            }

            for (int i = 0; i < listBox2.Items.Count; i++) // it will check for duplicate entry of student id, last name and first name
            {
                if (listBox1.Items[i].ToString() == studID && listBox2.Items[i].ToString() == lastName && listBox3.Items[i].ToString() == firstName)
                {
                    MessageBox.Show("Student information already exists.\n\tPlease try again.", "Error Submission", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            StudentInfo si1 = new StudentInfo(lastName, firstName); // instantiation of object w/ 2 arguments
            StudentInfo si2 = new StudentInfo(studentID, lastName, firstName); // instantiation of object w/ 3 arguments
            // it will add the submitted input in listboxes
            listBox1.Items.Add(si2.StudentID);
            listBox2.Items.Add(si1.LastName);
            listBox3.Items.Add(si1.FirstName);

            // it will show if submitting information is success
            MessageBox.Show("Submitted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // clear button
        private void clearButton_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                // it will get the selected index from listbox
                int selectedIndex = listBox1.SelectedIndex;

                // it will display the corresponding data clicked by user
                textBox1.Text = listBox1.Items[selectedIndex].ToString(); // StudentID
                textBox2.Text = listBox2.Items[selectedIndex].ToString(); // LastName
                textBox3.Text = listBox3.Items[selectedIndex].ToString(); // FirstName
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex != -1)
            {
                // it will get the selected index from listbox
                int selectedIndex = listBox2.SelectedIndex;

                // it will display the corresponding data clicked by user
                textBox1.Text = listBox1.Items[selectedIndex].ToString(); // StudentID
                textBox2.Text = listBox2.Items[selectedIndex].ToString(); // LastName
                textBox3.Text = listBox3.Items[selectedIndex].ToString(); // FirstName
            }
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox3.SelectedIndex != -1)
            {
                // it will get the selected index from listbox
                int selectedIndex = listBox3.SelectedIndex;

                // it will display the corresponding data clicked by user
                textBox1.Text = listBox1.Items[selectedIndex].ToString(); // StudentID
                textBox2.Text = listBox2.Items[selectedIndex].ToString(); // LastName
                textBox3.Text = listBox3.Items[selectedIndex].ToString(); // FirstName
            }
        }
    }
}

namespace StudentNamespace
{
    public class StudentInfo
    {
        // instance variables
        private int studentID;
        private string lastName;
        private string firstName;

        public int StudentID // encapsulation for studID
        {
            get { return this.studentID; }
            set { this.studentID = value; }
        }

        public string LastName // encapsulation for lastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }

        public string FirstName // encapsulation for firstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }

        public StudentInfo() // default constructor
        {
            this.studentID = 0;
            this.lastName = "no last name";
            this.firstName = "no first name";
        }

        public StudentInfo(string lastName, string firstName) // overloaded constructor w/ 2 parameters
        {
            this.lastName = lastName;
            this.firstName = firstName;
        }

        public StudentInfo(int studentID, string lastName, string firstName) // overloaded constructor w/ 3 parameters
        {
            this.studentID = studentID;
            this.lastName = lastName;
            this.firstName = firstName;
        }
    }
}



