using System;
using System.Collections.Generic;

namespace _03.PeriodicTable
{
    public class Startup
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var uniqueElements = new SortedSet<string>();

            for (int i = 0; i < n; i++)
            {
                var elements = Console.ReadLine()
                                      .Trim()
                                      .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (var element in elements)
                {
                    uniqueElements.Add(element);
                }
            }

            foreach (var el in uniqueElements)
            {
                Console.Write($"{el} ");
            }
            Console.WriteLine();
        }
    }
}
