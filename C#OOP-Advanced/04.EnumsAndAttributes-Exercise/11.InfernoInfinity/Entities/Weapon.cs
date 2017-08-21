using _11.InfernoInfinity.Enums;

namespace _11.InfernoInfinity.Entities
{
    public abstract class Weapon
    {
        protected Weapon(string name, WeaponRarity rarity)
        {
            this.Name = name;
            this.Rarity = rarity;
        }

        public string Name { get; set; }
        public int MinDmg { get; set; }
        public int MaxDmg { get; set; }
        public int SocketCount { get; set; }
        public Gem[] Gems { get; set; }
        public WeaponRarity Rarity { get; set; }

        public int Strength { get; set; }
        public int Agility { get; set; }
        public int Vitality { get; set; }

        protected void IncreaseDamageForRarity()
        {
            var multiplyValue = (int)this.Rarity;

            this.MinDmg *= multiplyValue;
            this.MaxDmg *= multiplyValue;
        }

        public void AddGem(Gem gem, int index)
        {
            if (index < 0 || index > this.Gems.Length - 1 || gem == null)
            {
                return;
            }
            if (this.Gems[index] != null)
            {
                this.RemoveGem(index);
            }

            var increaseMinDmgBy = (gem.Strength * 2) + (gem.Agility * 1);
            var increaseMaxDmgBy = (gem.Strength * 3) + (gem.Agility * 4);

            this.MinDmg += increaseMinDmgBy;
            this.MaxDmg += increaseMaxDmgBy;

            this.Strength += gem.Strength;
            this.Agility += gem.Agility;
            this.Vitality += gem.Vitality;

            this.Gems[index] = gem;
        }

        public void RemoveGem(int index)
        {
            if (this.Gems[index] == null || index < 0 || index > this.Gems.Length - 1)
            {
                return;
            }

            var gem = this.Gems[index];

            var decreaseMinDmg = (gem.Strength * 2) + (gem.Agility * 1);
            var decreaseMaxDmg = (gem.Strength * 3) + (gem.Agility * 4);

            this.MinDmg -= decreaseMinDmg;
            this.MaxDmg -= decreaseMaxDmg;

            this.Strength -= gem.Strength;
            this.Agility -= gem.Agility;
            this.Vitality -= gem.Vitality;

            this.Gems[index] = null;
        }

        public override string ToString()
        {
            return
                $"{this.Name}: {this.MinDmg}-{this.MaxDmg} Damage, +{this.Strength} Strength, +{this.Agility} Agility, +{this.Vitality} Vitality";
        }
    }
}
