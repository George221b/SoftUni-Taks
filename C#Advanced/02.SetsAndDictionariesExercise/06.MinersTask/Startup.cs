using System;
using System.Collections.Generic;

namespace _06.MinersTask
{
    public class Startup
    {
        public static void Main()
        {
            Dictionary<string, long> minerInfo = new Dictionary<string, long>();
            string mineralType = Console.ReadLine();

            while (!mineralType.Equals("stop"))
            {
                long quantity = long.Parse(Console.ReadLine());
                if (!minerInfo.ContainsKey(mineralType))
                {
                    minerInfo.Add(mineralType, 0);
                }
                minerInfo[mineralType] += quantity;

                mineralType = Console.ReadLine();
            }
            foreach (var item in minerInfo)
            {
                Console.WriteLine("{0} -> {1}", item.Key, item.Value);
            }
        }
    }
}
