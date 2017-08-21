using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.EqualityLogic
{
    public class Startup
    {
        public static void Main()
        {
            var sortedPeople = new SortedSet<Person>();
            var hashPeople = new HashSet<Person>();

            int numberOfPeople = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfPeople; i++)
            {
                var tokens = Console.ReadLine().Split().ToArray();
                var person = new Person(tokens[0], int.Parse(tokens[1]));

                hashPeople.Add(person);
                sortedPeople.Add(person);
            }

            Console.WriteLine(hashPeople.Count);
            Console.WriteLine(sortedPeople.Count);
        }
    }
}
