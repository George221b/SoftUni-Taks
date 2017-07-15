using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.SetsOfElements
{
    public class Startup
    {
        public static void Main()
        {
            var input = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();
            var firstSet = new HashSet<int>();
            var secondSet = new HashSet<int>();
            for (int i = 0; i < input[0]; i++)
            {
                var num = int.Parse(Console.ReadLine().Trim());

                firstSet.Add(num);
            }

            for (int i = 0; i < input[1]; i++)
            {
                var num = int.Parse(Console.ReadLine().Trim());

                secondSet.Add(num);
            }

            var result = firstSet.Intersect(secondSet);
            foreach (var num in result)
            {
                Console.WriteLine(num);
            }
        }
    }
}
