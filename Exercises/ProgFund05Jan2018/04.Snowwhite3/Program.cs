namespace _04.Snowwhite3
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    { // 60/ 100
        public static void Main(string[] args)
        {
            var dict = new Dictionary<string, Dictionary<string, int>>();

            var input = Console.ReadLine();

            while (input != "Once upon a time")
            {
                var inputTokens = input.Split(new char[] { ' ', '<', '>', ':' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var color = inputTokens[1];
                var name = inputTokens[0];
                var physics = int.Parse(inputTokens[2]);

                if (!dict.ContainsKey(color))
                {
                    dict.Add(color, new Dictionary<string, int>());
                }
                if (!dict[color].ContainsKey(name))
                {
                    dict[color].Add(name, 0);
                }

                if (physics > dict[color][name])
                {
                    dict[color][name] = physics;
                }

                input = Console.ReadLine();
            }

            foreach (var kvp in dict
                .OrderByDescending(x => x.Value.Max(y => y.Value))
                .ThenByDescending(x => x.Value.Values.Count))
            {
                foreach (var kvp2 in kvp.Value)
                {
                    Console.WriteLine($"({kvp.Key}) {kvp2.Key} <-> {kvp2.Value}");
                }
            }
        }
    }
}
