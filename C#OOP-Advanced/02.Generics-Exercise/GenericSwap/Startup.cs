using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericSwap
{
    public class Startup
    {
        public static void Main()
        {
            int numberOfCommands = int.Parse(Console.ReadLine());
            List<Box<int>> swapList = new List<Box<int>>();

            for (int i = 0; i < numberOfCommands; i++)
            {
                var box = new Box<int>(int.Parse(Console.ReadLine()));
                swapList.Add(box);
            }

            var swapIndexes = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var temp = swapList[swapIndexes[0]];
            swapList[swapIndexes[0]] = swapList[swapIndexes[1]];
            swapList[swapIndexes[1]] = temp;

            foreach (var elBox in swapList)
            {
                Console.WriteLine(elBox);
            }
        }
    }
}
