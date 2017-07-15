using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.StudentsByGroup
{
    public class StudentsByGroup
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            List<string[]> students = new List<string[]>();
            while (input != "END")
            {
                students.Add(input.Split().ToArray());

                input = Console.ReadLine();
            }
            if (students.Count != 0)
            {
                students.Where(arr => arr.Contains("2"))
                    .OrderBy(arr => arr[0])
                    .ThenBy(arr => arr[1])
                    .ToList()
                    .ForEach(arr => Console.WriteLine($"{arr[0]} {arr[1]}"));
            }
        }
    }
}
