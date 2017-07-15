using System;
using System.Linq;

namespace _06.ReverseAndExclude
{
    public class ReverseAndExclude
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse);

            var divisor = int.Parse(Console.ReadLine());
            Func<int, bool> filter = n => n % divisor != 0; // Both work similarly
            Predicate<int> isDivisedByN = n => n % divisor == 0; // Both work similarly

            var remainingNumbers = numbers.Reverse().Where(n => !isDivisedByN(n));

            Console.WriteLine(string.Join(" ", remainingNumbers));
        }
    }
}
