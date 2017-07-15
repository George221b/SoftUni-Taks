using System;
using System.Text.RegularExpressions;

namespace _05.ExtractEmails
{
    public class ExtractEmails
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            MatchCollection matches;
            foreach (var line in input)
            {
                matches = Regex.Matches(line,
                @"^[a-zA-Z0-9]+(-?|_?|\.?)*([a-z0-9]+)@[a-z]+(-?)([a-z]*)\.?[a-z]+\.[a-z]+");

                foreach (Match match in matches)
                {
                    Console.WriteLine(match);
                }
            }
        }
    }
}
