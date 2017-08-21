using System;

namespace GenericBox
{
    public class Startup
    {
        public static void Main()
        {
            int numberOfCommands = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfCommands; i++)
            {
                var box = new Box<int>(int.Parse(Console.ReadLine()));
                Console.WriteLine(box);
            }
        }
    }
}
