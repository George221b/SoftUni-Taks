using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.PopulationCounter
{
    public class PopulationCounter
    {
        public static void Main()
        {
            var dict = new Dictionary<string, Dictionary<string, long>>();
            var inputLine = Console.ReadLine();

            while (inputLine != "report")
            {
                var inputTokens = inputLine.Split(new [] {'|'}, StringSplitOptions.RemoveEmptyEntries);
                var country = inputTokens[1];
                var city = inputTokens[0];
                var cityPopulation = long.Parse(inputTokens[2]);

                if (!dict.ContainsKey(country))
                {
                    dict[country] = new Dictionary<string, long>()
                    {
                        {city, cityPopulation}
                    };
                }
                // !!! A city-country pair will not be repeated.
                else
                {
                    dict[country][city] = cityPopulation;
                }

                inputLine = Console.ReadLine();
            }

            foreach (var country in dict.OrderByDescending(x => x.Value.Values.Sum()))
            {
                Console.WriteLine($"{country.Key} (total population: {country.Value.Values.Sum()})");
                foreach (var city in country.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"=>{city.Key}: {city.Value}");
                }
            }
        }
    }
}
