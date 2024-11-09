using System;
using System.Windows.Forms;
using static AccountRegistration.StudentInfoClass;

namespace AccountRegistration
{
    public partial class FrmConfirm : Form
    {
        private DelegateText DelProgram, DelLastName, DelFirstName, DelMiddleName, DelAddress;
        private DelegateNumber DelNumAge, DelNumContactNo, DelStudNo;

        public FrmConfirm()
        {
            InitializeComponent();
            FrmRegistration fr = new FrmRegistration();
            DelStudNo = new DelegateNumber(StudentInfoClass.GetStudentNo);  
            DelProgram = new DelegateText(StudentInfoClass.GetProgram);
            DelLastName = new DelegateText(StudentInfoClass.GetLastName);
            DelFirstName = new DelegateText(StudentInfoClass.GetFirstName);
            DelMiddleName = new DelegateText(StudentInfoClass.GetMiddleName);
            DelNumAge = new DelegateNumber(StudentInfoClass.GetAge);                         
            DelNumContactNo = new DelegateNumber(StudentInfoClass.GetContactNo);             
            DelAddress = new DelegateText(StudentInfoClass.GetAddress);
        }

        private void FrmConfirm_Load(object sender, EventArgs e)
        {
            // for display
            label_studNo.Text = "Student no.: " + DelStudNo(StudentInfoClass.StudentNo).ToString();
            label_program.Text = "Program: " + DelProgram(StudentInfoClass.Program);
            label_lastName.Text = "Last name: " + DelLastName(StudentInfoClass.LastName);
            label_firstName.Text = "First name: " + DelFirstName(StudentInfoClass.FirstName);
            label_middleName.Text = "Middle name: " + DelMiddleName(StudentInfoClass.MiddleName);
            label_age.Text = "Age: " + DelNumAge(StudentInfoClass.Age).ToString();
            label_contactNo.Text = "Contact no.: " + DelNumContactNo(StudentInfoClass.ContactNo).ToString();
            label_address.Text = "Address: " + DelAddress(StudentInfoClass.Address);
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
            this.DialogResult = DialogResult.OK;
            this.Show();
        }
    }
}
