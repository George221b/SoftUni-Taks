using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.LogsAggregator
{
    public class LogsAggregator
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            // SortedDict {string USERNAME, SortedDict { string IP, int DURATION } }
            var log =
                new SortedDictionary<string, SortedDictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                string ip = input[0];
                string username = input[1];
                int duration = int.Parse(input[2]);

                if (!log.ContainsKey(username))
                    log.Add(username, new SortedDictionary<string, int>() { { ip, duration } });

                else if (!log[username].ContainsKey(ip))
                    log[username].Add(ip, duration);

                else
                    log[username][ip] += duration;
            }

            foreach (var kvp in log)
            {
                Console.WriteLine("{0}: {2} [{1}]",
                    kvp.Key,
                    string.Join(", ", kvp.Value.Select(x => x.Key)),
                    kvp.Value.Values.Sum()
                );
            }
        }
    }
}