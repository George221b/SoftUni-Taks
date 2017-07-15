using System;
using System.Linq;

namespace _02.KnightsOfHonor
{
    public class KnightsOfHonor
    {
        public static void Main()
        {
            Action<string> appendSir = AppendSir;

            Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList()
                .ForEach(x => appendSir(x));
        }

        private static void AppendSir(string name)
        {
            Console.WriteLine(name = "Sir " + name);
        }
    }
}
