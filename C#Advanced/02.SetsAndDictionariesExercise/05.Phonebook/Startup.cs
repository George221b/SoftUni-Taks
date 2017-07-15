using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Phonebook
{
    public class Startup
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var phonebook = new Dictionary<string, string>();

            while (input != "search")
            {
                string[] inputArgs = input.Trim().Split('-').ToArray();

                if (!phonebook.ContainsKey(inputArgs[0]))
                {
                    phonebook.Add(inputArgs[0], inputArgs[1]);
                }
                else
                {
                    phonebook[inputArgs[0]] = inputArgs[1];
                }

                input = Console.ReadLine();
            }

            while (input != "stop")
            {
                input = Console.ReadLine();
                if (input == "stop")
                {
                    return;
                }
                if (!phonebook.ContainsKey(input))
                {
                    Console.WriteLine($"Contact {input} does not exist.");
                }
                else
                {
                    Console.WriteLine($"{phonebook.FirstOrDefault(x => x.Key == input).Key} -> {phonebook.FirstOrDefault(x => x.Key == input).Value}");
                }
            }
        }
    }
}
