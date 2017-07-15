using System;
using System.Linq;

namespace _14.LettersChangeNumbers
{
    public class Startup
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(new[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            double sum = 0;
            double totalSum = 0;

            foreach (var pair in input)
            {
                char firstChar = char.Parse(pair.Substring(0, 1));
                char secondChar = char.Parse(pair.Substring(pair.Length - 1, 1));
                int num = int.Parse(pair.Substring(1, pair.Length - 2));
                sum = num;

                sum = FirstCharOperation(firstChar, sum);
                sum = SecondCharOperation(secondChar, sum);
                totalSum += sum;
            }

            Console.WriteLine($"{totalSum:F2}");

        }

        private static double SecondCharOperation(char secondChar, double sum)
        {
            if (!char.IsLower(secondChar))
            {
                int charValue = secondChar - 64;

                sum = sum - charValue;
            }
            else
            {
                int charValue = secondChar - 96;

                sum = sum + charValue;
            }

            return sum;
        }

        private static double FirstCharOperation(char firstChar, double sum)
        {
            if (!char.IsLower(firstChar))
            {
                int charValue = firstChar - 64;

                sum = sum / charValue;
            }
            else
            {
                int charValue = firstChar - 96;

                sum = sum * charValue;
            }

            return sum;
        }
    }
}
