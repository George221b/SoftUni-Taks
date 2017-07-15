using System;
using System.Linq;

namespace _13.MagicExchangableWords100
{
    public class Startup
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split();
            var firstChars = input[0].ToCharArray().Distinct().ToArray();
            var secondChars = input[1].ToCharArray().Distinct().ToArray();
            Console.WriteLine(firstChars.Length == secondChars.Length ? "true" : "false");
        }
    }
}
