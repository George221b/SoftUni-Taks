using System;

namespace _03.WildFarm.Models.Animals
{
    public class Zebra : Mammal
    {
        public Zebra(string name, double weight, string livingRegion)
            : base(name, weight, livingRegion)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("Zs");
        }

        public override void Eat(Food food)
        {
            if (food.GetType().Name == "Vegetable")
            {
                this.FoodEaten += food.Quantity;
                return;
            }
            Console.WriteLine($"Zebras are not eating that type of food!");
        }
    }
}
