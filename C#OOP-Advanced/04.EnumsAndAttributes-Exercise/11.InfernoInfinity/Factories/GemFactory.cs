using System;
using _11.InfernoInfinity.Entities;
using _11.InfernoInfinity.Entities.Gems;
using _11.InfernoInfinity.Enums;

namespace _11.InfernoInfinity.Factories
{
    public static class GemFactory
    {
        public static Gem GetGem(string type, GemClarity clarity)
        {
            switch (type.ToLower())
            {
                case "ruby":
                    return new Ruby(clarity);
                    break;
                case "emerald":
                    return new Emerald(clarity);
                    break;
                case "amethyst":
                    return new Amethyst(clarity);
                    break;
                default:

                    throw new ArgumentException("No such type for gem exists.");
            }
        }
    }
}
