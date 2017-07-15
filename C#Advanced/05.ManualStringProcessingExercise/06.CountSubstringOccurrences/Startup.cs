using System;

namespace _06.CountSubstringOccurrences
{
    public class Startup
    {
        public static void Main()
        {
            var text = Console.ReadLine().ToLower();
            var search = Console.ReadLine().ToLower();

            int count = 0;
            int lastOccurrence = 0;
            int index = text.IndexOf(search, lastOccurrence);

            while (index != -1)
            {
                count++;
                lastOccurrence = index;
                index = text.IndexOf(search, lastOccurrence + 1);
            }
            Console.WriteLine(count);
        }
    }
}
