using System;
using _06.BirthdayCelebrations.Interfaces;

namespace _06.BirthdayCelebrations.Models
{
    class Pet : IAnimal
    {
        public Pet(string name, string birthday)
        {
            this.Name = name;
            this.Birthday = birthday;
        }

        public string Name { get; private set; }
        public string Birthday { get; private set; }
    }
}
