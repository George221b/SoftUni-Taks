using System;
using NUnit.Framework;

namespace _03.IteratorTest.Tests
{
    [TestFixture]
    public class ListIteratorTests
    {
        private ListIterator listIterator;

        [SetUp]
        public void Initialize()
        {
            this.listIterator = new ListIterator("Stefcho", "Goshky");
        }

        [Test]
        public void PrintWithNoElements()
        {
            ListIterator list = new ListIterator();

            Assert.Throws<ArgumentNullException>(
                () => list.Print(), "Invalid Operation!");
        }

        [Test]
        public void InitializeWithNullParameter()
        {
            Assert.Throws<ArgumentNullException>(
                () => this.listIterator = new ListIterator(null));
        }

        [Test]
        public void HasNextReturnTest()
        {
            var result = this.listIterator.HasNext();

            Assert.AreEqual(true, result);
        }

        [Test]
        public void HasNextMustReturnFalse()
        {
            this.listIterator.HasNext();
            this.listIterator.Move();

            var result = this.listIterator.HasNext();

            Assert.AreEqual(false, result);
        }

        [Test]
        public void MoveShouldReturnTrue()
        {
            var result = this.listIterator.Move();

            Assert.AreEqual(true, result);
        }

        [Test]
        public void MoveShouldReturnFalse()
        {
            this.listIterator.Move();

            Assert.AreEqual(false, this.listIterator.Move());
        }

        [Test]
        public void PrintFirstElement()
        {
            Assert.AreEqual("Stefcho", this.listIterator.Print());
        }

        [Test]
        public void PrintAfterHasNext()
        {
            this.listIterator.HasNext();

            Assert.AreEqual("Stefcho", this.listIterator.Print());
        }

        [Test]
        public void PrintAfterMove()
        {
            this.listIterator.Move();

            Assert.AreEqual("Goshky", this.listIterator.Print());
        }
    }
}
