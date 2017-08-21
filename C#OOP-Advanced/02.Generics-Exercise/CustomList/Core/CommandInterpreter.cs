using System;
using System.Collections.Generic;
using CustomList.Interfaces;

namespace CustomList.Core
{
    public class CommandInterpreter
    {
        private CustomList<string> customList = new CustomList<string>();

        public CommandInterpreter()
        {
            this.customList = new CustomList<string>();
        }

        public void ProcessCommand(List<string> tokens)
        {
            switch (tokens[0])
            {
                case "Add":
                    customList.Add(tokens[1]);
                    break;
                case "Remove":
                    customList.Remove(int.Parse(tokens[1]));
                    break;
                case "Contains":
                    Console.WriteLine(customList.Contains(tokens[1]));
                    break;
                case "Swap":
                    customList.Swap(int.Parse(tokens[1]), int.Parse(tokens[2]));
                    break;
                case "Greater":
                    Console.WriteLine(customList.CountGreaterThan(tokens[1]));
                    break;
                case "Max":
                    Console.WriteLine(customList.Max());
                    break;
                case "Min":
                    Console.WriteLine(customList.Min());
                    break;
                case "Print":
                    foreach (var element in customList.List)
                    {
                        Console.WriteLine(element.ToString());
                    }
                    break;
                case "Sort":
                    customList.List = Sorter<string>.Sort(customList.List);
                    break;
                default:
                    break;
            }
        }
    }
}
