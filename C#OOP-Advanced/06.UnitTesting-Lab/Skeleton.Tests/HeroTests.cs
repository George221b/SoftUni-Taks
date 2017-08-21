using Moq;
using NUnit.Framework;
using Skeleton.Tests.Fakes;

namespace Skeleton.Tests
{
    [TestFixture]
    class HeroTests
    {
        [Test]
        public void HeroGainsXpAfterKill()
        {
            // Arrange
            Hero hero = new Hero("Hero", new Axe(10, 10));
            FakeDummyDead dummy = new FakeDummyDead(0, 20);

            // Act
            hero.Attack(dummy);

            // Assert
            Assert.AreEqual(20, hero.Experience, "Dead dummy doesn't give expereince.");
        }

        [Test]
        public void HeroGainsXpAfterKillWithMoq()
        {
            // Arrange
            Mock<ITarget> fakeTarget = new Mock<ITarget>();
            fakeTarget.Setup(p => p.Health).Returns(0);
            fakeTarget.Setup(p => p.GiveExperience()).Returns(20);
            fakeTarget.Setup(p => p.IsDead()).Returns(true);

            Mock<IWeapon> fakeWeapon = new Mock<IWeapon>();

            Hero hero = new Hero("Pesho", fakeWeapon.Object);

            // Act
            hero.Attack(fakeTarget.Object);

            // Assert
            Assert.AreEqual(20, hero.Experience, "Hero doesn't gain Xp after dummy kill.");
        }
    }
}
