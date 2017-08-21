using System;
using NUnit.Framework;

namespace Skeleton.Tests
{
    [TestFixture]
    class AxeTests
    {
        public const int AxeAtack = 10;
        public const int AxeDurability = 10;
        public const int DummyHealth = 100;
        public const int DummyXP = 100;

        private Axe axe;
        private Dummy dummy;

        [SetUp]
        public void TestInit()
        {
            this.axe = new Axe(AxeAtack, AxeDurability);
            this.dummy = new Dummy(DummyHealth, DummyHealth);
        }

        [Test]
        public void AxeLosesDurabilyAfterAttack()
        {
            // Act
            this.axe.Attack(dummy);

            // Assert
            Assert.AreEqual(9, this.axe.DurabilityPoints, "Axe does not lose durability");
        }

        [Test]
        public void AtackWithBrokenWeapon()
        {
            //Arange
            this.axe = new Axe(10, 1);

            //Act
            this.axe.Attack(dummy);

            //Assert
            var ex = Assert.Throws<InvalidOperationException>(() => this.axe.Attack(this.dummy));
            Assert.That(ex.Message, Is.EqualTo("Axe is broken."));
        }
    }
}
