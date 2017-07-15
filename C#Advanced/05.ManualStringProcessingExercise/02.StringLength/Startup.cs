using System;

namespace _02.StringLength
{
    public class Startup
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            Console.WriteLine(input.PadRight(20, '*'));
        }
    }
}
