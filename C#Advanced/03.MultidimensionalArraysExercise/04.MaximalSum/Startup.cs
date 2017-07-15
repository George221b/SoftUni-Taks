using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.MaximalSum
{
    public class Startup
    {
        public static void Main()
        {
            int[] size = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(i => int.Parse(i)).ToArray();

            int[,] matrix = new int[size[0], size[1]];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(item => int.Parse(item)).ToArray();

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = input[j];
                }
            }


            int maxSum = int.MinValue;

            List<int> numbers = new List<int>();

            int[,] mtr = new int[3, 3];

            for (int i = 0; i < matrix.GetLength(0) - 2; i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 2; j++)
                {
                    int fNum = matrix[i, j];
                    int sNum = matrix[i, j + 1];
                    int tNum = matrix[i, j + 2];

                    int fNum2 = matrix[i + 1, j];
                    int sNum2 = matrix[i + 1, j + 1];
                    int tNum2 = matrix[i + 1, j + 2];

                    int fNum3 = matrix[i + 2, j];
                    int sNum3 = matrix[i + 2, j + 1];
                    int tNum3 = matrix[i + 2, j + 2];

                    int result = fNum + sNum + tNum + fNum2 + sNum2 + tNum2 + fNum3 + sNum3 + tNum3;

                    if (result > maxSum)
                    {
                        maxSum = result;

                        mtr[0, 0] = fNum;
                        mtr[0, 1] = sNum;
                        mtr[0, 2] = tNum;

                        mtr[1, 0] = fNum2;
                        mtr[1, 1] = sNum2;
                        mtr[1, 2] = tNum2;

                        mtr[2, 0] = fNum3;
                        mtr[2, 1] = sNum3;
                        mtr[2, 2] = tNum3;
                    }

                }

            }

            Console.WriteLine("Sum = " + maxSum);

            for (int i = 0; i < 3; i++)
            {

                for (int j = 0; j < 3; j++)
                {
                    Console.Write(mtr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
