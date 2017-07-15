using System;
using System.Linq;
using _03.WildFarm.Models;
using _03.WildFarm.Models.Animals;
using _03.WildFarm.Models.Foods;

namespace _03.WildFarm
{
    public class Startup
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            while (input != "End")
            {
                var tokens = input.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var foodTokens = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                Food food;
                switch (foodTokens[0].ToLower())
                {
                    case "vegetable":
                        food = new Vegetable(int.Parse(foodTokens[1]));
                        break;
                    default:
                        food = new Meat(int.Parse(foodTokens[1]));
                        break;
                }

                Animal animal;
                var name = tokens[1];
                var weight = double.Parse(tokens[2]);
                var livingRegion = tokens[3];

                switch (tokens[0])
                {
                    case "Tiger":
                        animal = new Tiger(name, weight, livingRegion);
                        FeedAndPrintAnimal(food, animal);
                        break;
                    case "Zebra":
                        animal = new Zebra(name, weight, livingRegion);
                        FeedAndPrintAnimal(food, animal);
                        break;
                    case "Mouse":
                        animal = new Mouse(name, weight, livingRegion);
                        FeedAndPrintAnimal(food, animal);
                        break;
                    case "Cat":
                        animal = new Cat(name, weight, livingRegion, tokens.Last());
                        FeedAndPrintAnimal(food, animal);
                        break;
                }

                input = Console.ReadLine();
            }
        }

        private static void FeedAndPrintAnimal(Food food, Animal animal)
        {
            animal.MakeSound();
            animal.Eat(food);
            Console.WriteLine(animal);
        }
    }
}
