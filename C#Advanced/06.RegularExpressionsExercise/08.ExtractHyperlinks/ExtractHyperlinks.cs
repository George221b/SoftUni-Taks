using System;
using System.Text.RegularExpressions;

namespace _08.ExtractHyperlinks
{
    public class ExtractHyperlinks
    {
        static void Main()
        {
            string input = "";
            string currentLine = Console.ReadLine();

            while (currentLine != "END")
            {
                input += currentLine;
                currentLine = Console.ReadLine();
            }

            MatchCollection aTags = Regex.Matches(input, "<a.+?>");

            string firstPattern = "href\\s*?=\\s*?(\"(.*?)\")";
            string secondPattern = "href\\s*?=\\s*?('(.*?)')";
            string thirdPattern = "href\\s*?=\\s*?(.+?)[\\s>]";

            foreach (Match tag in aTags)
            {
                string currentTag = tag.ToString();

                if (Regex.IsMatch(currentTag, firstPattern))
                {
                    Match match = Regex.Match(currentTag, firstPattern);
                    Console.WriteLine(match.Groups[2]);
                }
                else if (Regex.IsMatch(currentTag, secondPattern))
                {
                    Match match = Regex.Match(currentTag, secondPattern);
                    Console.WriteLine(match.Groups[2]);
                }
                else if (Regex.IsMatch(currentTag, thirdPattern))
                {
                    Match match = Regex.Match(currentTag, thirdPattern);
                    Console.WriteLine(match.Groups[1]);
                }
            }
        }
    }
}
