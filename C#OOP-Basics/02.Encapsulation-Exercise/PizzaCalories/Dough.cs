using System;

namespace PizzaCalories
{
    public class Dough
    {
        private string flourType;
        private string bakingTechnique;
        private double weight;
        private double calories;

        public Dough(string flourType, string bakingTechnique, double weight)
        {
            this.FlourType = flourType;
            this.BakingTechnique = bakingTechnique;
            this.Weight = weight;
            this.Calories = calories;
        }

        public double Calories
        {
            get { return this.calories; }
            set { this.calories = GetCalories(this.weight, this.flourType, this.bakingTechnique); }
        }

        private string FlourType
        {
            set
            {
                if (!value.ToLowerInvariant().Equals("white")
                    && !value.ToLowerInvariant().Equals("wholegrain"))
                {
                    throw new ArgumentException("Invalid type of dough.");
                }

                this.flourType = value;
            }
        }

        private string BakingTechnique
        {
            set
            {
                if (!value.ToLowerInvariant().Equals("crispy")
                    && !value.ToLowerInvariant().Equals("chewy")
                    && !value.ToLowerInvariant().Equals("homemade"))
                {
                    throw new ArgumentException("Invalid type of dough.");
                }

                this.bakingTechnique = value;
            }
        }

        private double Weight
        {
            set
            {
                if (value < 1 || value > 200)
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }

                this.weight = value;
            }
        }

        private double GetCalories(double weight, string flourType, string bakingTechnique)
        {
            if (flourType.ToLower() == "white") //White 1.5
            {
                switch (bakingTechnique.ToLower())
                {
                    case "crispy":
                        return (2.0 * weight) * 1.5 * 0.9;
                        break;
                    case "chewy":
                        return (2.0 * weight) * 1.5 * 1.1;
                        break;
                    case "homemade":
                        return (2.0 * weight) * 1.5 * 1.0;
                        break;
                }
            }
            else if (flourType.ToLower() == "wholegrain")
            {
                switch (bakingTechnique.ToLower())
                {
                    case "crispy":
                        return (2.0 * weight) * 1.0 * 0.9;
                        break;
                    case "chewy":
                        return (2.0 * weight) * 1.0 * 1.1;
                        break;
                    case "homemade":
                        return (2.0 * weight) * 1.0 * 1.0;
                        break;
                }
            }
            return 0;
        }
    }
}