using System;
using System.Collections.Generic;
using System.Linq;

namespace _13.MagicExchangeableWords
{
    public class Startup
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            Queue<char> firstWord = new Queue<char>(input[0]);
            Queue<char> secondWord = new Queue<char>(input[1]);

            bool result = AreWordsExchangeable(firstWord, secondWord);
            Console.WriteLine(result.ToString().ToLower());
        }

        private static bool AreWordsExchangeable(Queue<char> firstWord, Queue<char> secondWord)
        {
            Dictionary<char, char> dict = new Dictionary<char, char>();

            while (firstWord.Count != 0 && secondWord.Count != 0)
            {
                char ch1 = firstWord.Dequeue();
                char ch2 = secondWord.Dequeue();

                if (!dict.ContainsKey(ch1))
                {
                    dict.Add(ch1, ch2);
                }
                else
                {
                    if (dict[ch1] != ch2)
                    {
                        return false;
                    }
                }
            }

            if (firstWord.Count > 0)
            {
                while (firstWord.Count != 0)
                {
                    char ch = firstWord.Dequeue();

                    if (!dict.ContainsKey(ch))
                    {
                        return false;
                    }
                }
            }

            if (secondWord.Count > 0)
            {
                while (secondWord.Count != 0)
                {
                    char ch = secondWord.Dequeue();

                    if (!dict.ContainsValue(ch))
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
