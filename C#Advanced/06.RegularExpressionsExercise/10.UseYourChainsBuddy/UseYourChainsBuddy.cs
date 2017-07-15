using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _10.UseYourChainsBuddy
{
    public class UseYourChainsBuddy
    {
        public const string FirstPattern = @"<(\s*)p(\s*)>(.*?)<(\s*)\/p(\s*)>"; // Group 3 - <p> Value

        public const string SecondPattern = @"[^a-z0-9]+";

        public static void Main()
        {
            var input = Console.ReadLine();

            MatchCollection matches = Regex.Matches(input, FirstPattern);
            StringBuilder sb = new StringBuilder();

            foreach (Match match in matches)
            {
                string pValue = match.Groups[3].Value;

                pValue = Regex.Replace(pValue, SecondPattern, " ");

                foreach (char character in pValue)
                {
                    DecryptCharacter(character, sb);
                }
            }

            Console.WriteLine(sb);
        }

        private static void DecryptCharacter(char character, StringBuilder sb)
        {
            if (character >= 'a' && character <= 'm')
            {
                sb.Append((char)(character + 13));
            }
            else if (character >= 'n' && character <= 'z')
            {
                sb.Append((char)(character - 13));
            }
            else
            {
                sb.Append(character);
            }
        }
    }
}
