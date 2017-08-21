using _11.InfernoInfinity.Enums;

namespace _11.InfernoInfinity.Entities.Gems
{
    class Amethyst : Gem
    {
        public Amethyst(GemClarity clarity) : base(clarity)
        {
            this.Strength = 2;
            this.Agility = 8;
            this.Vitality = 4;

            this.IncreaseStatsForClarity();
        }
    }
}
