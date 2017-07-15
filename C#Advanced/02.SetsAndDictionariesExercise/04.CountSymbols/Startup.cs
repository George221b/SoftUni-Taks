using System;
using System.Collections.Generic;

namespace _04.CountSymbols
{
    public class Startup
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var dictionary = new SortedDictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (!dictionary.ContainsKey(input[i]))
                {
                    dictionary.Add(input[i], 1);
                }
                else
                {
                    dictionary[input[i]]++;
                }
            }

            foreach (var ch in dictionary)
            {
                Console.WriteLine($"{ch.Key}: {ch.Value} time/s");
            }
        }
    }
}
