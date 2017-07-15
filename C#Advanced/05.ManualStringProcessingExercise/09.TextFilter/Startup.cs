using System;

namespace _09.TextFilter
{
    public class Startup
    {
        public static void Main()
        {
            var bannWords = Console.ReadLine().Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

            var text = Console.ReadLine();

            foreach (var word in bannWords)
            {
                int lengthOfWord = word.Length;

                int beginIndex = text.IndexOf(word);
                if (beginIndex != -1)
                {
                    text = text.Replace(word, new string('*', lengthOfWord));
                }
            }
            Console.WriteLine(text);
        }
    }
}
