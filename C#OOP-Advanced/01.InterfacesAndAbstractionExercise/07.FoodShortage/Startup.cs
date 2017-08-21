using System;
using System.Collections.Generic;
using System.Linq;
using _07.FoodShortage.Interfaces;
using _07.FoodShortage.Models;

namespace _07.FoodShortage
{
    public class Startup
    {
        public static void Main()
        {
            var people = new HashSet<IBuyer>();
            AddCitizensAndRebels(people);
            List<string> buyers = AddBuyers();

            foreach (var name in buyers)
            {
                if (people.Any(x => x.Name == name))
                {
                    people.First(x => x.Name == name).BuyFood();
                }
            }

            Console.WriteLine(people.Sum(x => x.FoodAmount));
        }

        private static List<string> AddBuyers()
        {
            var buyers = new List<string>();
            var currrentBuyer = Console.ReadLine();
            while (currrentBuyer != "End")
            {
                buyers.Add(currrentBuyer);

                currrentBuyer = Console.ReadLine();
            }

            return buyers;
        }

        private static void AddCitizensAndRebels(HashSet<IBuyer> buyers)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfPeople; i++)
            {
                var input = Console.ReadLine().Split().ToArray();
                if (input.Length == 4)
                {
                    buyers.Add(new Citizen(input[0], int.Parse(input[1]), input[2], input[3]));
                    continue;
                }
                buyers.Add(new Rebel(input[0], int.Parse(input[1]), input[2]));
            }
        }
    }
}
