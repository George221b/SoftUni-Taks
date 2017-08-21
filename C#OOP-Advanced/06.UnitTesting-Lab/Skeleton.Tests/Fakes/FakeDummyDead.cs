using System;

namespace Skeleton.Tests.Fakes
{
    public class FakeDummyDead : ITarget
    {
        public FakeDummyDead(int health, int experience)
        {
            this.Health = 0;
            this.Experience = experience;
        }

        public int Health { get; set; }
        public int Experience { get; set; }

        public void TakeAttack(int attackPoints)
        {
        }

        public int GiveExperience()
        {
            if (!this.IsDead())
            {
                throw new InvalidOperationException("Target is not dead.");
            }

            return this.Experience;
        }

        public bool IsDead()
        {
            return true;
        }
    }
}
