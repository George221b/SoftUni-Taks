namespace _03.StarEnigma
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class Program
    {
        public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var attackedPlanets = new List<string>();
            var destroyedPlanets = new List<string>();
            var pattern = @"@([A-Za-z]+).*:([0-9]+).*!(A|D)!.*->([0-9]+)";

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();

                var decryptionKey = input
                    .ToLower()
                    .ToCharArray()
                    .Where(ch => ch == 's' || ch == 't' || ch == 'a' || ch == 'r')
                    .Count();

                var message = string.Join(string.Empty, input
                    .ToCharArray()
                    .Select(ch => (char)(ch - decryptionKey)));

                if (Regex.IsMatch(message, pattern))
                {
                    var match = Regex.Match(message, pattern);

                    var planetName = match.Groups[1].Value;
                    var attackedOrDestroyed = match.Groups[3].Value;

                    if (attackedOrDestroyed == "A")
                    {
                        attackedPlanets.Add(planetName);
                    }
                    else
                    {
                        destroyedPlanets.Add(planetName);
                    }
                }
            }

            Console.WriteLine($"Attacked planets: {attackedPlanets.Count}");
            attackedPlanets
                .OrderBy(pl => pl)
                .ToList()
                .ForEach(pl => Console.WriteLine($"-> {pl}"));
            Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");
            destroyedPlanets
                .OrderBy(pl => pl)
                .ToList()
                .ForEach(pl => Console.WriteLine($"-> {pl}"));
        }
    }
}
