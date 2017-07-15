using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.SpecialWords
{
    public class Startup
    {
        public static void Main()
        {
            var specialWords = Console.ReadLine().Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var textWords = Console.ReadLine().Trim()
                .Split(new char[] { '(', ')', ']', ']', '<', '>', ',', '-', '!', '?', ' ', '‘', '’' }, StringSplitOptions.RemoveEmptyEntries);

            var dict = new Dictionary<string, int>();

            foreach (var special in specialWords)
            {
                foreach (var word in textWords)
                {
                    if (special == word)
                    {
                        if (!dict.ContainsKey(special))
                        {
                            dict[special] = 1;
                        }
                        else
                        {
                            dict[special]++;
                        }
                    }
                }
            }

            foreach (var match in dict)
            {
                Console.WriteLine($"{match.Key} - {match.Value}");
            }
            if (dict.Count != specialWords.Count())
            {
                foreach (var word in specialWords)
                {
                    if (!dict.ContainsKey(word))
                    {
                        Console.WriteLine($"{word} - 0");
                    }
                }
            }
        }
    }
}
