using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.LegoBlocks
{
    public class Startup
    {
        public static void Main()
        {
            int rows = int.Parse(Console.ReadLine());

            var firstLego = new int[rows][];
            var secondLego = new int[rows][];

            FillLegoWithInput(firstLego, rows);
            FillLegoWithInput(secondLego, rows);

            HashSet<int> checkLength = new HashSet<int>();

            for (int rowIndex = 0; rowIndex < rows; rowIndex++)
            {
                int rowSum = firstLego[rowIndex].Length + secondLego[rowIndex].Length;
                checkLength.Add(rowSum);
            }

            if (checkLength.Count != 1)
            {
                int sum = 0;
                for (int rowIndex = 0; rowIndex < rows; rowIndex++)
                {
                    sum += firstLego[rowIndex].Length + secondLego[rowIndex].Length;
                }
                Console.WriteLine($"The total number of cells is: {sum}");
            }
            else
            {
                for (int i = 0; i < rows; i++)
                {
                    var firstPart = firstLego[i].Select(row => row);
                    Console.Write($"[{string.Join(", ", firstPart)}");
                    var secondPart = secondLego[i].Reverse().Select(row => row);
                    Console.Write($", {string.Join(", ", secondPart)}]");
                    Console.WriteLine();
                    
                }
            }
        }

        private static void FillLegoWithInput(int[][] lego, int rows)
        {
            for (int i = 0; i < rows; i++)
            {
                var inputLine = Console.ReadLine().Trim()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                lego[i] = new int[inputLine.Length];

                for (int j = 0; j < inputLine.Length; j++)
                {
                    lego[i][j] = inputLine[j];
                }
            }
        }
    }
}
