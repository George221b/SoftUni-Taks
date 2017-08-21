using _08.MillitaryElite.Interfaces;

namespace _08.MillitaryElite.Models
{
    public class Private : IPrivate
    {
        public Private(string id, string firstName, string lastName, double salary)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Salary = salary;
        }

        public string Id { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public double Salary { get; }

        public override string ToString()
        {
            return $"Name: {this.FirstName} {this.LastName} Id: {this.Id} Salary: {this.Salary:F2}";
        }
    }
}
