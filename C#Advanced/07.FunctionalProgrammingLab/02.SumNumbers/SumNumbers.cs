using System;
using System.Linq;

namespace _02.SumNumbers
{
    public class SumNumbers
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            Console.WriteLine(
                input
                .Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Count());
            Console.WriteLine(
                 input
                .Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Sum());
        }
    }
}
