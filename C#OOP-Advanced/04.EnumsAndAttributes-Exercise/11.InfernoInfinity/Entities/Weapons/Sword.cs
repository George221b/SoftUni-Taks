using _11.InfernoInfinity.Enums;

namespace _11.InfernoInfinity.Entities.Weapons
{
    public class Sword : Weapon
    {
        public Sword(string name, WeaponRarity rarity)
            : base(name, rarity)
        {
            this.MinDmg = 4;
            this.MaxDmg = 6;
            this.SocketCount = 3;

            this.Gems = new Gem[SocketCount];
            this.IncreaseDamageForRarity();
        }
    }
}
