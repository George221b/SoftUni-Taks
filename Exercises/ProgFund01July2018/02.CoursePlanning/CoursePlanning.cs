namespace _02.CoursePlanning
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CoursePlanning
    {
        public static void Main()
        {
            var courses = Console.ReadLine()
                .Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(c => new Course(c))
                .ToList();

            var command = Console.ReadLine();

            while (command.ToLower() != "course start")
            {
                var cmdTokens = command.Split(':').ToList();

                switch (cmdTokens[0])
                {
                    case "Add":
                        if (!courses.Any(c => c.Name == cmdTokens[1]))
                        {
                            courses.Add(new Course(cmdTokens[1]));
                        }
                        break;

                    case "Insert":
                        InsertCourse(courses, cmdTokens);
                        break;

                    case "Remove":
                        RemoveCourse(courses, cmdTokens);
                        break;

                    case "Swap":
                        var firstSwap = cmdTokens[1];
                        var secondSwap = cmdTokens[2];

                        if (courses.Exists(c => c.Name == firstSwap)
                            && courses.Exists(c => c.Name == secondSwap))
                        {
                            var firstIndex = courses.IndexOf(courses.First(c => c.Name == firstSwap));
                            var secondIndex = courses.IndexOf(courses.First(c => c.Name == secondSwap));

                            Swap<Course>(courses, firstIndex, secondIndex);
                        }
                        break;

                    case "Exercise":
                        AddExerciseToCouseOrCreateNewCourse(courses, cmdTokens);
                        break;

                    default: return;
                }

                command = Console.ReadLine();
            }

            var index = 1;
            for (int i = 0; i < courses.Count; i++)
            {
                Console.WriteLine($"{index}.{courses[i].Name}");
                index++;

                if (!string.IsNullOrEmpty(courses[i].Exercise))
                {
                    Console.WriteLine($"{index}.{courses[i].Exercise}");
                    index++;
                }
            }

        }

        private static void AddExerciseToCouseOrCreateNewCourse(List<Course> courses, List<string> cmdTokens)
        {
            var lesson = cmdTokens[1];

            if (courses.Any(c => c.Name == lesson))
            {
                var courseWithExercise = courses.First(c => c.Name == lesson);

                if (string.IsNullOrEmpty(courseWithExercise.Exercise))
                {
                    courseWithExercise.AddExercise();
                }
            }
            else
            {
                var courseWithExerciseToAdd = new Course(lesson);
                courseWithExerciseToAdd.AddExercise();

                courses.Add(courseWithExerciseToAdd);
            }
        }

        private static void RemoveCourse(List<Course> courses, List<string> cmdTokens)
        {
            var courseToRemove = cmdTokens[1];
            if (courses.Exists(c => c.Name == courseToRemove))
            {
                courses.Remove(courses.First(c => c.Name == courseToRemove));
            }
        }

        private static void InsertCourse(List<Course> courses, List<string> cmdTokens)
        {
            var courseName = cmdTokens[1];
            var indexToInsert = int.Parse(cmdTokens[2]);

            if (!courses.Any(c => c.Name == courseName))
            {
                if (indexToInsert >= 0 && indexToInsert < courses.Count)
                {
                    courses.Insert(indexToInsert, new Course(courseName));
                }
            }
        }

        public static void Swap<T>(IList<T> list, int indexA, int indexB)
        {
            T tmp = list[indexA];
            list[indexA] = list[indexB];
            list[indexB] = tmp;
        }
    }
}
