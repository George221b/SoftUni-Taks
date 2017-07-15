using System;
using System.Collections.Generic;

namespace _08.RecursiveFibonacci
{
    public class Startup
    {
        public static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var fib = new Dictionary<int, long>();

            long result = Fibonacci(number, fib);
            Console.WriteLine(result);
        }

        private static long Fibonacci(int n, Dictionary<int, long> fib)
        {

            if (n == 1 || n == 2)
            {
                return 1;
            }
            else if (fib.ContainsKey(n))
            {
                return fib[n];
            }
            else
            {
                var current = Fibonacci(n - 2, fib) + Fibonacci(n - 1, fib);
                if (!fib.ContainsKey(n))
                {
                    fib.Add(n, current);
                }
                return current;
            }
        }
    }
}
