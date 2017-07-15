using System;
using System.Linq;

namespace _07.BoundedNumbers
{
    public class BoundedNumbers
    {
        public static void Main()
        {
            var bounds = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .Where(num => bounds.Min() <= num && num <= bounds.Max());

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
