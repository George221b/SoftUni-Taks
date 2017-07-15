using System;
using System.Text.RegularExpressions;

namespace _02.MatchPhoneNumber
{
    public class MatchPhoneNumber
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            Regex regex = new Regex(@"\+359( |-)2\1\d{3}\1\d{4}\b");
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
