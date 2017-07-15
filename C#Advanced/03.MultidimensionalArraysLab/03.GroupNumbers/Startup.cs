using System;
using System.Linq;

namespace _03.GroupNumbers
{
    public class Startup
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse);

            int[] sizes = new int[3];

            foreach (var number in numbers)
            {
                int remainder = Math.Abs(number % 3);
                sizes[remainder]++;
            }
            int[][] jagged =
            {
                new int[sizes[0]],
                new int[sizes[1]],
                new int[sizes[2]]
            };

            int[] offsets = new int[3];

            foreach (var number in numbers)
            {
                int reminder = Math.Abs(number % 3);
                int index = offsets[reminder];
                jagged[reminder][index] = number;
                offsets[reminder]++;
            }

            foreach (var array in jagged)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write($"{array[i]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
