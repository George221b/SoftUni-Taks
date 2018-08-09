namespace BarIncome
{
    using System;
    using System.Text.RegularExpressions;

    public class BarIncome
    {
        public static string pattern = @"%([A-Z]{1}[a-z]+)%[^$%|\.]*<(\w+)>[^$%|\.]*\|([0-9]+)\|[^$%|\.0-9]*(\d+\.?\d*)\$";

        public static void Main()
        {
            var input = Console.ReadLine();
            var totalIncome = 0m;

            while (input != "end of shift")
            {
                foreach (Match m in Regex.Matches(input, pattern))
                {
                    var customer = m.Groups[1].Value;
                    var product = m.Groups[2].Value;
                    var count = int.Parse(m.Groups[3].Value);
                    var price = decimal.Parse(m.Groups[4].Value);

                    totalIncome += (count * price);

                    Console.WriteLine($"{customer}: {product} - {(count * price):F2}");
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Total income: {totalIncome:F2}");
        }
    }
}
