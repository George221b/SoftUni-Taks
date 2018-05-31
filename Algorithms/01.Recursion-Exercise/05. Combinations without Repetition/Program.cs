namespace _05.CombinationsWithoutRepetition
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int numElements = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] nums = new int[numElements];
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = i + 1;
            }
            int[] result = new int[k];
            PrintCombinations(nums, result, 0, 0);
        }

        private static void PrintCombinations(int[] nums, int[] result, int resultIndex, int beginIndex)
        {
            if (resultIndex == result.Length)
            {
                Console.WriteLine(String.Join(" ", result));
                return;
            }
            for (int i = beginIndex; i < nums.Length; i++)
            {
                result[resultIndex] = nums[i];
                PrintCombinations(nums, result, resultIndex + 1, i + 1);
            }
        }
    }
}
