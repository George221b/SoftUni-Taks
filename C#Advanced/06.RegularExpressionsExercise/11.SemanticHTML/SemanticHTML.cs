using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _11.SemanticHTML
{
    public class SemanticHTML
    {
        public const string OpenPattern = @"(<\s*div\b)(.*?)((id|class)\s*=\s*""(\w+)"")(.*?>)";
        //Group 1. `< div`
        //Group 2. ` align = "left" `
        //Group 3. `id = "nav"`
        //Group 4. `id`
        //Group 5. `nav`
        //Group 6. ` style = "color:blue" >`

        public const string ClosePattern = @"<\s*\/\s*div\s*>\s*<\s*!\s*--\s*(\w+)\s*--\s*>";
        //Group 1.	`nav`
        //< / div > <!-- nav -->

        public static void Main()
        {
            var inputLine = Console.ReadLine();
            StringBuilder sb = new StringBuilder();

            while (inputLine != "END")
            {
                if (Regex.IsMatch(inputLine, OpenPattern))
                {
                    inputLine = Regex.Replace(inputLine, "\\s+", " ");

                    string tag = Regex.Match(inputLine, OpenPattern).Groups[5].Value.Trim();

                    inputLine = Regex.Replace(inputLine, OpenPattern,
                        x => "<" + tag + x.Groups[2].Value.TrimEnd() + x.Groups[6].Value.TrimEnd());

                    if (inputLine.LastIndexOf(' ') == inputLine.Length - 2)
                    {
                        inputLine = inputLine.Remove(inputLine.Length - 2, 1);
                    }
                }
                else if (Regex.IsMatch(inputLine, ClosePattern))
                {
                    string tag = Regex.Match(inputLine, ClosePattern).Groups[1].Value;
                    inputLine = Regex.Replace(inputLine, ClosePattern,
                        x => "</" + tag + ">");
                }

                sb.AppendLine(inputLine);

                inputLine = Console.ReadLine();
            }

            Console.WriteLine(sb);
        }
    }
}
