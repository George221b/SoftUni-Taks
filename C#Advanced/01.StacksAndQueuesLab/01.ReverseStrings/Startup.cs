using System;
using System.Collections.Generic;

namespace _01.ReverseStrings
{
    public class Startup
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var stack = new Stack<char>();
            foreach (var ch in input)
            {
                stack.Push(ch);
            }
            while (stack.Count != 0)
            {
                Console.Write(stack.Pop());
            }
            Console.WriteLine();


            //string input = Console.ReadLine();
            //Stack<char> stack = new Stack<char>(input);
            //Console.WriteLine(string.Join("", stack));
        }
    }
}
