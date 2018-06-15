namespace _04.ForceBook
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var dict = new Dictionary<string, List<string>>();

            var input = "";

            while ((input = Console.ReadLine()) != "Lumpawaroo")
            {
                if (input.Contains(" | "))
                {
                    var inputTokens = input.Split(" | ");
                    var side = inputTokens[0];
                    var user = inputTokens[1];

                    AddUserToDict(dict, side, user);
                }
                else
                {
                    var inputTokens = input.Split(" -> ");
                    var side = inputTokens[1];
                    var user = inputTokens[0];
                    var isFound = false;

                    foreach (var kvp in dict)
                    {
                        if (kvp.Value.Contains(user) && side != kvp.Key)
                        {
                            kvp.Value.Remove(user);
                        }
                    }

                    AddUserToDict(dict, side, user);
                    Console.WriteLine($"{user} joins the {side} side!");
                }
            }

            foreach (var kvp in dict
                .OrderByDescending(kvp => kvp.Value.Count)
                .ThenBy(kvp => kvp.Key))
            {
                var users = kvp.Value.OrderBy(u => u);

                if (users.Any())
                {
                    Console.WriteLine($"Side: {kvp.Key}, Members: {kvp.Value.Count}");

                    users.Select(u => $"! {u}")
                        .ToList()
                        .ForEach(u => Console.WriteLine(u));
                }
            }
        }

        private static void AddUserToDict(Dictionary<string, List<string>> dict, string side, string user)
        {
            if (!dict.ContainsKey(side))
            {
                dict.Add(side, new List<string>());
            }
            if (!dict[side].Contains(user))
            {
                dict[side].Add(user);
            }
        }
    }
}