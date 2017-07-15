using System;
using System.Linq;

namespace _08.WeakStudents
{
    public class WeakStudents
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            while (input != "END")
            {
                var student = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string firstName = student[0];
                string lastName = student[1];
                var grades = student.Skip(2).Select(int.Parse).ToList();
                if (grades.Count(gr => gr <= 3) >= 2)
                {
                    Console.WriteLine($"{firstName} {lastName}");
                }

                input = Console.ReadLine();
            }
        }
    }
}
