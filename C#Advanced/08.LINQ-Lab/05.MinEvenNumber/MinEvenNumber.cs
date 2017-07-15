using System;
using System.Linq;

namespace _05.MinEvenNumber
{
    public class MinEvenNumber
    {
        public static void Main()
        {
            try
            {
                double num = Console.ReadLine().Split()
                    .Select(double.Parse)
                    .Where(x => x % 2 == 0)
                    .Min();

                Console.WriteLine($"{num:F2}");
            }
            catch
            {
                Console.WriteLine("No match");
            }
        }
    }
}
