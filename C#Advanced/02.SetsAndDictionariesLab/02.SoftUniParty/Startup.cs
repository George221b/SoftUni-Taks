using System;
using System.Collections.Generic;

namespace _02.SoftUniParty
{
    public class Startup
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var set = new SortedSet<string>();

            while (input != "PARTY")
            {
                if (input.Length != 8)
                {
                    break;
                }
                set.Add(input);

                input = Console.ReadLine();
            }

            while (input != "END")
            {
                if (set.Contains(input))
                {
                    set.Remove(input);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(set.Count);
            if (set.Count == 0)
            {
                return;
            }
            foreach (var guest in set)
            {
                Console.WriteLine(guest);
            }
        }
    }
}
