using System;

namespace _05.CardCompareTo
{
    public class Startup
    {
        public static void Main()
        {
            Task5ComapareTwoCards();
        }

        private static void Task5ComapareTwoCards()
        {
            var rank = Console.ReadLine();
            var suit = Console.ReadLine();
            var card = new Card(rank, suit);

            var rank2 = Console.ReadLine();
            var suit2 = Console.ReadLine();
            var card2 = new Card(rank2, suit2);

            if (card.CompareTo(card2) == 1)
            {
                Console.WriteLine($"Card name: {card.Rank} of {card.Suit}; Card power: {card.Power}");
            }
            else
            {
                Console.WriteLine($"Card name: {card2.Rank} of {card2.Suit}; Card power: {card2.Power}");
            }
        }
    }
}
