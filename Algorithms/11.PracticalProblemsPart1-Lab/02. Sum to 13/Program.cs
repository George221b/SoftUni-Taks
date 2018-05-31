namespace _02.Sum_to_13
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            if (nums.Sum() == 13) //+++
            {
                Console.WriteLine("Yes");
                return;
            }
            nums[0] *= -1;
            if (nums.Sum() == 13) //-++
            {
                Console.WriteLine("Yes");
                return;
            }
            nums[0] *= -1;
            nums[1] *= -1;
            if (nums.Sum() == 13) //+-+
            {
                Console.WriteLine("Yes");
                return;
            }
            nums[2] *= -1;
            if (nums.Sum() == 13) //+--
            {
                Console.WriteLine("Yes");
                return;
            }
            nums[1] *= -1;
            if (nums.Sum() == 13) //++-
            {
                Console.WriteLine("Yes");
                return;
            }
            nums[1] *= -1;
            nums[0] *= -1;
            if (nums.Sum() == 13) //---
            {
                Console.WriteLine("Yes");
                return;
            }
            nums[2] *= -1;
            if (nums.Sum() == 13) //--+
            {
                Console.WriteLine("Yes");
                return;
            }
            nums[2] *= -1;
            nums[1] *= -1;
            if (nums.Sum() == 13) //-+-
            {
                Console.WriteLine("Yes");
                return;
            }
            Console.WriteLine("No");
        }
    }
}
