using System;
using System.Linq;

namespace _06.FindAndSumIntegers
{
    public class FindAndSumIntegers
    {
        public static void Main()
        {
            var result =
                Console.ReadLine()
                .Split()
                .Select(x =>
                {
                    long num = 0;
                    bool isNum = long.TryParse(x, out num);

                    return new {num, isNum};

                })
                .Where(x => x.isNum)
                .Select(x => x.num)
                .ToArray();

            Console.WriteLine(result.Length != 0 ? result.Sum().ToString() : "No match");
        }
    }
}
