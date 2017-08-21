using System;

namespace _02.KingsGambit.Models
{
    public abstract class Soldier
    {
        protected Soldier(string name)
        {
            this.Name = name;
        }

        public string Name { get; private set; }

        public abstract void KingUnderAttack(object sender, EventArgs e);
    }
}
