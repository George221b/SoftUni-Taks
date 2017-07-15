using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _07.ValidUsernames
{
    public class ValidUsernames
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(new[] { ' ', '\\', '/', ')', '(' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            Regex regex = new Regex(@"^[A-Za-z]\w{2,25}$");
            List<string> validUsers = new List<string>();
            foreach (var user in input)
            {
                if (regex.Match(user).Success)
                {
                    validUsers.Add(user);
                }
            }

            int biggestSum = 0;
            int sum = 0;
            int firstIndex = 0;
            int secondIndex = 0;
            for (int i = 0; i < validUsers.Count - 1; i++)
            {
                sum = validUsers[i].Length + validUsers[i + 1].Length;
                if (sum > biggestSum)
                {
                    biggestSum = sum;
                    firstIndex = i;
                    secondIndex = i + 1;
                }
            }

            Console.WriteLine(validUsers[firstIndex]);
            Console.WriteLine(validUsers[secondIndex]);
        }
    }
}
