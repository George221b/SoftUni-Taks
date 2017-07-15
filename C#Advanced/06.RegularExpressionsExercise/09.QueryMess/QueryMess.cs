using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _09.QueryMess
{

    public class QueryMess
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            while (input != "END")
            {
                var elements = input.Split(new[] { '&', '?' })
                    .Where(x => x.Contains('='))
                    .Select(x => x.Replace("%20", " "))
                    .Select(x => x.Replace('+', ' '))
                    .ToArray();

                Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();

                foreach (var element in elements)
                {
                    var fieldValues = element.Split('=').Select(x => x.Trim()).ToArray();
                    var field = fieldValues[0];
                    var value = Regex.Replace(fieldValues[1], @"\s+", " ").Trim();

                    if (!dict.ContainsKey(fieldValues[0]))
                    {
                        dict[field] = new List<string> { value };
                    }
                    else
                    {
                        dict[field].Add(value);
                    }
                }

                foreach (var fieldValues in dict)
                {
                    Console.Write($"{fieldValues.Key}=[{string.Join(", ", fieldValues.Value)}]");

                }
                Console.WriteLine();

                input = Console.ReadLine();
            }
        }
    }
}
