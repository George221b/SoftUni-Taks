using System;
using System.Linq;

namespace _02.UpperStrings
{
    public class UpperStrings
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split()
                .Select(x => x.ToUpper());

            Console.WriteLine(string.Join(" ", input));
        }
    }
}
