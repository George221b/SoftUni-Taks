using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Applied_Arithmetics
{
    class AppliedArithmetics
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            Func<List<int>, List<int>> addOne = x => x.Select(y => y + 1).ToList();
            Func<List<int>, List<int>> multiplyByTwo = x => x.Select(y => y * 2).ToList();
            Func<int, int> subtractByOne = x => x - 1;

            string command = Console.ReadLine();

            while (command != "end")
            {

                switch (command)
                {
                    case "add":
                        numbers = addOne(numbers);
                        break;
                    case "multiply":
                        numbers = multiplyByTwo(numbers);
                        break;
                    case "subtract":
                        numbers = numbers.Select(subtractByOne).ToList();
                        break;
                    case "print":
                        Console.WriteLine(string.Join(" ", numbers));
                        break;
                }

                command = Console.ReadLine();
            }
        }
    }
}