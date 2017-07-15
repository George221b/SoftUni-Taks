using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.BasicStackOperations
{
    public class Startup
    {
        public static void Main()
        {
            int[] inputArgs = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();
            int[] elements = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();
            int push = inputArgs[0];
            int pop = inputArgs[1];
            int check = inputArgs[2];

            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < push; i++)
            {
                stack.Push(elements[i]);
            }

            for (int i = 0; i < pop; i++)
            {
                if (stack.Count == 1)
                {
                    stack.Pop();
                    break;
                }
                stack.Pop();
            }

            if (stack.Count == 0)
            {
                Console.WriteLine(0);
            }
            else if (stack.Contains(check))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(stack.Min());
            }
        }
    }
}
