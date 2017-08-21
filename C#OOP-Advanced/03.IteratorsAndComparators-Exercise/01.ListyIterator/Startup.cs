using System;
using System.Linq;

namespace _01.ListyIterator
{
    public class Startup
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var myList = new ListyIterator<string>();

            while (input != "END")
            {
                var tokens = input.Split().ToList();
                var command = tokens.First();
                tokens.Remove(command);

                try
                {
                    switch (command)
                    {
                        case "Create":
                            myList.Create(tokens.ToArray());
                            break;
                        case "Move":
                            Console.WriteLine(myList.Move());
                            break;
                        case "Print":
                            myList.Print();
                            break;
                        case "HasNext":
                            Console.WriteLine(myList.HasNext());
                            break;
                        case "PrintAll":
                            myList.PrintAll();
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                input = Console.ReadLine();
            }
        }
    }
}
