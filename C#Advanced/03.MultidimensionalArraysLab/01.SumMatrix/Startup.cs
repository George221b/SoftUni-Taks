using System;
using System.Linq;

namespace _01.SumMatrix
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

            for (int i = 0; i < rows; i++)
            {
                var numbers = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[i, col] = numbers[col];
                }
            }

            int sum = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int q = 0; q < matrix.GetLength(1); q++)
                {
                    sum += matrix[i, q];
                }
            }
            Console.WriteLine(rows);
            Console.WriteLine(cols);
            Console.WriteLine(sum);

        }
    }
}
