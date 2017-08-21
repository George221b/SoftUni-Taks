using _11.InfernoInfinity.Enums;

namespace _11.InfernoInfinity.Entities
{
    public abstract class Gem
    {
        protected Gem(GemClarity clarity)
        {
            this.Clarity = clarity;
        }

        public int Strength { get; set; }
        public int Agility { get; set; }
        public int Vitality { get; set; }
        public GemClarity Clarity { get; set; }

        protected void IncreaseStatsForClarity()
        {
            var additionBy = (int) this.Clarity;

            this.Strength += additionBy;
            this.Agility += additionBy;
            this.Vitality += additionBy;
        }
    }
}
