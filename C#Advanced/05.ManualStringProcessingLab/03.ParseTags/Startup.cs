using System;

namespace _03.ParseTags
{
    public class Startup
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            int indexOpen = input.IndexOf("<upcase>");
            while (indexOpen != -1)
            {
                int indexClose = input.IndexOf("</upcase>");
                if (indexClose == -1) break;

                string toBeUppered = input.Substring(indexOpen + 8, indexClose - indexOpen - 8).ToUpper();
                string toBeReplaced = input.Substring(indexOpen, indexClose - indexOpen + 9);

                input = input.Replace(toBeReplaced, toBeUppered);

                indexOpen = input.IndexOf("<upcase>");

            }
            Console.WriteLine(input);
        }
    }
}
