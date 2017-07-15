using System;
using System.Text.RegularExpressions;

namespace _04.ReplaceATag
{
    public class ReplaceATag
    {
        public static void Main()
        {
            var htmlLine = Console.ReadLine();
            string pattern = @"(<a)(\s+href="".*"")(>)(.*)(<\/a>)";
            Regex regex = new Regex(pattern);

            while (htmlLine != "end")
            {
                Match match = regex.Match(htmlLine);
                if (match.Success)
                {
                    // Console.WriteLine(match);

                    var replaced = Regex.Replace(htmlLine, pattern,
                        m => "[URL" + m.Groups[2].Value + "]" + m.Groups[4].Value + "[/URL]");
                    Console.WriteLine(replaced);
                }
                else
                {
                    Console.WriteLine(htmlLine);
                }

                htmlLine = Console.ReadLine();
            }
        }
    }
}
