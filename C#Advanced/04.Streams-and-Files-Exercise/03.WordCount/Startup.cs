using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace _03.WordCount
{
    public class Startup
    {
        public static void Main()
        {
            StreamReader readerWords = new StreamReader(@"..\..\words.txt");
            StreamReader readerText = new StreamReader(@"..\..\text.txt");
            StreamWriter writer = new StreamWriter(@"..\..\result.txt");
            Console.WriteLine("=> Searching <=");

            using (readerWords)
            {
                using (readerText)
                {
                    using (writer)
                    {
                        StringBuilder builder = new StringBuilder();
                        StringBuilder builder2 = new StringBuilder();

                        var line = readerWords.ReadLine();
                        while (line != null)
                        {
                            builder.Append(line.ToLower() + " ");
                            line = readerWords.ReadLine();
                        }

                        line = readerText.ReadLine();
                        while (line != null)
                        {
                            builder2.Append(line.ToLower() + " ");
                            line = readerText.ReadLine();
                        }

                        var wordsFileElements = builder.ToString().Split(new[] { ' ', '!', '?', '.', '-', ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                        var textFileElements = builder2.ToString().Split(new[] { ' ', '!', '?', '.', '-', ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();

                        var results = wordsFileElements.Intersect(textFileElements);

                        var dict = new Dictionary<string, int>();

                        foreach (var word in results)
                        {
                            var count = textFileElements.Where(x => x == word).Count();
                            dict[word] = count;
                        }

                        foreach (var entry in dict.OrderByDescending(d => d.Value))
                        {
                            writer.WriteLine($"{entry.Key} - {entry.Value}");
                        }
                    }
                }
            }

            Console.WriteLine("Done.");
        }
    }
}
