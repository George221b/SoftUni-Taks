using System;
using System.Linq;

namespace _05.RubiksMatrix
{
    class Startup
    {
        static void Main()
        {
            int[] matrixSize = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            int[][] cube = new int[matrixSize[0]][];

            int number = 1;

            for (int row = 0; row < matrixSize[0]; row++)
            {
                cube[row] = new int[matrixSize[1]];

                for (int col = 0; col < matrixSize[1]; col++)
                {
                    cube[row][col] = number;
                    number++;
                }
            }

            int numberOfActions = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfActions; i++)
            {
                string[] action = Console.ReadLine().Split(new char[] { ' ' });

                int index = int.Parse(action[0]);
                int moves = int.Parse(action[2]);

                switch (action[1])
                {
                    case "up":
                        MoveUp(cube, index, (moves % cube.Length));
                        break;
                    case "down":
                        MoveDown(cube, index, (moves % cube.Length));
                        break;
                    case "left":
                        MoveLeft(cube, index, (moves % cube[0].Length));
                        break;
                    case "right":
                        MoveRight(cube, index, (moves % cube[0].Length));
                        break;
                }
            }

            OrderCubeAndPrintResult(cube);
        }


        private static void MoveUp(int[][] cube, int index, int moves)
        {
            for (int move = 0; move < moves; move++)
            {
                int tempNumber = cube[0][index];

                for (int row = 0; row < cube.Length - 1; row++)
                {
                    cube[row][index] = cube[row + 1][index];
                }

                cube[cube.Length - 1][index] = tempNumber;
            }
        }

        private static void MoveDown(int[][] cube, int index, int moves)
        {
            for (int move = 0; move < moves; move++)
            {
                int tempNumber = cube[cube.Length - 1][index];

                for (int row = cube.Length - 1; row > 0; row--)
                {
                    cube[row][index] = cube[row - 1][index];
                }

                cube[0][index] = tempNumber;
            }
        }

        private static void MoveLeft(int[][] cube, int index, int moves)
        {
            for (int move = 0; move < moves; move++)
            {
                int tempNumber = cube[index][0];

                for (int col = 0; col < cube[index].Length - 1; col++)
                {
                    cube[index][col] = cube[index][col + 1];
                }

                cube[index][cube[index].Length - 1] = tempNumber;
            }
        }

        private static void MoveRight(int[][] cube, int index, int moves)
        {
            for (int move = 0; move < moves; move++)
            {
                int tempNumber = cube[index][cube[index].Length - 1];

                for (int col = cube[index].Length - 1; col > 0; col--)
                {
                    cube[index][col] = cube[index][col - 1];
                }

                cube[index][0] = tempNumber;
            }
        }

        private static void OrderCubeAndPrintResult(int[][] cube)
        {
            int number = 1;

            for (int row = 0; row < cube.Length; row++)
            {
                for (int col = 0; col < cube[row].Length; col++)
                {
                    if (cube[row][col] == number)
                    {
                        Console.WriteLine("No swap required");
                    }
                    else
                    {
                        int[] indexes = FindIndices(cube, number);

                        Console.WriteLine($"Swap ({row}, {col}) with ({string.Join(", ", indexes)})");

                        int tempNumber = 0;

                        tempNumber = cube[row][col];
                        cube[row][col] = cube[indexes[0]][indexes[1]];
                        cube[indexes[0]][indexes[1]] = tempNumber;
                    }

                    number++;
                }
            }
        }

        private static int[] FindIndices(int[][] cube, int number)
        {
            for (int row = 0; row < cube.Length; row++)
            {
                for (int col = 0; col < cube[row].Length; col++)
                {
                    if (cube[row][col] == number)
                    {
                        return new int[]
                        {
                            row, col
                        };
                    }
                }
            }

            return new int[2];
        }
    }
}