using System;

namespace _03.WildFarm.Models.Animals
{
    public class Tiger : Felime
    {
        public Tiger(string name, double weight, string livingRegion) : base(name, weight, livingRegion)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("ROAAR!!!");
        }

        public override void Eat(Food food)
        {
            if (food.GetType().Name == "Meat")
            {
                this.FoodEaten += food.Quantity;
                return;
            }
            Console.WriteLine($"Tigers are not eating that type of food!");
        }
    }
}
