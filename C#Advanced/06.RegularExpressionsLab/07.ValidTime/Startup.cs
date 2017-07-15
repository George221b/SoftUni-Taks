using System;
using System.Text.RegularExpressions;

namespace _07.ValidTime
{
    public class Startup
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            Regex regex = new Regex("(^(0[0-9]){1}:(([0-5]{1})([0-9]{1})):(([0-5]{1})([0-9]{1})) (A|P)M$)|(^((11)|(12)){1}:(([0-5]{1})([0-9]{1})):(([0-5]{1})([0-9]{1})) (A|P)M$)");

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
