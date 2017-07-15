using System;
using System.Text.RegularExpressions;

namespace _01.MatchFullName
{
    public class MatchFullName
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            Regex regex = new Regex(@"\b([A-Z]{1}[a-z]{1,}) ([A-Z]{1}[a-z]{1,})\b");
            while (!input.Equals("end"))
            {
                Match match = regex.Match(input);
                if (match.Success)
                {
                    Console.WriteLine(match);
                }

                input = Console.ReadLine();
            }
        }
    }
}
