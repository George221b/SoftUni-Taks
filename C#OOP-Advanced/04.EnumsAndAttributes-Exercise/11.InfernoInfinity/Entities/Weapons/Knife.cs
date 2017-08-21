using _11.InfernoInfinity.Enums;

namespace _11.InfernoInfinity.Entities.Weapons
{
    public class Knife : Weapon
    {
        public Knife(string name, WeaponRarity rarity)
            : base(name, rarity)
        {
            this.MinDmg = 3;
            this.MaxDmg = 4;
            this.SocketCount = 2;

            this.Gems = new Gem[SocketCount];
            this.IncreaseDamageForRarity();
        }
    }
}
