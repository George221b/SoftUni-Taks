using System;
using System.Collections.Generic;
using System.Linq;

namespace _14.DragonArmy
{
    public class Startup
    {

        public static void Main()
        {
            var dragons = new Dictionary<string, SortedDictionary<string, List<int?>>>();

            var numberOfDragons = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfDragons; i++)
            {
                var inputArgs = Console.ReadLine().Trim()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string type = inputArgs[0];
                string name = inputArgs[1];
                int damage;
                int health;
                int armor;

                if (inputArgs[2].Equals("null"))
                    damage = 45;
                else
                    damage = int.Parse(inputArgs[2]);

                if (inputArgs[3].Equals("null"))
                    health = 250;
                else
                    health = int.Parse(inputArgs[3]);

                if (inputArgs[4].Equals("null"))
                    armor = 10;
                else
                    armor = int.Parse(inputArgs[4]);

                if (dragons.ContainsKey(type) && dragons[type].ContainsKey(name))
                {
                    dragons[type][name][0] = damage;
                    dragons[type][name][1] = health;
                    dragons[type][name][2] = armor;
                }
                else if (dragons.ContainsKey(type))
                {
                    dragons[type][name] = new List<int?>
                    {
                        damage, health, armor
                    };
                }
                else
                {
                    dragons[type] = new SortedDictionary<string, List<int?>>
                    {
                        {name, new List<int?> {damage, health, armor }}
                    };
                }

            }

            foreach (var dragon in dragons)
            {
                double? avgDmg = dragon.Value.Values.Select(x => x[0]).Sum() / (double)dragon.Value.Values.Select(x => x[0]).Count();
                double? avgHelath = dragon.Value.Values.Select(x => x[1]).Sum() / (double)dragon.Value.Values.Select(x => x[0]).Count();
                double? avgArmor = dragon.Value.Values.Select(x => x[2]).Sum() / (double)dragon.Value.Values.Select(x => x[0]).Count();

                Console.WriteLine($"{dragon.Key}::({avgDmg:F2}/{avgHelath:F2}/{avgArmor:F2})");
                foreach (var stats in dragon.Value)
                {
                    Console.WriteLine($"-{stats.Key} -> damage: {stats.Value[0]}, health: {stats.Value[1]}, armor: {stats.Value[2]}");
                }
            }
        }
    }
}
