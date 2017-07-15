using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.SimpleCalculator
{
    public class Startup
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();
            Stack<string> stack = new Stack<string>(input.Reverse());

            while (stack.Count != 1)
            {
                int firstNumber = int.Parse(stack.Pop());
                string sign = stack.Pop();
                int secondNumber = int.Parse(stack.Pop());

                switch (sign)
                {
                    case "+":
                        stack.Push((firstNumber + secondNumber).ToString());
                        break;
                    default:
                        stack.Push((firstNumber - secondNumber).ToString());
                        break;
                }
            }
            Console.WriteLine(stack.Pop());
        }
    }
}
