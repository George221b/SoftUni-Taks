using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.StudentsJoinedToSpecialties
{
    public class StudentsJoinedToSpecialties
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var specialties = new List<StudentSpecialty>();

            while (input != "Students:")
            {

                var number = input.Split().Skip(2).Take(1).First();
                var name = string.Join(" ", input.Split().Take(2).ToList());

                specialties.Add(new StudentSpecialty
                {
                    Name = name,
                    FacultyNumber = number
                });

                input = Console.ReadLine();
            }

            input = Console.ReadLine();
            var students = new List<Student>();

            while (input != "END")
            {

                var number = input.Split().Take(1).FirstOrDefault();
                var name = string.Join(" ", input.Split().Skip(1).Take(input.Count() - 1));

                students.Add(new Student
                {
                    Name = name,
                    FacultyNumber = number
                });

                input = Console.ReadLine();
            }

            var result = students.Join(specialties,
                student => student.FacultyNumber,
                specialty => specialty.FacultyNumber,
                (student, specialty) => new
                {
                    student.Name,
                    student.FacultyNumber,
                    Specialty = specialty.Name
                })
                .OrderBy(st => st.Name);

            foreach (var student in result)
            {
                Console.WriteLine($"{student.Name} {student.FacultyNumber} {student.Specialty}");
            }
        }
    }
}
