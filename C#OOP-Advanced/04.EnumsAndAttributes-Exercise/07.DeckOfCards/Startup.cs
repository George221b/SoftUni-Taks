using System;
using _07.DeckOfCards.Enums;

namespace _07.DeckOfCards
{
    public class Startup
    {
        public static void Main()
        {
            var ranks = Enum.GetNames(typeof(CardRank));
            var suits = Enum.GetNames(typeof(CardSuit));

            foreach (string suit in suits)
            {
                foreach (string rank in ranks)
                {
                    Console.WriteLine($"{rank} of {suit}");
                }
            }
        }
    }
}
