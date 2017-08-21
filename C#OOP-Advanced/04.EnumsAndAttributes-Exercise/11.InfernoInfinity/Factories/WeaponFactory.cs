using System;
using _11.InfernoInfinity.Entities;
using _11.InfernoInfinity.Entities.Weapons;
using _11.InfernoInfinity.Enums;

namespace _11.InfernoInfinity.Factories
{
    public static class WeaponFactory
    {
        public static Weapon GetWeapon(string type, string name, WeaponRarity rarity)
        {
            switch (type.ToLower())
            {
                case "axe":
                    return new Axe(name, rarity);
                    break;
                case "sword":
                    return new Sword(name, rarity);
                    break;
                case "knife":
                    return new Knife(name, rarity);
                    break;
                default:
                    throw new ArgumentException("No such type for weapon exists.");
                    break;
            }
        }
    }
}
