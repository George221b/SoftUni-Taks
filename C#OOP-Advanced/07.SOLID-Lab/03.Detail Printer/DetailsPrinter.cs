using System.Text;
using System.Collections.Generic;

namespace _03.Detail_Printer
{

    public class DetailsPrinter
    {
        private IList<Employee> employees;

        public DetailsPrinter(IList<Employee> employees)
        {
            this.employees = employees;
        }

        public string printDetails()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Employee employee in this.employees)
            {
                sb.AppendLine(employee.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}