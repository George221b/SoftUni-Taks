using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _10.GroupByGroup
{
    public class GroupByGroup
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            List<Student> students = new List<Student>();

            while (input != "END")
            {
                var student = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                students.Add(new Student
                {
                    Name = string.Join(" ", student.Take(student.Count - 1)),
                    Group = int.Parse(student.Skip(student.Count - 1).Take(1).First())
                });

                input = Console.ReadLine();
            }

            var result = students
                .OrderBy(st => st.Group)
                .GroupBy(st => st.Group);

            var sb = new StringBuilder();
            foreach (var group in result)
            {
                sb.Append($"{group.Key} - ");
                foreach (var groupedItem in group)
                {
                    sb.Append($"{groupedItem.Name}, ");
                }
                Console.WriteLine(sb.ToString().TrimEnd(new [] {' ', ','}));
                sb.Clear();
            }
        }
    }
}
