using System;
using System.Text.RegularExpressions;

namespace _01.MatchCount
{
    public class Startup
    {
        public static void Main()
        {
            var key = Console.ReadLine();
            var text = Console.ReadLine();

            var matchesCount = Regex.Matches(text, key).Count;
            Console.WriteLine(matchesCount);
        }
    }
}
