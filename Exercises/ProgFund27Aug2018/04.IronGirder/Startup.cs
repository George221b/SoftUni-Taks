namespace _04.IronGirder
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var towns = new List<Town>();

            while (input != "Slide rule")
            {
                var tokens = input
                    .Split(new string[] { ":", "->" }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (tokens[1] == "ambush")
                {
                    var townName = tokens[0];
                    var passangers = int.Parse(tokens[2]);

                    var currentTown = towns.FirstOrDefault(t => t.Name == townName);

                    if (currentTown != null)
                    {
                        currentTown.AmbushTown(passangers);
                    }
                }
                else
                {
                    var townName = tokens[0];
                    var time = int.Parse(tokens[1]);
                    var passangers = int.Parse(tokens[2]);

                    if (!towns.Exists(t => t.Name == townName))
                    {
                        towns.Add(new Town(townName, time, passangers));
                    }
                    else
                    {
                        var currentTown = towns.First(t => t.Name == townName);

                        if (time > 0)
                        {
                            if (time < currentTown.BestTime || currentTown.BestTime == 0)
                            {
                                currentTown.BestTime = time;
                            }
                        }

                        currentTown.Passangers += passangers;
                    }
                }

                input = Console.ReadLine();
            }

            var neededTowns = towns
                .Where(t => t.BestTime != 0 && t.Passangers > 0)
                .OrderBy(t => t.BestTime)
                .ThenBy(t => t.Name)
                .Select(t => t.ToString())
                .ToList();

            Console.WriteLine(string.Join(Environment.NewLine, neededTowns));
        }
    }
}
