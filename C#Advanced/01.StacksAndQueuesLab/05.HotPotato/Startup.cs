using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.HotPotato
{
    public class Startup
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();
            int tosses = int.Parse(Console.ReadLine());
            Queue<string> queue = new Queue<string>(input);

            while (queue.Count != 1)
            {
                for (int i = 1; i < tosses; i++)
                {
                    queue.Enqueue(queue.Dequeue());
                }
                Console.WriteLine($"Removed {queue.Dequeue()}");
            }
            Console.WriteLine($"Last is {queue.Dequeue()}");
        }
    }
}
