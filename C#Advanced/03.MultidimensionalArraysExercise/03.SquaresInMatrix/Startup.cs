using System;
using System.Linq;

namespace _03.SquaresInMatrix
{
    public class Startup
    {
        public static void Main()
        {
            int[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
    .Select(i => int.Parse(i)).ToArray();

            int rows = input[0];
            int cols = input[1];

            string[,] matrix = new string[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                string[] values = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = values[j];
                }
            }

            int counter = 0;

            for (int i = 0; i < rows - 1; i++)
            {
                for (int j = 0; j < cols - 1; j++)
                {
                    string firstEl = matrix[i,j];
                    string secondEl = matrix[i,j + 1];
                    string thirdEl = matrix[i + 1,j];
                    string fourthEl = matrix[i + 1,j + 1];

                    if (firstEl == secondEl && secondEl == thirdEl && thirdEl == fourthEl)
                    {
                        counter++;
                    }
                }
            }

            Console.WriteLine(counter);
        }
    }
}
