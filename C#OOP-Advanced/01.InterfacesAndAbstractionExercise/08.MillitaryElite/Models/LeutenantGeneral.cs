using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using _08.MillitaryElite.Interfaces;

namespace _08.MillitaryElite.Models
{
    public class LeutenantGeneral : ILeutenantGeneral
    {
        public LeutenantGeneral(string id, string firstName, string lastName, double salary)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Salary = salary;
            this.Privates = new HashSet<IPrivate>();
        }

        public string Id { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public double Salary { get; }
        public HashSet<IPrivate> Privates { get; private set; }

        public void AddPrivate(IPrivate currentPrivate)
        {
            this.Privates.Add(currentPrivate);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Name: {this.FirstName} {this.LastName} Id: {this.Id} Salary: {this.Salary:F2}");
            sb.AppendLine($"Privates:");
            if (this.Privates.Count > 0)
            {
                sb.Append($"  ");
                sb.Append(string.Join($"{Environment.NewLine}  ", this.Privates));
            }


            return sb.ToString().Trim();
        }
    }
}
