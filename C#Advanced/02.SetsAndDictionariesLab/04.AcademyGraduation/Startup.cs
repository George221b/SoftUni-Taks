using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.AcademyGraduation
{
    public class Startup
    {
        public static void Main()
        {
            int numberOfStudents = int.Parse(Console.ReadLine());
            var dictionary = new SortedDictionary<string, double[]>();

            for (int i = 0; i < numberOfStudents; i++)
            {
                string name = Console.ReadLine();
                double[] grades = Console.ReadLine()
                                         .Trim()
                                         .Split()
                                         .Select(double.Parse)
                                         .ToArray();

                if (!dictionary.ContainsKey(name))
                {
                    dictionary.Add(name, grades);
                }
            }

            foreach (var student in dictionary)
            {
                double averageGrade = student.Value.Sum() / student.Value.Count();
                Console.WriteLine($"{student.Key} is graduated with {averageGrade}");
            }
        }
    }
}
