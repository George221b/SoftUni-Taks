namespace _01.ReverseArray
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(' ');
            PrintReverse(arr, 0);
        }

        private static void PrintReverse(string[] arr, int index)
        {
            if (index == arr.Length)
            {
                return;
            }
            PrintReverse(arr, index + 1);
            Console.Write(arr[index] + " ");
        }
    }
}
