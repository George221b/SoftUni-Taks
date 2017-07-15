using System;
using System.IO;

namespace _02.LineNumbers
{
    public class Startup
    {
        public static void Main()
        {
            StreamReader reader = new StreamReader(@"..\..\CityOfStars.txt");
            StreamWriter writer = new StreamWriter(@"..\..\Edited.txt");
            Console.WriteLine("Editing started.");
            using (reader)
            {
                using (writer)
                {
                    int lineNum = 1;
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        writer.WriteLine($"{lineNum:D2}| " + line);
                        line = reader.ReadLine();
                        lineNum++;
                    }
                }
            }

            Console.WriteLine("Editing finished.");
        }
    }
}
