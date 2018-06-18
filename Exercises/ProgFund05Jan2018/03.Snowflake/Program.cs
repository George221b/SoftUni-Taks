namespace _03.Snowflake
{
    using System;
    using System.Text.RegularExpressions;

    public class Program
    {
        public static void Main(string[] args)
        {
            const string surfacePattern = @"^[^A-Za-z0-9]+$";
            const string mantlePattern = @"^[0-9_]+$";
            const string corePattern = @"([^A-Za-z0-9]+)([0-9_]+)([A-Za-z]+)([0-9_]+)([^A-Za-z0-9]+)";

            var surfaceOne = Console.ReadLine();
            var mantleOne = Console.ReadLine();
            var core = Console.ReadLine();
            var mantleTwo = Console.ReadLine();
            var surfaceTwo = Console.ReadLine();

            if (!Regex.IsMatch(surfaceOne, surfacePattern) || !Regex.IsMatch(surfaceTwo, surfacePattern))
            {
                Console.WriteLine("Invalid");
                return;
            }
            if (!Regex.IsMatch(mantleOne, mantlePattern) || !Regex.IsMatch(mantleTwo, mantlePattern))
            {
                Console.WriteLine("Invalid");
                return;
            }

            if (!Regex.IsMatch(core, corePattern))
            {
                Console.WriteLine("Invalid");
                return;                
            }
            else
            {
                var match = Regex.Match(core, corePattern);
                Console.WriteLine($"Valid");
                Console.WriteLine(match.Groups[3].Value.Length);
            }
        }
    }
}
