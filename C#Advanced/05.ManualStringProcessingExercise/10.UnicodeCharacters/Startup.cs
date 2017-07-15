using System;
using System.Collections.Generic;
using System.Text;

namespace _10.UnicodeCharacters
{
    public class Startup
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            Queue<char> queue = new Queue<char>(input);
            StringBuilder sb = new StringBuilder();
            while (queue.Count != 0)
            {
                char ch = queue.Dequeue();
                ConvertToUnicode(ch, sb);
            }

            Console.WriteLine(sb);
        }

        private static void ConvertToUnicode(char ch, StringBuilder sb)
        {
            sb.Append("\\u" + (((int)ch).ToString("X4").ToLower()));
        }
    }
}
