using System;
using System.Collections.Generic;
using System.Text;
using _08.MillitaryElite.Interfaces;

namespace _08.MillitaryElite.Models
{
    public class Commando : ICommando
    {
        private string corps;

        public Commando(string id, string firstName, string lastName, double salary, string corps)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Salary = salary;
            this.Corps = corps;
            this.Missions = new HashSet<Mission>();
        }

        public string Id { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public double Salary { get; }
        public string Corps
        {
            get { return this.corps; }
            private set
            {
                if (value == "Airforces" || value == "Marines")
                {
                    this.corps = value;
                }
                else
                {
                    throw new ArgumentException($"Invalid {nameof(this.Corps)}");
                }
            }
        }
        public HashSet<Mission> Missions { get; }

        public void AddMission(Mission mission)
        {
            this.Missions.Add(mission);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Name: {this.FirstName} {this.LastName} Id: {this.Id} Salary: {this.Salary:F2}");
            sb.AppendLine($"Corps: {this.Corps}");
            sb.AppendLine($"Missions:");
            if (this.Missions.Count > 0)
            {
                sb.Append($"  ");
                sb.Append(string.Join($"{Environment.NewLine}  ", this.Missions));
            }

            return sb.ToString().Trim();
        }
    }
}