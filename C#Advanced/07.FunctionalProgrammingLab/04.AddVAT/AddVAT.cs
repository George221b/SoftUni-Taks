using System;
using System.Linq;

namespace _04.AddVAT
{
    public class AddVAT
    {
        public static void Main()
        {
            Console.ReadLine()
                .Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => double.Parse(x) * 1.2)
                .ToList()
                .ForEach(x => Console.WriteLine($"{x:F2}"));
        }
    }
}
