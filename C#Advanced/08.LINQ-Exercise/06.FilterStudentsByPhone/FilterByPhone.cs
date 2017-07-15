using System;
using System.Linq;

namespace _06.FilterStudentsByPhone
{
    public class FilterByPhone
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            while (input != "END")
            {
                var student = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string firstName = student[0];
                string lastName = student[1];
                string phone = student[2].Trim();
                if (phone.StartsWith("02") || phone.StartsWith("+3592"))
                {
                    Console.WriteLine($"{firstName} {lastName}");
                }

                input = Console.ReadLine();
            }
        }
    }
}
