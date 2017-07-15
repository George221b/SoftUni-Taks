using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.RectangleIntersection
{
    public class Startup
    {
        public static void Main()
        {
            var firstLine = Console.ReadLine().Split();
            
            var rectangles = new HashSet<Rectangle>();

            while (rectangles.Count < int.Parse(firstLine[0]))
            {
                var input = Console.ReadLine().Split();
                rectangles.Add(new Rectangle(input[0], int.Parse(input[1]),
                    int.Parse(input[2]), int.Parse(input[3]), int.Parse(input[4])));
            }

            CheckIntersections(int.Parse(firstLine[1]), rectangles);
        }

        private static void CheckIntersections(int numberOfIntersectionChecks, HashSet<Rectangle> rectangles)
        {
            while (numberOfIntersectionChecks > 0)
            {
                var pair = Console.ReadLine().Split();
                var firstRect = rectangles.FirstOrDefault(r => r.Id == pair[0]);
                var secondRect = rectangles.FirstOrDefault(r => r.Id == pair[1]);

                Console.WriteLine(firstRect.IsIntersect(secondRect) ? "true" : "false");

                numberOfIntersectionChecks--;
            }
        }
    }
}