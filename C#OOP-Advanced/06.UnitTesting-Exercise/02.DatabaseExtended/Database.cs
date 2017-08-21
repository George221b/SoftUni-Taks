using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.DatabaseExtended
{
    public class Database
    {
        private const int DataCapacity = 16;
        private List<Person> data;

        public Database(params Person[] people)
        {
            if (people.Length <= DataCapacity)
            {
                this.data = new List<Person>(people);
            }
            else
            {
                throw new InvalidOperationException($"People can't be more than {DataCapacity} characters long.");
            }
        }

        public int Count => this.data.Count;

        public void Add(Person person)
        {
            if (this.data.Count >= DataCapacity)
            {
                throw new InvalidOperationException("Can't add more elements.");
            }
            if (this.data.Any(p => p.Id == person.Id))
            {
                throw new InvalidOperationException("There's already a person with this id.");
            }
            if (this.data.Any(p => p.Username == person.Username))
            {
                throw new InvalidOperationException("There's already a person with this username.");
            }

            this.data.Add(person);
        }

        public void Remove()
        {
            if (this.data.Count == 0 || this.data == null)
            {
                throw new InvalidOperationException("Data is empty.");
            }

            this.data.Remove(this.data[this.data.Count - 1]);
        }

        public Person FindByUsername(string username)
        {
            if (username == null)
            {
                throw new ArgumentNullException(nameof(username), "Person can't be null.");
            }
            if (this.data.All(p => p.Username != username))
            {
                throw new InvalidOperationException("There's no user with this username.");
            }

            return this.data.FirstOrDefault(p => p.Username == username);
        }

        public Person FindById(int id)
        {
            if (id < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(id), "Id can't be negative.");
            }
            if (this.data.All(p => p.Id != id))
            {
                throw new InvalidOperationException("There's no user with this id.");
            }

            return this.data.FindLast(p => p.Id == id);
        }
    }
}
