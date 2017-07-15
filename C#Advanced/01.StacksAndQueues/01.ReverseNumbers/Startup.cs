using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.ReverseNumbers
{
    public class Startup
    {
        public static void Main()
        {
            int[] input = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();

            Stack<int> stack = new Stack<int>();
            foreach (int num in input)
            {
                stack.Push(num);
            }

            for (int i = 0; i < input.Length; i++)
            {
                Console.Write($"{stack.Pop()} ");
            }
            Console.WriteLine();
        }
    }
}
