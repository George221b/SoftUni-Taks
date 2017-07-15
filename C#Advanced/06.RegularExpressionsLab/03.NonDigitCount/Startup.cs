using System;
using System.Text.RegularExpressions;

namespace _03.NonDigitCount
{
    public class Startup
    {
        public static void Main()
        {
            var text = Console.ReadLine();
            var nonDigits = Regex.Matches(text, @"\D").Count;
            Console.WriteLine($"Non-digits: {nonDigits}");
        }
    }
}
