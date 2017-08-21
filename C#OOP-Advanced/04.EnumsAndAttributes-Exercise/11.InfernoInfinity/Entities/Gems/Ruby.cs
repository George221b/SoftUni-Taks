using _11.InfernoInfinity.Enums;

namespace _11.InfernoInfinity.Entities.Gems
{
    class Ruby : Gem
    {
        public Ruby(GemClarity clarity) : base(clarity)
        {
            this.Strength = 7;
            this.Agility = 2;
            this.Vitality = 5;

            this.IncreaseStatsForClarity();
        }
    }
}
