using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.ComparingObjects
{
    public class Startup
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var people = new List<Person>();

            while (input != "END")
            {
                var tokens = input.Split().ToArray();
                var person = new Person(tokens[0], int.Parse(tokens[1]), tokens[2]);
                people.Add(person);

                input = Console.ReadLine();
            }

            var index = int.Parse(Console.ReadLine()) - 1;

            var otherPerson = people[index];
            var count = 0;

            foreach (var person in people)
            {
                if (otherPerson.CompareTo(person) == 0)
                {
                    count++;
                }
            }

            if (count == 1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.Write("{0} ", count);
                Console.Write($"{people.Count - count} ");
                Console.WriteLine(people.Count);
            }
        }
    }
}
