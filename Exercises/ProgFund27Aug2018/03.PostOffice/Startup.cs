namespace _03.PostOffice
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class Startup
    {
        public static void Main()
        {
            var inputParts = Console.ReadLine().Split('|').ToArray();
            var partOne = inputParts[0];
            var partTwo = inputParts[1];
            var partThree = inputParts[2];

            char[] letters =  new char[1];
            var lettersAndLength = new Dictionary<char, int>();

            string patternOne = @"([#$%*&])([A-Z]{1,})([#$%*&])";

            foreach (Match m in Regex.Matches(partOne, patternOne))
            {
                if (m.Groups[1].Value == m.Groups[3].Value)
                { // Valid
                    letters = m.Groups[2].Value.ToCharArray();
                }
            }

            string patternTwo = @"([0-9]{2}):([0-9]{2})";

            foreach (Match m in Regex.Matches(partTwo, patternTwo))
            {
                var letter = (char)int.Parse(m.Groups[1].Value);

                if (letters.Contains(letter) && !lettersAndLength.ContainsKey(letter))
                {
                    var length = int.Parse(m.Groups[2].Value) + 1;

                    lettersAndLength.Add(letter, length);
                }
            }

            string patternThree = @" (L[^ ]{C})\b";

            foreach (var letter in letters)
            {
                var currentPattern = patternThree
                    .Replace('L', letter)
                    .Replace("C", (lettersAndLength[letter] - 1).ToString());

                foreach (Match m in Regex.Matches(partThree, currentPattern))
                {
                    Console.WriteLine(m.Groups[1].Value);
                }
            }
        }
    }
}
