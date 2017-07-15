using System;
using System.Linq;

namespace _09.StudentsEnrolledIn
{
    public class StudentsEnrolledIn
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            while (input != "END")
            {
                var student = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string studentNumber = student[0];
                var grades = student.Skip(1).Select(int.Parse).ToList();
                if (studentNumber.EndsWith("14") || studentNumber.EndsWith("15"))
                {
                    Console.WriteLine($"{string.Join(" ", grades)}");
                }

                input = Console.ReadLine();
            }
        }
    }
}
