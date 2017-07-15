using System;
using System.Text.RegularExpressions;

namespace _06.SentanceExtractor
{
    public class SentanceExtractor
    {
        public static void Main()
        {
            string keyword = Console.ReadLine();
            string input = Console.ReadLine();

            string pattern = $@"[^.!?]+?\b{keyword}\b[^.!?]+?[!?.]";
            Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);

            MatchCollection matches = regex.Matches(input);

            foreach (Match match in matches)
            {
                Console.WriteLine(match);
            }
        }
    }
}
