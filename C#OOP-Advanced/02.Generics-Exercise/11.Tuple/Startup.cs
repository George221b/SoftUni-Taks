using System;
using System.Linq;

namespace _11.Tuple
{
    public class Startup
    {
        public static void Main()
        {
            var firstLine = Console.ReadLine().Split().ToArray();
            var name = $"{firstLine[0]} {firstLine[1]}";
            var city = firstLine[2];
            var tuple = new Tuple<string, string>(name, city);
            Console.WriteLine(tuple);


            var drinker = Console.ReadLine().Split().ToArray();
            var tuple2 = new Tuple<string, double>(drinker[0], double.Parse(drinker[1]));
            Console.WriteLine(tuple2);

            var numbers = Console.ReadLine().Split().ToArray();
            var tuple3 = new Tuple<int, double>(int.Parse(numbers[0]), double.Parse(numbers[1]));
            Console.WriteLine(tuple3);
        }
    }
}
