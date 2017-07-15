using System;

namespace _01.ReverseString
{
    public class Startup
    {
        public static void Main()
        {
            var input = Console.ReadLine().ToCharArray();
            Array.Reverse(input);
            string result = new string(input);
            

            Console.WriteLine(result);
        }
    }
}
