using System;
using System.Collections.Generic;

namespace _05.SequenceWithQueue
{
    class Startup
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            Queue<long> queue = new Queue<long>();
            List<long> result = new List<long>();
            queue.Enqueue(n);
            result.Add(n);

            while (queue.Count <= 50)
            {
                long currentEl = queue.Dequeue();
                long firstEl = currentEl + 1;
                long secondEl = (2 * currentEl) + 1;
                long thirdEl = currentEl + 2;

                queue.Enqueue(firstEl);
                queue.Enqueue(secondEl);
                queue.Enqueue(thirdEl);

                result.Add(firstEl);
                result.Add(secondEl);
                result.Add(thirdEl);
            }

            for (int i = 0; i < 50; i++)
            {
                Console.Write($"{result[i]} ");
            }
        }
    }
}
