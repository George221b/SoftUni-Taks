using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04.AshesOfRoses
{
    public class AshesOfRoses
    {
        public static void Main()
        {
            var dict = new Dictionary<string, Dictionary<string, long>>();
            var input = Console.ReadLine();
            var checkList = new List<string>();

            while (input != "Icarus, Ignite!")
            {
                checkList.Add(input);
                input = Console.ReadLine();
            }

            var validInput = CheckInput(checkList);

            foreach (var element in validInput)
            {
                //Grow <{regionName}> <{colorName}> {roseAmount}

                var elementTokens = element.Split().ToArray();
                var region = elementTokens[1].Trim(new [] {'<', '>'});
                var color = elementTokens[2].Trim(new[] { '<', '>' });
                var amount = long.Parse(elementTokens[3]);

                if (!dict.ContainsKey(region))
                {
                    dict[region] = new Dictionary<string, long>()
                    {
                        {color, amount}
                    };
                }
                else if (!dict[region].ContainsKey(color))
                {
                    dict[region][color] = amount;
                }
                else
                {
                    dict[region][color] += amount;
                }
            }

            PrintDictionary(dict);
        }

        private static void PrintDictionary(Dictionary<string, Dictionary<string, long>> dict)
        {
            foreach (var region in dict
                .OrderByDescending(x => x.Value.Select(y => y.Value).Sum())
                .ThenBy(x => x.Key))
            {
                Console.WriteLine(region.Key);
                foreach (var roseColor in region.Value.OrderBy(x => x.Value).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"*--{roseColor.Key} | {roseColor.Value}");
                }
            }
        }

        private static List<string> CheckInput(List<string> checkList)
        {
            var valid = new List<string>();
            string pattern = "^Grow <[A-Z][a-z]+> <[A-Za-z0-9]+> \\d*$";
            Regex regex = new Regex(pattern);

            foreach (var item in checkList)
            {
                if (regex.IsMatch(item))
                {
                    valid.Add(item);
                }
            }

            return valid;
        }
    }
}
