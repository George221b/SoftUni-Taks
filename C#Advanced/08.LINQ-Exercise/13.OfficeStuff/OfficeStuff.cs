using System;
using System.Collections.Generic;
using System.Linq;

namespace _13.OfficeStuff
{
    public class OfficeStuff
    {
        public static void Main()
        {
            var companies = new SortedDictionary<string, Dictionary<string, int>>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine()
                    .Trim(new[] {'|', ' '})
                    .Split(new[] {" - "}, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                var company = input[0];
                var product = input[2];
                var quantity = int.Parse(input[1]);

                if (!companies.ContainsKey(company))
                {
                    companies[company] = new Dictionary<string, int>
                    {
                        {product, quantity}
                    };
                }
                else if (companies.ContainsKey(company) && !companies[company].ContainsKey(product))
                {
                    companies[company][product] = quantity;
                }
                else
                {
                    companies[company][product] += quantity;
                }
            }

            foreach (var corp in companies)
            {
                Console.WriteLine($"{corp.Key}: {string.Join(", ", corp.Value.Select(x => $"{x.Key}-{x.Value}"))}");
            }
        }
    }
}
