namespace _07.FoodShortage.Interfaces
{
    public interface IBuyer
    {
        string Name { get; }
        int Age { get; }
        int FoodAmount { get; }

        void BuyFood();
    }
}
