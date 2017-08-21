using System;

namespace _02.CardRank
{
    public class Startup
    {
        public static void Main()
        {
            Console.WriteLine("Card Ranks:");

            var ranks = Enum.GetValues(typeof(CardRank));

            foreach (object rank in ranks)
            {
                CardRank cardRank = (CardRank)Enum.Parse(typeof(CardRank), rank.ToString());

                Console.WriteLine($"Ordinal value: {(int)cardRank}; Name value: {cardRank}");
            }
        }
    }
}
