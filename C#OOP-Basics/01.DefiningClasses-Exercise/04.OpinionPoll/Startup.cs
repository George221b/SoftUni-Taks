using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.OpinionPoll
{
    public class Startup
    {
        public static void Main()
        {
            int numberOfPersonsToRead = int.Parse(Console.ReadLine());
            var people = new HashSet<Person>();
            for (int i = 0; i < numberOfPersonsToRead; i++)
            {
                var inputArgs = Console.ReadLine().Split();

                var member = new Person(inputArgs[0], int.Parse(inputArgs[1]));
                people.Add(member);
            }

            foreach (var person in people
                .Where(p => p.Age > 30)
                .OrderBy(p => p.Name))
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }
}
