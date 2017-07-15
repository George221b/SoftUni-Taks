using System;
using System.Linq;

namespace _03.CountUppercaseWords
{
    public class CountUppercaseWords
    {
        public static void Main()
        {
            Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList()
                .Where(x => Char.IsUpper(x[0]))
                .ToList()
                .ForEach(x => Console.WriteLine(x));
        }
    }
}
