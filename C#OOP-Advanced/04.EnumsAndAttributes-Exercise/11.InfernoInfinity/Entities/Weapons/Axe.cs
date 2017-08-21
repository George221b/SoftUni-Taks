using _11.InfernoInfinity.Enums;

namespace _11.InfernoInfinity.Entities.Weapons
{
    public class Axe : Weapon
    {
        public Axe(string name, WeaponRarity rarity)
            : base(name, rarity)
        {
            this.MinDmg = 5;
            this.MaxDmg = 10;
            this.SocketCount = 4;

            this.Gems = new Gem[SocketCount];
            this.IncreaseDamageForRarity();
        }
    }
}
