using System;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace Skeleton.Tests
{
    [TestFixture]
    class DummyTests
    {
        [Test]
        public void DummyLosesHealthAfterAttack()
        {
            // Arrange
            Dummy dummy = new Dummy(10, 10);

            // Act
            dummy.TakeAttack(1);

            // Assert
            Assert.AreEqual(9, dummy.Health);
        }

        [Test]
        public void AtackDeadDummy()
        {
            // Arrange
            Dummy dummy = new Dummy(10, 10);

            // Act
            dummy.TakeAttack(10);

            // Assert
            var ex = Assert.Throws<InvalidOperationException>(() => dummy.TakeAttack(1));
            Assert.That(ex.Message, Is.EqualTo("Dummy is dead."));
        }

        [Test]
        public void DeadDummyGivesExperience()
        {
            // Assert
            Dummy dummy = new Dummy(10, 10);
            
            // Assert
            dummy.TakeAttack(10);

            //Act
            Assert.AreEqual(10, dummy.GiveExperience(), "Dead dummy, doesn't give experience.");
        }

        [Test]
        public void AliveDummyCantGiveExperience()
        {
            // Arrange
            Dummy dummy = new Dummy(10, 10);

            // Act
            dummy.TakeAttack(9);

            //Act
            var ex = Assert.Throws<InvalidOperationException>(() => dummy.GiveExperience());
            Assert.That(ex.Message, Is.EqualTo("Target is not dead."));
        }
    }
}
