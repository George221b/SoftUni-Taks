using System;
using _06.BirthdayCelebrations.Interfaces;

namespace _06.BirthdayCelebrations.Models
{
    public class Citizen : IIdentifiable, IAnimal
    {
        public Citizen(string name, int age, string id, string birthday)
        {
            this.Id = id;
            this.Name = name;
            this.Age = age;
            this.Birthday = birthday;
        }

        public string Id { get; private set; }
        public string Name { get; private set; }
        public string Birthday { get; private set; }
        public int Age { get; private set; }
    }
}
