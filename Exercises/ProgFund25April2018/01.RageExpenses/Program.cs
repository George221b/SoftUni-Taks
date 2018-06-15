namespace _01.RageExpenses
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var lostGames = int.Parse(Console.ReadLine());
            var headsetPrice = decimal.Parse(Console.ReadLine());
            var mousePrice = decimal.Parse(Console.ReadLine());
            var keyboardPrice = decimal.Parse(Console.ReadLine());
            var displayPrice = decimal.Parse(Console.ReadLine());

            var totalExpenses = 0.0m;
            var keyboardTrashes = 0;

            for (int i = 1; i <= lostGames; i++)
            {
                if (i % 2 == 0)
                {
                    totalExpenses += headsetPrice;
                }

                if (i % 3 == 0)
                {
                    totalExpenses += mousePrice;
                }

                if (i % 2 == 0 && i % 3 == 0)
                {
                    totalExpenses += keyboardPrice;
                    keyboardTrashes++;

                    if (keyboardTrashes % 2 == 0)
                    {
                        totalExpenses += displayPrice;
                    }
                }
            }

            Console.WriteLine($"Rage expenses: {totalExpenses:F2} lv.");
        }
    }
}
