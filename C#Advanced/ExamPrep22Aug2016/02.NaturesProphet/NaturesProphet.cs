using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.NaturesProphet
{
    public class NaturesProphet
    {
        public static void Main(string[] args)
        {
            var size = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var garden = new int[size[0]][];

            for (int i = 0; i < garden.Length; i++)
            {
                garden[i] = new int[size[1]];
                for (int j = 0; j < garden[i].Length; j++)
                {
                    garden[i][j] = 0;
                }
            }

            var input = Console.ReadLine();
            var indexes = new List<int[]>();
            while (input != "Bloom Bloom Plow")
            {
                var currentInput = input.Split().Select(int.Parse).ToArray();
                indexes.Add(currentInput);
                input = Console.ReadLine();
            }

            foreach (var indices in indexes)
            {
                var row = indices[0];
                var col = indices[1];
                for (int i = 0; i < garden.Length; i++)
                {
                    for (int j = 0; j < garden[i].Length; j++)
                    {
                        if (i == row && j == col)
                        {
                            BloomFlowers(garden, row, col);
                        }
                    }
                }
            }

            foreach (var el in garden)
            {
                Console.WriteLine(string.Join(" ", el));
            }
        }

        private static void BloomFlowers(int[][] garden, int row, int col)
        {
            for (int i = 0; i < garden[row].Length; i++)
            {
                garden[row][i]++;
            }

            for (int i = 0; i < garden.Length; i++)
            {
                garden[i][col]++;
            }

            garden[row][col]--;
        }
    }
}
