using System;
using System.Collections.Generic;
using System.Linq;
using _06.StrategyPattern.Comparators;
using _06.StrategyPattern.Models;

namespace _06.StrategyPattern
{
    public class Startup
    {
        public static void Main()
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            var peopleByName = new SortedSet<Person>(new NameComparator());
            var peopleByAge = new SortedSet<Person>(new AgeComparator());

            for (int i = 0; i < numberOfPeople; i++)
            {
                var tokens = Console.ReadLine().Split().ToArray();
                var person = new Person(tokens[0], int.Parse(tokens[1]));

                peopleByName.Add(person);
                peopleByAge.Add(person);
            }

            foreach (var person in peopleByName)
            {
                Console.WriteLine(person);
            }

            foreach (var person in peopleByAge)
            {
                Console.WriteLine(person);
            }
        }
    }
}
