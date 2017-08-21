using System.Text;
using _08.MillitaryElite.Interfaces;

namespace _08.MillitaryElite.Models
{
    public class Spy : ISpy
    {
        public Spy(string id, string firstName, string lastName, int codeNumber)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.CodeNumber = codeNumber;
        }

        public string Id { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public int CodeNumber { get; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Name: {this.FirstName} {this.LastName} Id: {this.Id}");
            sb.Append($"Code Number: {this.CodeNumber}");

            return sb.ToString();
        }
    }
}