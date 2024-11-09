using EmployeeInterface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System;
using System.Text.RegularExpressions;

namespace CashierApplication
{
    public partial class frmComputeSalary : Form
    {
        public frmComputeSalary()
        {
            InitializeComponent();
        }

        private void computeSalary_Button_Click(object sender, EventArgs e)
        {
            string firstNameInput = FN_textBox.Text.Trim();
            string lastNameInput = LN_textBox.Text.Trim();
            string departmentInput = DEPT_textBox.Text.Trim();
            string jobTitleInput = JT_textBox.Text.Trim();
            string ratePerHourInput = RPH_textBox.Text.Trim();
            string hoursWorkedInput = THW_textBox.Text.Trim().Replace(",", "");

            if (string.IsNullOrEmpty(firstNameInput) || Regex.IsMatch(firstNameInput, @"\d")) // invalidate if there are whitespace or numbers
            {
                MessageBox.Show("Invalid input. Please input your first name.", "Invalid First Name", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(lastNameInput) || Regex.IsMatch(lastNameInput, @"\d")) // invalidate if there are whitespace or numbers
            {
                MessageBox.Show("Invalid input. Please input your last name.", "Invalid Last Name", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(departmentInput) || Regex.IsMatch(departmentInput, @"\d")) // invalidate if there are whitespace or numbers
            {
                MessageBox.Show("Invalid input. Please input your department.", "Invalid Department", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(jobTitleInput) || Regex.IsMatch(jobTitleInput, @"\d")) // invalidate if there are whitespace or numbers
            {
                MessageBox.Show("Invalid input. Please input your job title.", "Invalid Job Title", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(ratePerHourInput, out double ratePerHour) || ratePerHour < 1)
            {
                MessageBox.Show("Invalid input. Please input a valid rate per hour.", "Invalid Rate Per Hour", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(hoursWorkedInput, out int hoursWorked) || hoursWorked < 1)
            {
                MessageBox.Show("Invalid input. Please input a valid number of hours worked.", "Invalid Hours Worked", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return;
            }

            PartTimeEmployee pte = new PartTimeEmployee(); // instantiated object PartTimeEmployee
            pte.computeSalary(hoursWorked, ratePerHour);

            firstName_bottomLabel.Text = $"First Name: {firstNameInput}";
            lastName_bottomLabel.Text = $"Last Name: {lastNameInput}";
            double totalSalary = pte.getSalary(); // get the total basic salary of the employee
            basicSalary_bottomLabel.Text = $"Basic Salary: {totalSalary:C}"; // total basic salary

        }

        private void clear_Button_Click(object sender, EventArgs e)
        {
            FN_textBox.Clear();
            LN_textBox.Clear();
            DEPT_textBox.Clear();
            JT_textBox.Clear();
            RPH_textBox.Clear();
            THW_textBox.Clear();
            firstName_bottomLabel.Text = "First Name: ";
            lastName_bottomLabel.Text = "Last Name: ";
            basicSalary_bottomLabel.Text = "Basic Salary: ";
        }

        private void menusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide(); // hide frmComputeSalary
            Menus menus = new Menus();
            menus.ShowDialog();
        }

        private void logotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have successfully logged out.", "Logout", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide(); // hide the menus
            frmLoginAccount loginAccount = new frmLoginAccount();
            loginAccount.ShowDialog(); // display frmLoginAccount
        }

        private void exitApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); // directly exit program
        }

    }
}

namespace EmployeeInterface
{
    public interface IEmployee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
        public string JobTitle { get; set; }
        public double BasicSalary { get; set; }

        public void computeSalary(int hoursWorked, double ratePerHour);
    }

    public class PartTimeEmployee : IEmployee
    {
        private string first_name;
        private string last_name;
        private string department;
        private string job_title;
        private double basic_salary;
        public string FirstName
        {
            get { return first_name; }
            set { first_name = value; }
        }
        public string LastName
        {
            get { return last_name; }
            set { last_name = value; }
        }
        public string Department
        {
            get { return department; }
            set { department = value; }
        }
        public string JobTitle
        {
            get { return job_title; }
            set { job_title = value; }
        }
        public double BasicSalary
        {
            get { return basic_salary; }
            set { basic_salary = value; }
        }

        public void computeSalary(int hoursWorked, double ratePerHour)
        {
            BasicSalary = ratePerHour * hoursWorked;
        }

        public double getSalary()
        {
            return BasicSalary;
        }
    }
}
