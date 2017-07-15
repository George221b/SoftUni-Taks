using System;

namespace _03.WildFarm.Models.Animals
{
    public class Cat : Felime
    {
        private string breed;

        public Cat(string name, double weight, string livingRegion, string breed)
            : base(name, weight, livingRegion)
        {
            this.breed = breed;
        }

        public string Breed
        {
            get { return this.breed; }
            set { this.breed = value; }
        }

        public override void MakeSound()
        {
            Console.WriteLine("Meowwww");
        }

        public override void Eat(Food food)
        {
            this.FoodEaten += food.Quantity;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}[{this.Name}, {this.Breed}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
