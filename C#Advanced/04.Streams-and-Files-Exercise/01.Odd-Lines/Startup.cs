using System;
using System.IO;

namespace _01.Odd_Lines
{
    public class Startup
    {
        public static void Main()
        {
            StreamReader reader = new StreamReader(@"..\..\CityOfStars.txt");
            using (reader)
            {
                int lineCounter = 0;
                var line = reader.ReadLine();
                Console.WriteLine($"Line {lineCounter:D2}: {line}");

                while (line != null)
                {
                    if (lineCounter % 2 != 0)
                    {
                        Console.WriteLine($"Line {lineCounter:D2}: {line}");
                    }

                    lineCounter++;
                    line = reader.ReadLine();
                }
            }
        }
    }
}
