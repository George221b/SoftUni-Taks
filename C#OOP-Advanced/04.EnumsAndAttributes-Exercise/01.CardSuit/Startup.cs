using System;

namespace _01.CardSuit
{
    public class Startup
    {
        public static void Main()
        {
            Console.WriteLine("Card Suits:");
            Console.WriteLine($"Ordinal value: {(int)CardSuit.Clubs}; Name value: {CardSuit.Clubs}");
            Console.WriteLine($"Ordinal value: {(int)CardSuit.Diamonds}; Name value: {CardSuit.Diamonds}");
            Console.WriteLine($"Ordinal value: {(int)CardSuit.Hearts}; Name value: {CardSuit.Hearts}");
            Console.WriteLine($"Ordinal value: {(int)CardSuit.Spades}; Name value: {CardSuit.Spades}");
        }
    }
}
