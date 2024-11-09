using System;
using System.Windows.Forms;

namespace AccountRegistration
{
    public partial class FrmRegistration : Form
    {
        public long studNo, age, contactNo;
        public string program, lastname, firstname, middlename, address;
        public FrmRegistration()
        {
            InitializeComponent();
            cb_program.Items.Add("Bachelor of Science in Information Technology");
            cb_program.Items.Add("Bachelor of Science in Computer Science");
            cb_program.Items.Add("Bachelor of Science in Information Systems");
            cb_program.Items.Add("Bachelor of Science in Accounting Information Technology");
            cb_program.Items.Add("Bachelor of Science in Hospitality Management");
            cb_program.Items.Add("Bachelor of Science in Computer Engineering");
            cb_program.Items.Add("Bachelor of Science in Accountancy");
            cb_program.Items.Add("Bachelor of Science in Psychology");
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            //StudentInfoClass.StudentNo = Int64.Parse(txt_studNo.Text);
            StudentInfoClass.StudentNo = studNo;
            if (!long.TryParse(txt_studNo.Text, out studNo))
            {
                MessageBox.Show("Please enter valid student no.", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return;
            }

            //StudentInfoClass.Program = program;
            StudentInfoClass.Program = cb_program.Text.ToString();
            StudentInfoClass.LastName = txt_lastName.Text.ToString();
            StudentInfoClass.FirstName = txt_firstName.Text.ToString();
            StudentInfoClass.MiddleName = txt_middleName.Text.ToString();

            //StudentInfoClass.Age = Int64.Parse(txt_age.Text);
            StudentInfoClass.Age = age;
            if (!long.TryParse(txt_age.Text, out age))
            {
                MessageBox.Show("Please enter valid age.", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return;
            }

            //StudentInfoClass.ContactNo = Int64.Parse(txt_contactNo.Text);
            StudentInfoClass.ContactNo = contactNo;
            if (!long.TryParse(txt_contactNo.Text, out contactNo))
            {
                MessageBox.Show("Please enter valid contact no.", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return;
            }

            StudentInfoClass.Address = txt_address.Text.ToString();

            this.DialogResult = DialogResult.OK;
            this.Show();
            FrmConfirm fcm = new FrmConfirm();
            fcm.ShowDialog();
        }
    }

    public class StudentInfoClass
    {
        public delegate long DelegateNumber(long number);
        public delegate string DelegateText(string txt);

        public static string FirstName = " ";
        public static string LastName = " ";
        public static string MiddleName = " ";
        public static string Address = " ";
        public static string Program = " ";
        public static long Age = 0;
        public static long ContactNo = 0;
        public static long StudentNo = 0;

        public static string GetFirstName(string FirstName)
        {
            return FirstName;
        }
        public static string GetLastName(string LastName)
        {
            return LastName;
        }
        public static string GetMiddleName(string MiddleName)
        {
            return MiddleName;
        }
        public static string GetAddress(string Address)
        {
            return Address;
        }
        public static string GetProgram(string Program)
        {
            return Program;
        }
        public static long GetAge(long Age)
        {
            return Age;
        }
        public static long GetContactNo(long ContactNo)
        {
            return ContactNo;
        }
        public static long GetStudentNo(long StudentNo)
        {
            return StudentNo;
        }

    }
}
