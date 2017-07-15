using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.SortStudents
{
    public class SortStudents
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var students = new List<string[]>();
            while (input != "END")
            {
                var student = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string firstName = student[0];
                string lastName = student[1];

                students.Add(new[] { firstName, lastName });

                input = Console.ReadLine();
            }

            students.OrderBy(st => st[1])
                .ThenByDescending(st => st[0])
                .ToList()
                .ForEach(arr => Console.WriteLine(string.Join(" ", arr)));
        }
    }
}
