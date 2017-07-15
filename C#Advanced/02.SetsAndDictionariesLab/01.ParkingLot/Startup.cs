using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.ParkingLot
{
    public class Startup
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            SortedSet<string> set = new SortedSet<string>();

            while (input != "END")
            {
                string[] inputArgs = input.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                                          .ToArray();

                switch (inputArgs[0])
                {
                    case "IN":
                        set.Add(inputArgs[1]);
                        break;
                    case "OUT":
                        set.Remove(inputArgs[1]);
                        break;
                    default:
                        break;
                }

                input = Console.ReadLine();
            }

            if (set.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            else
            {
                foreach (var car in set)
                {
                    Console.WriteLine(car);
                }
            }
        }
    }
}
