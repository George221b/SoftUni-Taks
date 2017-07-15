using System;
using System.Linq;

namespace _01.TakeTwo
{
    public class TakeTwo
    {
        public static void Main()
        {
            Console.WriteLine(string.Join(" ", 
                Console.ReadLine().Split()
                    .Select(int.Parse)
                    .Distinct()
                    .Where(x => x >= 10 && x <= 20)
                    .Take(2)
                    .ToList()));
        }
    }
}
