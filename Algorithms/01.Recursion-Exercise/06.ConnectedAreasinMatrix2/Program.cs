namespace _06.ConnectedAreasinMatrix2
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static char[,] matrix;
        public static bool[,] visited;
        private static SortedSet<Area> areas;
        public static int size = 0;
        public static int startRow;
        public static int startCol;

        public static void Main()
        {
            var rows = int.Parse(Console.ReadLine());
            var cols = int.Parse(Console.ReadLine());

            matrix = new char[rows, cols];
            visited = new bool[rows, cols];
            areas = new SortedSet<Area>();


            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                var tokens = Console.ReadLine().ToCharArray();

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = tokens[j];
                    if(matrix[i, j] == '*')
                    {
                        visited[i, j] = true;
                    }
                }
            }

            while(HasNextArea())
            {
                var area = new Area();
                GetStartingIndexes(area);
                area.Size++;
                Traverse(area.Row, area.Col, area);
                areas.Add(area);
            }

            Console.WriteLine($"Total areas found: {areas.Count}");

            var areaCount = 1;
            foreach (var area in areas)
            {
                Console.WriteLine($"Area #{areaCount} at ({area.Row}, {area.Col}), size: {area.Size}");

                areaCount++;
            }
            
        }

        private static bool HasNextArea()
        {
            for (int i = 0; i < visited.GetLength(0); i++)
            {
                for (int j = 0; j < visited.GetLength(1); j++)
                {
                    if (visited[i, j] == false)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        private static void GetStartingIndexes(Area area)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == '-' && visited[i, j] == false)
                    {
                        area.Row = i;
                        area.Col = j;
                        return;
                    }
                }
            }
        }

        private static void Traverse(int row, int col, Area area)
        {
            visited[row, col] = true;

            if(col + 1 < matrix.GetLength(1))
            {
                if (matrix[row, col + 1] == '-' && visited[row, col + 1] == false)
                { //right
                    area.Size++;
                    visited[row, col + 1] = true;
                    Traverse(row, col + 1, area);
                }
            }
            if(row + 1 < matrix.GetLength(0))
            {
                if (matrix[row + 1, col] == '-' && visited[row + 1, col] == false)
                { //down
                    area.Size++;
                    visited[row + 1, col] = true;
                    Traverse(row + 1, col, area);
                }
            }
            if (col - 1 >= 0)
            { // left
                if (matrix[row, col - 1] == '-' && visited[row, col - 1] == false)
                {
                    area.Size++;
                    visited[row, col - 1] = true;
                    Traverse(row, col - 1, area);
                }
            }
            if (row - 1 >= 0)
            { // up
                if (matrix[row - 1, col] == '-' && visited[row - 1, col] == false)
                {
                    area.Size++;
                    visited[row - 1, col] = true;
                    Traverse(row - 1, col, area);
                }
            }

            return;
        }
    }

    public class Area : IComparable<Area>
    {
        public int Size { get; set; }

        public int Row { get; set; }

        public int Col { get; set; }

        public int CompareTo(Area other)
        {
            if(this.Size == other.Size)
            {
                if(other.Row == this.Row)
                {
                    return this.Col.CompareTo(other.Col);
                }

                return this.Row.CompareTo(other.Row);
            }

            return other.Size.CompareTo(this.Size);
        }
    }
}
