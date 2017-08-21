using System;
using NUnit.Framework;

namespace _02.DatabaseExtended.Tests
{
    [TestFixture]
    public class DatabaseTests
    {
        private const int DataCapacity = 16;
        private Person[] people;
        private Database db;

        [SetUp]
        public void Initialize()
        {
            this.people = new[]
            {
                new Person(1, "George"),
                new Person(2, "Martha"),
                new Person(3, "Lucy"),
                new Person(4, "Gaston"),
                new Person(5, "Quentin")
            };

            this.db = new Database();
        }

        [Test]
        public void InitializeDatabaseWithElements()
        {
            this.db = new Database(people);

            Assert.AreEqual(5, this.db.Count);
        }

        [Test]
        public void InitializeDatabaseWithMoreThanMaxElements()
        {
            Assert.Throws<InvalidOperationException>(
                () => this.db = new Database(
                    new Person(1, "Hodor"),
                    new Person(2, "Arya"),
                    new Person(3, "Tyrion"),
                    new Person(4, "Jon"),
                    new Person(5, "Bran"),
                    new Person(6, "Bron"),
                    new Person(7, "Rob"),
                    new Person(8, "Ned"),
                    new Person(9, "Rickon"),
                    new Person(10, "Keitlyn"),
                    new Person(11, "Jaime"),
                    new Person(12, "Cersei"),
                    new Person(13, "Denerys"),
                    new Person(14, "Gregor"),
                    new Person(15, "Sandor"),
                    new Person(16, "Loras"),
                    new Person(17, "Except")),
                $"People can't be more than {DataCapacity} characters long.");
        }

        [Test]
        public void AddPersonToDb()
        {
            this.db.Add(new Person(1, "GuyRitchie"));

            Assert.AreEqual(1, this.db.Count);
        }

        [Test]
        public void AddPersonWithSameId()
        {
            this.db.Add(new Person(1, "GuyRitchie"));

            Assert.Throws<InvalidOperationException>(
                () => this.db.Add(new Person(1, "QuentinTarantino")),
                "There's already a person with this id.");
        }

        [Test]
        public void AddPersonWithSameUsername()
        {
            this.db.Add(new Person(1, "GuyRitchie"));

            Assert.Throws<InvalidOperationException>(
                () => this.db.Add(new Person(2, "GuyRitchie")),
                "There's already a person with this username.");
        }

        [Test]
        public void AddMorePeopleThanCapacity()
        {
            this.db.Add(new Person(1, "GuyRitchie"));
            this.db.Add(new Person(16, "Hodor"));
            this.db.Add(new Person(2, "Arya"));
            this.db.Add(new Person(3, "Tyrion"));
            this.db.Add(new Person(4, "Jon"));
            this.db.Add(new Person(5, "Bran"));
            this.db.Add(new Person(6, "Bron"));
            this.db.Add(new Person(7, "Rob"));
            this.db.Add(new Person(8, "Ned"));
            this.db.Add(new Person(9, "Rickon"));
            this.db.Add(new Person(10, "Keitlyn"));
            this.db.Add(new Person(11, "Jaime"));
            this.db.Add(new Person(12, "Cersei"));
            this.db.Add(new Person(13, "Denerys"));
            this.db.Add(new Person(14, "Gregor"));
            this.db.Add(new Person(15, "Sandor"));

            Assert.Throws<InvalidOperationException>(
                () => this.db.Add(new Person(17, "GuyRitchie")),
                "Can't add more elements.");
        }

        [Test]
        public void RemoveFromEmptyDb()
        {
            Assert.Throws<InvalidOperationException>(
                () => this.db.Remove(), "Data is empty.");
        }

        [Test]
        public void RemovePersonFromDb()
        {
            this.db = new Database(people);

            this.db.Remove();

            Assert.AreEqual(4, this.db.Count);
        }

        [Test]
        public void FindByUsernameTest()
        {
            this.db.Add(new Person(1, "Parker"));

            Person searchedPerson = this.db.FindByUsername("Parker");

            Assert.AreEqual(0, searchedPerson.CompareTo(new Person(1, "Parker")));
        }

        [Test]
        public void FindByUsernameWithInvalidUsername()
        {
            var exception = Assert.Throws<InvalidOperationException>(() => this.db.FindByUsername("unexisting"));

            Assert.AreEqual("There's no user with this username.", exception.Message);
        }

        [Test]
        public void FindByUsernameWithNull()
        {
            var exception = Assert.Throws<ArgumentNullException>(() => this.db.FindByUsername(null));

            Assert.AreEqual($"Person can't be null.{Environment.NewLine}Parameter name: username", exception.Message);
        }
        
        [Test]
        public void FindByIdWorksProperly()
        {
            this.db.Add(new Person(1, "Quentin"));

            Person searchedPerson = this.db.FindById(1);

            Assert.AreEqual(0, searchedPerson.CompareTo(new Person(1, "Quentin")));
        }

        [Test]
        public void FindByIdWithUnexistingId()
        {
            var exception = Assert.Throws<InvalidOperationException>(() => this.db.FindById(9098));

            Assert.AreEqual("There's no user with this id.", exception.Message);
        }

        [Test]
        public void FindByIdWithNegativeId()
        {
            var exception = Assert.Throws<ArgumentOutOfRangeException>(() => this.db.FindById(-9098));

            Assert.AreEqual($"Id can't be negative.{Environment.NewLine}Parameter name: id", exception.Message);
        }
    }
}
