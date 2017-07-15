using System;

namespace _03.FormattingNumbers
{
    public class Startup
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine().Trim().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            var a = int.Parse(input[0]);
            var b = double.Parse(input[1]);
            var c = double.Parse(input[2]);

            string hex = $"{a:X}".PadRight(10, ' ').Substring(0, 10);
            string binary = Convert.ToString(a, 2).PadLeft(10, '0').Substring(0, 10);
            string twoPrecision = string.Format("{0:0.00}", b).PadLeft(10, ' ').Substring(0, 10);
            string threePrecision = string.Format("{0:0.000}", c).PadRight(10, ' ').Substring(0, 10);

            Console.WriteLine($"|{hex, 10}|{binary, 10}|{twoPrecision, 10}|{threePrecision, 10}|");
            //Console.WriteLine("|{0, 10}|{1, 10}|{2, 10}|{3, 10}|", hex, binary, twoPrecision, threePrecision);
        }
    }
}
