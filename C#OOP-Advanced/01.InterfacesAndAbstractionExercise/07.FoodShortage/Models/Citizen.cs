using _07.FoodShortage.Interfaces;

namespace _07.FoodShortage.Models
{
    public class Citizen : IBuyer
    {
        public Citizen(string name, int age, string id, string birthday)
        {
            this.Id = id;
            this.Name = name;
            this.Age = age;
            this.Birthday = birthday;
        }

        public string Id { get; private set; }
        public string Name { get; private set; }
        public string Birthday { get; private set; }
        public int Age { get; private set; }
        public int FoodAmount { get; private set; }

        public void BuyFood()
        {
            this.FoodAmount += 10;
        }
    }
}
