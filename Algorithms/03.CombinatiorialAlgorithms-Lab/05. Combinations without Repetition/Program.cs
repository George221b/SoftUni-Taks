namespace _05.CombinationsWithoutRepetition
{
    using System;

    class Program
    {
        static string[] elements = Console.ReadLine().Split(' ');
        static int countTaken = int.Parse(Console.ReadLine());
        static string[] results = new string[countTaken];

        static void Main(string[] args)
        {
            GetCombinations(0, 0);
        }

        private static void GetCombinations(int index, int border)
        {
            if (index == countTaken)
            {
                Console.WriteLine(String.Join(" ", results));
                return;
            }
            for (int i = border; i < elements.Length; i++)
            {
                results[index] = elements[i];
                GetCombinations(index + 1, i + 1);
            }
        }
    }
}
