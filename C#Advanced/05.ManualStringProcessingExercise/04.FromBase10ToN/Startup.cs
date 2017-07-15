using System;
using System.Numerics;

namespace _04.FromBase10ToN
{
    public class Startup
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split();
            BigInteger num = BigInteger.Parse(input[1]);
            int toBase = int.Parse(input[0]);
            string result = "";
            while (num != 0)
            {
                BigInteger x = num % toBase;
                result = x.ToString() + result;
                num = num / toBase;

            }
            Console.WriteLine(result);
        }
    }
}
