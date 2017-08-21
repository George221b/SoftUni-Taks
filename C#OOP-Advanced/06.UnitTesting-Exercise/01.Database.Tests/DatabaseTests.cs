using System;
using System.Linq;
using NUnit.Framework;

namespace _01.Database.Tests
{
    [TestFixture]
    public class DatabaseTests
    {
        private Database db;

        [SetUp]
        public void Initialize()
        {
            this.db = new Database(1, 2, 3, 4, 5, 6, 7, 8, 9);
        }

        [Test]
        public void TestIfCorrectlyInitializes()
        {
            Assert.AreEqual(9, this.db.Count);
        }

        [Test]
        public void TestIfInitializedWith0Elements()
        {
            this.db = new Database();

            Assert.AreEqual(0, this.db.Count);
        }

        [Test]
        public void InitializedWithMoreThan16Elements()
        {
            Assert.Throws<InvalidOperationException>(() =>
                new Database(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17),
                "Data can't be more than 16 integers.");
        }

        [Test]
        public void FetchReturnsIntArray()
        {
            int[] test = new int[9] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            CollectionAssert.AreEqual(test, this.db.Fetch());
        }

        [Test]
        public void AddElementsIncreasesCount()
        {
            this.db.Add(10);

            Assert.AreEqual(10, db.Count);
        }

        [Test]
        public void AddElementToLastPosition()
        {
            this.db.Add(10);

            Assert.AreEqual(10, db.Fetch().Last());
        }

        [Test]
        public void AddMoreElementsThanMax()
        {
            this.db.Add(10);
            this.db.Add(11);
            this.db.Add(12);
            this.db.Add(13);
            this.db.Add(14);
            this.db.Add(15);
            this.db.Add(16);

            Assert.Throws<InvalidOperationException>(
                () => this.db.Add(17),
                "Data can't be more than 16 integers.");
        }

        [Test]
        public void RemoveRemovesElement()
        {
            this.db.Remove();

            Assert.AreEqual(8, db.Count);
        }

        [Test]
        public void RemoveRemovesLastElement()
        {
            this.db.Remove();

            int[] expected = new[] { 1, 2, 3, 4, 5, 6, 7, 8 };

            CollectionAssert.AreEqual(expected, db.Fetch());
        }

        [Test]
        public void RemoveThrowsExWhenNoElements()
        {
            this.db = new Database();

            Assert.Throws<InvalidOperationException>(
                () => db.Remove());
        }
    }
}
