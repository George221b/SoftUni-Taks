using System;
using System.Linq;

namespace _03.Stack
{
    public class Startup
    {
        public static void Main()
        {
            var myStack = new Stack<string>();
            var input = Console.ReadLine();

            while (input != "END")
            {
                var tokens = input.Split(new []{' ', ','}, StringSplitOptions.RemoveEmptyEntries).ToList();
                var command = tokens[0];
                tokens.Remove(command);

                try
                {
                    switch (command)
                    {
                        case "Push":
                            myStack.Push(tokens.ToArray());
                            break;
                        case "Pop":
                            myStack.Pop();
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                input = Console.ReadLine();
            }

            for (int i = 0; i < 2; i++)
            {
                foreach (var element in myStack)
                {
                    Console.WriteLine(element);
                }
            }
        }
    }
}
