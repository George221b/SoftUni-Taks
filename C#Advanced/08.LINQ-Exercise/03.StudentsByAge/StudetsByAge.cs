using System;
using System.Linq;

namespace _03.StudentsByAge
{
    public class StudetsByAge
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            while (input != "END")
            {
                var student = input.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string firstName = student[0];
                string lastName = student[1];
                int age = int.Parse(student[2]);
                if (age >= 18 && age <= 24)
                {
                    Console.WriteLine($"{firstName} {lastName} {age}");
                }

                input = Console.ReadLine();
            }
        }
    }
}
