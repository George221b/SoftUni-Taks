using System;
using System.Collections.Generic;

namespace _07.EqualityLogic
{
    public class Person : IComparable<Person>
    {
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name { get; set; }
        public int Age { get; set; }

        public int CompareTo(Person other)
        {
            if (ReferenceEquals(this, other))
            {
                return 0;
            }
            if (ReferenceEquals(null, other))
            {
                return 1;
            }
            var nameComparison = string.Compare(Name, other.Name, StringComparison.Ordinal);
            if (nameComparison != 0)
            {
                return nameComparison;
            }
            return Age.CompareTo(other.Age);
        }

        public override bool Equals(object obj)
        {
            var other = (Person)obj;
            if (this.Name == other.Name && this.Age == other.Age)
            {
                return true;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return this.Name.GetHashCode() + this.Age.GetHashCode();
        }
    }
}
