using EmployeeNamespace;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using System.Configuration;

namespace EmployeeApplication
{
    public partial class Form1 : Form
    {
        private List<Employee> employees = new List<Employee>();
        public Form1()
        {
            InitializeComponent();

            dataGridView1.Columns.Add("Emp_ID", "ID");
            dataGridView1.Columns.Add("FirstName", "First Name");
            dataGridView1.Columns.Add("LastName", "Last Name");
            dataGridView1.Columns.Add("Position", "Position");

            LoadEmployeesFromDatabase();
        }
        private void LoadEmployeesFromDatabase()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["EmployeeDB"].ConnectionString;
            string query = "SELECT * FROM Employees";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {   
                    int empID = (int)reader["Emp_ID"];
                    string firstName = reader["FirstName"].ToString();
                    string lastName = reader["LastName"].ToString();
                    string position = reader["Position"].ToString();

                    Employee emp = new Employee(empID, firstName, lastName, position);
                    employees.Add(emp);
                    dataGridView1.Rows.Add(emp.Emp_ID, emp.FirstName, emp.LastName, emp.Position);
                }
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            string emp_ID = Regex.Replace(textBox1.Text, @"\s", "");

            string firstName = textBox2.Text;
            string lastName = textBox3.Text;
            string position = textBox4.Text;

            if (!int.TryParse(emp_ID, out int empID) || empID <= 0)
            {
                MessageBox.Show("Please enter a valid Employee ID.", "Employee Application", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return;
            }

            if (!Regex.IsMatch(firstName, @"^[A-Za-z]+$")) // it will check if first name is valid
            {
                MessageBox.Show("Please enter a valid First name.", "Employee Application", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return;
            }

            if (!Regex.IsMatch(lastName, @"^[A-Za-zñÑ.\s]+$")) // it will check if last name is valid
            {
                MessageBox.Show("Please enter a valid Last name.", "Employee Application", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return;
            }

            if (!Regex.IsMatch(position, @"^[A-Za-zñÑ.\s]+$")) // it will check if last name is valid
            {
                MessageBox.Show("Please enter a valid Position.", "Employee Application", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return;
            }

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Emp_ID"].Value != null && row.Cells["Emp_ID"].Value.ToString() == textBox1.Text)
                {
                    MessageBox.Show("Employee information already exists.\n\tPlease try again.", "Error Submission", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    return;
                }
            }

            Employee emp = new Employee(empID, firstName, lastName, position);

            string connectionString = ConfigurationManager.ConnectionStrings["EmployeeDB"].ConnectionString;
            string query = "INSERT INTO Employees (Emp_ID, FirstName, LastName, Position) VALUES (@Emp_ID, @FirstName, @LastName, @Position)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Emp_ID", empID);
                command.Parameters.AddWithValue("@FirstName", firstName);
                command.Parameters.AddWithValue("@LastName", lastName);
                command.Parameters.AddWithValue("@Position", position);

                connection.Open();
                command.ExecuteNonQuery();
            }

            employees.Add(emp);
            dataGridView1.Rows.Add(emp.Emp_ID, emp.FirstName, emp.LastName, emp.Position);

            MessageBox.Show("Successfully submitted.", "Employee Submission", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Set Emp_ID and LastName text boxes to read-only
            textBox1.ReadOnly = true;
            textBox3.ReadOnly = true;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();

            // Make the text boxes editable again
            textBox1.ReadOnly = false;
            textBox3.ReadOnly = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if a valid row is clicked
            if (e.RowIndex >= 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                // Extract data from the selected row
                string empID = selectedRow.Cells["Emp_ID"].Value.ToString();
                string firstName = selectedRow.Cells["FirstName"].Value.ToString();
                string lastName = selectedRow.Cells["LastName"].Value.ToString();
                string position = selectedRow.Cells["Position"].Value.ToString();

                // display the data in the corresponding textboxes
                textBox1.Text = empID;
                textBox2.Text = firstName;
                textBox3.Text = lastName;
                textBox4.Text = position;

                // set Emp_ID and LastName text boxes to read-only
                textBox1.ReadOnly = true;
                textBox3.ReadOnly = true;
            }
        }

    }
}
