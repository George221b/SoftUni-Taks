using System;
using System.Linq;

namespace _07.ExcellentStudents
{
    public class ExcellentStudents
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            while (input != "END")
            {
                var student = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string firstName = student[0];
                string lastName = student[1];
                var grades = student.Skip(2).ToList();
                if (grades.Contains("6"))
                {
                    Console.WriteLine($"{firstName} {lastName}");
                }

                input = Console.ReadLine();
            }
        }
    }
}
