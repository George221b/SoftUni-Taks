using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.FixEmails
{
    public class Startup
    {
        static void Main()
        {
            Dictionary<string, string> nameAndEmail = new Dictionary<string, string>();
            string[] domains = { ".uk", ".us" };
            string name = Console.ReadLine();

            while (!name.Equals("stop"))
            {
                string email = Console.ReadLine();

                if (!nameAndEmail.ContainsKey(name))
                {
                    nameAndEmail.Add(name, email);
                }

                name = Console.ReadLine();
            }
            RemoveEmailsByDomain(nameAndEmail, domains[1]);
            RemoveEmailsByDomain(nameAndEmail, domains[0]);

            foreach (var item in nameAndEmail)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }

        private static void RemoveEmailsByDomain(Dictionary<string, string> nameAndEmail, string domain)
        {
            var filteredEmails = nameAndEmail.Where(x => x.Value.EndsWith(domain)).ToList();
            foreach (var entry in filteredEmails)
            {
                nameAndEmail.Remove(entry.Key);
            }
        }
    }
}
