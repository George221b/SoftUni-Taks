using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MaxElement
{
    public class Startup
    {
        public static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();
            int maxElement = int.MinValue;
            Stack<int> maxStack = new Stack<int>();

            for (int i = 0; i < numberOfCommands; i++)
            {
                int[] command = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();

                if (command[0] == 1)
                {
                    if (command[1] > maxElement)
                    {
                        maxElement = command[1];
                        maxStack.Push(maxElement);
                    }
                    stack.Push(command[1]);
                }
                else if (command[0] == 2 && stack.Count > 0)
                {
                    if (stack.Peek() == maxElement)
                    {
                        maxStack.Pop();
                        if (maxStack.Count == 0)
                        {
                            maxElement = int.MinValue;
                            continue;
                        }
                        maxElement = maxStack.Peek();
                    }
                    stack.Pop();
                }
                else if (command[0] == 3)
                {
                    Console.WriteLine(maxElement);
                }
            }
        }
    }
}
