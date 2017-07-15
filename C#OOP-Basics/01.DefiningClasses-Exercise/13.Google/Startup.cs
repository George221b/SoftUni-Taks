using System;
using System.Collections.Generic;
using System.Linq;

namespace _13.Google
{
    public class Startup
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var people = new List<Person>();

            while (input != "End")
            {
                var tokens = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var person = people.FirstOrDefault(p => p.Name == tokens[0]);
                if (person == null)
                {
                    person = new Person(tokens[0]);
                    ProcessCommand(tokens, person);
                    people.Add(person);
                }
                else
                {
                    ProcessCommand(tokens, person);
                }

                input = Console.ReadLine();
            }

            var personName = Console.ReadLine();
            Console.WriteLine(people.FirstOrDefault(p => p.Name == personName));
        }

        private static void ProcessCommand(string[] tokens, Person person)
        {
            switch (tokens[1])
            {
                case "company":
                    person.Company = new Company(tokens[2], tokens[3], double.Parse(tokens[4]));
                    break;
                case "pokemon":
                    person.Pokemons.Add(new Pokemon(tokens[2], tokens[3]));
                    break;
                case "parents":
                    person.Parents.Add(new Parent(tokens[2], tokens[3]));
                    break;
                case "children":
                    person.Children.Add(new Child(tokens[2], tokens[3]));
                    break;
                case "car":
                    person.Car = new Car(tokens[2], int.Parse(tokens[3]));
                    break;
            }
        }
    }
}
