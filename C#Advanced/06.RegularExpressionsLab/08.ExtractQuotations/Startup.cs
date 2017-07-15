using System;
using System.Text.RegularExpressions;

namespace _08.ExtractQuotations
{
    public class Startup
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            MatchCollection matches = Regex.Matches(input, @"(['|""])([\S\s]+?)\1");

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Groups[2]);
            }
        }
    }
}
