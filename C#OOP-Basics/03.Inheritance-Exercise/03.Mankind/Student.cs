using System;
using System.Linq;
using System.Text;

namespace _03.Mankind
{
    public class Student : Human
    {
        private string facultyNumber;

        public Student(string firstName, string lastName, string facultyNumber)
            : base(firstName, lastName)
        {
            this.FacultyNumber = facultyNumber;
        }

        public string FacultyNumber
        {
            get { return this.facultyNumber; }
            set
            {
                if (value.Length < 5 || value.Length > 10
                    || !value.All(char.IsLetterOrDigit))
                {
                    throw new ArgumentException("Invalid faculty number!");
                }

                this.facultyNumber = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("First Name: ").AppendLine(base.FirstName);
            sb.Append("Last Name: ").AppendLine(base.LastName);
            sb.Append("Faculty number: ").AppendLine(this.facultyNumber);

            return sb.ToString();
        }
    }
}
