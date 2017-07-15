using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.Palindroms
{
    public class Startup
    {
        public static void Main()
        {
            string[] input = Console.ReadLine()
                .Split(new char[] { ' ', ',', '!', '?', '.' }, StringSplitOptions.RemoveEmptyEntries);

            List<string> palindromes = new List<string>();

            foreach (var word in input)
            {
                char[] reversedArr = word.ToCharArray();
                Array.Reverse(reversedArr);
                string reveresed = new string(reversedArr);

                if (reveresed.Equals(word) && !palindromes.Contains(word))
                {
                    palindromes.Add(word);
                }
            }

            palindromes = palindromes.OrderBy(p => p).ToList();
            string[] arr = palindromes.ToArray();

            Console.WriteLine("[" + string.Join(", ", arr) + "]");
        }
    }
}
