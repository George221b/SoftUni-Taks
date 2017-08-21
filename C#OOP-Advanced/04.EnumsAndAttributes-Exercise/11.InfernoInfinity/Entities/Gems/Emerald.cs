using _11.InfernoInfinity.Enums;

namespace _11.InfernoInfinity.Entities.Gems
{
    class Emerald : Gem
    {
        public Emerald(GemClarity clarity) : base(clarity)
        {
            this.Strength = 1;
            this.Agility = 4;
            this.Vitality = 9;

            this.IncreaseStatsForClarity();
        }
    }
}
