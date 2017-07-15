using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.FindEvensOrOdds
{
    public class FindEvensOrOdds
    {
        public static void Main()
        {
            Predicate<int> isEven = x => x % 2 == 0;

            var cicle = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string command = Console.ReadLine();

            List<int> numbers = new List<int>();

            switch (command)
            {
                case "odd":
                    for (int i = cicle[0]; i <= cicle[1]; i++)
                    {
                        if (!isEven(i)) numbers.Add(i);
                    }
                    break;
                case "even":
                    for (int i = cicle[0]; i <= cicle[1]; i++)
                    {
                        if (isEven(i)) numbers.Add(i);
                    }
                    break;
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}