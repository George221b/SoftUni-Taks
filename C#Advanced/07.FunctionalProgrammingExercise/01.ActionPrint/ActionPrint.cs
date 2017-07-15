using System;
using System.Linq;

namespace _01.ActionPrint
{
    public class ActionPrint
    {
        public static void Main()
        {
            Action<string> printNames = n => Console.WriteLine(n);

            Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList()
                .ForEach(printNames);
        }
    }
}
