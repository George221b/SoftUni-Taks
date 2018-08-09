namespace _01.Reception
{
    using System;

    public class Reception
    {
        public static void Main()
        {
            var fEmployee = int.Parse(Console.ReadLine());
            var sEmployee = int.Parse(Console.ReadLine());
            var tEmployee = int.Parse(Console.ReadLine());
            var studentsCount = int.Parse(Console.ReadLine());

            var canAnswerStudentsPerHour = fEmployee + sEmployee + tEmployee;

            var neededHours = 0;
            var count = 1;

            while (true)
            {
                if (studentsCount <= 0)
                {
                    break;
                }

                if (count % 4 == 0)
                {
                    neededHours++;
                    count = 1;
                    continue;
                }

                studentsCount -= canAnswerStudentsPerHour;
                neededHours++;
                count++;
            }

            Console.WriteLine($"Time needed: {neededHours}h.");
        }
    }
}
