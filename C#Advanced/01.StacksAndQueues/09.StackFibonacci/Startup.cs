using System;
using System.Collections.Generic;

namespace _09.StackFibonacci
{
    public class Startup
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var stack = new Stack<long>();
            stack.Push(1);
            stack.Push(1);
            stack.Push(1);

            for (int i = 3; i <= n; i++)
            {
                var minusOne = stack.Pop();
                var minusTwo = stack.Peek();
                stack.Push(minusOne);

                var currentFibonacci = minusOne + minusTwo;
                stack.Push(currentFibonacci);
            }

            Console.WriteLine(stack.Peek());
        }
    }
}