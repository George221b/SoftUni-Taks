using System;
using System.Text.RegularExpressions;

namespace _03.SeriesOfLetters
{
    public class SeriesOfLetters
    {
        public static void Main()
        {
            var text = Console.ReadLine();

            // var result = Regex.Replace(text, @"([A-Za-z])\1+", m => m.Groups[1].Value); // Both variations work Identically
            var result = Regex.Replace(text, @"([A-Za-z])\1+", "$1"); // Both variations work Identically


            Console.WriteLine(result);
        }
    }
}
