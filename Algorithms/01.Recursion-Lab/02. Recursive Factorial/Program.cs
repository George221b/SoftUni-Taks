namespace _02.RecursiveFactorial
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(FindFactorial(num));
        }

        private static long FindFactorial(int num)
        {
            if (num == 0)
            {
                return 1;
            }
            var first = num;
            var second = FindFactorial(first - 1);

            return first * second;
        }
    }
}
