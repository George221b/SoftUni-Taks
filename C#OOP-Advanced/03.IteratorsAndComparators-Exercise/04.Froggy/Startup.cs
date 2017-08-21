using System;
using System.Linq;

namespace _04.Froggy
{
    public class Startup
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine()
                .Split(new[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var lake = new Lake(inputLine);

            Console.WriteLine(string.Join(", ", lake));
        }
    }
}
