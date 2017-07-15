using System;
using System.Linq;

namespace _01.MatrixOfPalindroms
{
    public class Startup
    {
        public static void Main()
        {
            int[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                 .Select(i => int.Parse(i)).ToArray();

            int r = input[0];
            int c = input[1];

            string[][] jagged = new string[r][];

            char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

            for (int row = 0; row < r; row++)
            {
                jagged[row] = new string[c];
                for (int col = 0; col < c; col++)
                {
                    jagged[row][col] = $"{alphabet[row]}{alphabet[row + col]}{alphabet[row]}";
                }
            }

            foreach (var array in jagged)
            {
                foreach (var palindrom in array)
                {
                    Console.Write($"{palindrom} ");
                }
                Console.WriteLine();
            }
        }
    }
}
