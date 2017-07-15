using System;
using System.Linq;

namespace _05.FilterStudentsByEmail
{
    public class FilterStudentsByEmail
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            while (input != "END")
            {
                var student = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string firstName = student[0];
                string lastName = student[1];
                string email = student[2];
                if (email.Contains("gmail.com"))
                {
                    Console.WriteLine($"{firstName} {lastName}");
                }

                input = Console.ReadLine();
            }
        }
    }
}