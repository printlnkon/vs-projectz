using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using EmployeeNamespace;

namespace EmployeeNamespace
{
    public class Employee
    {
        private int emp_ID;
        private string firstName, lastName, position;

        public int Emp_ID
        {
            get { return emp_ID; }
            set { emp_ID = value; }
        }
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string Position
        {
            get { return position; }
            set { position = value; }
        }

        public Employee(int emp_ID, string firstName, string lastName, string position)
        {
            this.Emp_ID = emp_ID;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Position = position;
        }
    }
}
