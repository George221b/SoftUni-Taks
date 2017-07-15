using System;
using System.Collections.Generic;

namespace PizzaCalories
{
    public class Pizza
    {
        private string name;
        private int numberOfToppings;
        private Dough dough;
        private HashSet<Topping> toppings;

        public Pizza(string name, int numberOfToppings)
        {
            this.Name = name;
            this.NumberOfToppings = numberOfToppings;
            this.Toppings = new HashSet<Topping>();
        }

        private HashSet<Topping> Toppings
        {
            get { return this.toppings; }
            set { this.toppings = value; }
        }

        public Dough Dough
        {
            get { return this.dough; }
            set { this.dough = value; }
        }

        public string Name
        {
            get { return this.name; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length > 15)
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }

                this.name = value;
            }
        }

        private int NumberOfToppings
        {
            get { return this.numberOfToppings; }
            set
            {
                if (value < 0 || value > 10)
                {
                    throw new ArgumentException("Number of toppings should be in range [0..10].");
                }

                this.numberOfToppings = value;
            }
        }

        public void AddTopping(Topping topping)
        {
            this.toppings.Add(topping);
        }

        public double GetCalories()
        {
            var doughCalories = this.Dough.Calories;
            var toppingsCalories = 0.0;

            foreach (Topping topping in this.Toppings)
            {
                toppingsCalories += topping.Calories;
            }

            return toppingsCalories + doughCalories;
        }
    }
}
