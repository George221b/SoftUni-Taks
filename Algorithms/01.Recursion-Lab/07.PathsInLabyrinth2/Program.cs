namespace _07.PathsInLabyrinth2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static char[,] matrix;
        static List<char> path;

        static void Main(string[] args)
        {
            var row = int.Parse(Console.ReadLine());
            var col = int.Parse(Console.ReadLine());

            matrix = new char[row, col];
            path = new List<char>();

            FillMatrixWithInput(matrix);

            FindPaths(0, 0, 'S');
        }

        private static void FindPaths(int row, int col, char direction)
        {
            if (!IsInBounds(row, col))
            {
                return;
            }

            path.Add(direction);

            if (IsExit(row, col))
            {
                PrintPath();
            }
            else if (!IsVisited(row, col) && IsFree(row, col))
            {
                Mark(row, col);
                FindPaths(row, col + 1, 'R');
                FindPaths(row + 1, col, 'D');
                FindPaths(row, col - 1, 'L');
                FindPaths(row - 1, col, 'U');
                Unmark(row, col);
            }

            path.RemoveAt(path.Count - 1);
        }

        private static void Unmark(int row, int col)
        {
            matrix[row, col] = '-';
        }

        private static void Mark(int row, int col)
        {
            matrix[row, col] = '+';
        }

        private static void PrintPath()
        {
            var result = string.Join(string.Empty, path.Skip(1));

            Console.WriteLine(result);
        }

        private static bool IsFree(int row, int col)
        {
            if (matrix[row, col] != '*')
            {
                return true;
            }

            return false;
        }

        private static bool IsVisited(int row, int col)
        {
            if (matrix[row, col] == '+')
            {
                return true;
            }

            return false;
        }

        private static bool IsExit(int row, int col)
        {
            if (matrix[row, col] == 'e')
            {
                return true;
            }

            return false;
        }

        private static bool IsInBounds(int row, int col)
        {
            if (row >= 0 && row < matrix.GetLength(0) &&
                col >= 0 && col < matrix.GetLength(1))
            {
                return true;
            }

            return false;
        }

        private static void FillMatrixWithInput(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var inputLine = Console.ReadLine();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = inputLine[col];
                }
            }
        }
    }
}
