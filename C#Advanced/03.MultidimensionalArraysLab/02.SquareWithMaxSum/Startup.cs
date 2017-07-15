using System;
using System.Linq;

namespace _02.SquareWithMaxSum
{
    public class Startup
    {
        public static void Main()
        {
            var inputArgs = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse).ToArray();

            int rows = inputArgs[0];
            int cols = inputArgs[1];

            int[,] matrix = new int[rows, cols];

            // Fill the matrix
            for (int i = 0; i < rows; i++)
            {
                var numbers = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

                for (int q = 0; q < cols; q++)
                {
                    matrix[i, q] = numbers[q];
                }
            }

            // Find the biggest 2x2
            int biggestSum = int.MinValue;
            int currentSum;
            int elA = 0, elB = 0, elC = 0, elD= 0;

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    currentSum = matrix[row, col] + matrix[row, col + 1]
                        + matrix[row + 1, col] + matrix[row + 1, col + 1];
                    if (currentSum > biggestSum)
                    {
                        biggestSum = currentSum;
                        elA = matrix[row, col];
                        elB = matrix[row, col + 1];
                        elC = matrix[row + 1, col];
                        elD = matrix[row + 1, col + 1];
                    }
                }
            }

            Console.WriteLine($"{elA} {elB}\r\n{elC} {elD}");
            Console.WriteLine(biggestSum);
        }
    }
}
