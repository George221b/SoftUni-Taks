namespace _02.Parentheses
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        private static char[] result;
        private static List<string> printing;

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            printing = new List<string>();
            result = new char[n * 2];
            result[0] = '(';
            GenerateParentheses(1, n - 1, n);
            Console.WriteLine(String.Join(Environment.NewLine, printing));
        }

        private static void GenerateParentheses(int index, int openRemaining, int closeRemaining)
        {
            if (index == result.Length)
            {
                printing.Add(new string(result));
                return;
            }
            if (openRemaining > 0)
            {
                result[index] = '(';
                GenerateParentheses(index + 1, openRemaining - 1, closeRemaining);
            }
            if (closeRemaining > openRemaining)
            {
                result[index] = ')';
                GenerateParentheses(index + 1, openRemaining, closeRemaining - 1);
            }
        }
    }
}
