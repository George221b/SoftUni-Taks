using System;
using System.Linq;

namespace _02.DiagonalDifference
{
    public class Startup
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(item => int.Parse(item))
                    .ToArray();
                for (int j = 0; j < input.Length; j++)
                {
                    matrix[i, j] = input[j];
                }

            }

            int primaryDiagonalSum = 0;
            int secondaryDiagonalSum = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    int number = 0;
                    if (j == i)
                    {
                        number = matrix[i, j];
                        primaryDiagonalSum += number;

                    }

                    int sNumber = 0;
                    if (j == n - i - 1)
                    {
                        sNumber = matrix[i, j];
                        secondaryDiagonalSum += sNumber;

                    }

                }
            }

            Console.WriteLine(Math.Abs(secondaryDiagonalSum - primaryDiagonalSum));
        }
    }
}
