using System;
using System.Text.RegularExpressions;

namespace _06.ValidUsernames
{
    public class Startup
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            if (input.Equals("END"))
            {
                Console.WriteLine("(no output)");
                return;
            }
            Regex regex = new Regex(@"^[\w-]{3,16}$");
            while (!input.Equals("END"))
            {
                Match match = regex.Match(input);

                if (match.Success)
                {
                    Console.WriteLine("valid");
                }
                else
                {
                    Console.WriteLine("invalid");
                }

                input = Console.ReadLine();
            }
        }
    }
}
