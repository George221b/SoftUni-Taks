using System;

namespace _02.DatabaseExtended
{
    public class Person : IComparable<Person>
    {
        public Person(int id, string username)
        {
            this.Id = id;
            this.Username = username;
        }

        public string Username { get; set; }

        public int Id { get; set; }

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

            int usernameComparison = string.Compare(this.Username, other.Username, StringComparison.Ordinal);
            if (usernameComparison != 0)
            {
                return usernameComparison;
            }

            return Id.CompareTo(other.Id);
        }
    }
}
