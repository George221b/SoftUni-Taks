using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.StudentsResults
{
    public class Startup
    {
        public static void Main()
        {
            int numberOfStudents = int.Parse(Console.ReadLine());
            var students = new Dictionary<string, List<double>>();
            for (int i = 0; i < numberOfStudents; i++)
            {
                var input = Console.ReadLine().Trim().Split(new char[] { ' ', '-', ',' }, StringSplitOptions.RemoveEmptyEntries);

                students[input[0]] = new List<double> { double.Parse(input[1]), double.Parse(input[2]), double.Parse(input[3]) };

            }

            Console.WriteLine(string.Format(
                "{0,-10}|{1,7}|{2,7}|{3,7}|{4,7}|"
                , "Name", "CAdv", "COOP", "AdvOOP", "Average"));

            foreach (var student in students)
            {
                Console.WriteLine(string.Format(
                "{0,-10}|{1,7:F2}|{2,7:F2}|{3,7:F2}|{4,7:F4}|"
                , student.Key, student.Value[0], student.Value[1], student.Value[2], student.Value.Sum() / 3));
            }
        }

    }
}
