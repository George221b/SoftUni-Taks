namespace RecursiveArraySum
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Console.WriteLine(FindSum(nums, 0));
        }

        private static int FindSum(int[] arr, int index)
        {
            if (index == arr.Length)
            {
                return 0;
            }
            var first = arr[index];
            var second = FindSum(arr, index + 1);

            return first + second;
        }
    }
}
