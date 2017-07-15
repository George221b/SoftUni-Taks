using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _05.ExtractTags
{
    public class Startup
    {
        public static void Main()
        {
            var html = ReadInput();
            var matches = Regex.Matches(html, "<.+?>");

            if (matches.Count > 0)
            {
                foreach (var match in matches)
                {
                    Console.WriteLine(match);
                }
            }
        }

        private static string ReadInput()
        {
            var sb = new StringBuilder();
            var line = Console.ReadLine();

            while (line != "END")
            {
                sb.Append(line);
                line = Console.ReadLine();
            }

            return sb.ToString();
        }
    }
}
