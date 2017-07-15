using System;
using System.Linq;

namespace _03.CustomMinFunction
{
    public class CustomMinFunction
    {
        public static void Main()
        {
            Func<int[], int> small = x => x.Min();

            Console.WriteLine(small(
                Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray()));
            
        }
    }
}
