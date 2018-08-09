namespace _04.ExamResults
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ExamResults
    {
        public static Dictionary<string, int> usersAndBestResult;
        public static Dictionary<string, int> languageSubmissionsCount;

        public static void Main()
        {
            var input = Console.ReadLine();

            usersAndBestResult = new Dictionary<string, int>();
            languageSubmissionsCount = new Dictionary<string, int>();

            while (input != "exam finished")
            {
                var tokens = input.Split('-').ToList();

                if (tokens.Count == 2) // Banned User
                {
                    if (usersAndBestResult.ContainsKey(tokens[0]))
                    {
                        usersAndBestResult.Remove(tokens[0]);
                    }
                }
                else
                {
                    var user = tokens[0];
                    var language = tokens[1];
                    var points = int.Parse(tokens[2]);

                    if (!usersAndBestResult.ContainsKey(user))
                    {
                        usersAndBestResult.Add(user, points);
                    }

                    if (points > usersAndBestResult[user])
                    {
                        usersAndBestResult[user] = points;
                    }

                    if (!languageSubmissionsCount.ContainsKey(language))
                    {
                        languageSubmissionsCount.Add(language, 0);
                    }

                    languageSubmissionsCount[language]++;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Results:");
            foreach (var kvp in usersAndBestResult
                .OrderByDescending(kvp => kvp.Value)
                .ThenBy(kvp => kvp.Key))
            {
                Console.WriteLine($"{kvp.Key} | {kvp.Value}");
            }

            Console.WriteLine("Submissions:");
            foreach (var kvp in languageSubmissionsCount
                .OrderByDescending(kvp => kvp.Value)
                .ThenBy(kvp => kvp.Key))
            {
                Console.WriteLine($"{kvp.Key} - {kvp.Value}");
            }
        }
    }
}
