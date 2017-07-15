using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.FilterByAge
{
    public class FilterByAge
    {
        public static void Main()
        {
            List<Person> people = ReadInput();

            var olderOrYounger = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());
            var format = Console.ReadLine();

            switch (olderOrYounger)
            {
                case "older":
                    people = people.Where(x => x.Age >= age).ToList();
                    break;
                case "younger":
                    people = people.Where(x => x.Age < age).ToList();
                    break;
            }

            PrintPeopleByGivenFormat(format, people);
        }

        private static void PrintPeopleByGivenFormat(string format, List<Person> people)
        {
            switch (format)
            {
                case "name":
                    people.ForEach(x => Console.WriteLine(x.Name));
                    break;
                case "age":
                    people.ForEach(x => Console.WriteLine(x.Age));
                    break;
                case "name age":
                    people.ForEach(x => Console.WriteLine($"{x.Name} - {x.Age}"));
                    break;
            }
        }

        private static List<Person> ReadInput()
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            var people = new List<Person>();
            for (int i = 0; i < numberOfPeople; i++)
            {
                var currentPerson = Console.ReadLine().Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
                people.Add(new Person
                {
                    Name = currentPerson[0],
                    Age = int.Parse(currentPerson[1])
                });
            }
            return people;
        }
    }

    public class Person
    {
        public string Name { get; set; }

        public int Age { get; set; }
    }
}
