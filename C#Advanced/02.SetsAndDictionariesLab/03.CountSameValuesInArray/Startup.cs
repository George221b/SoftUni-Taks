using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.CountSameValuesInArray
{
    public class Startup
    {
        public static void Main()
        {
            double[] input = Console.ReadLine()
                                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                    .Select(double.Parse)
                                    .ToArray();

            SortedDictionary<double, int> dictionary = new SortedDictionary<double, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (! dictionary.ContainsKey(input[i]))
                {
                    dictionary.Add(input[i], 1);
                }
                else
                {
                    dictionary[input[i]]++;
                }
            }

            foreach (var num in dictionary)
            {
                Console.WriteLine($"{num.Key} - {num.Value} times");
            }
        }
    }
}
