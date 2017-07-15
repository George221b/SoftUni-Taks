using System;

namespace _12.LittleJohn
{
    public class LittleJohn
    {
        public const string SmallArrow = ">----->";

        public const string MediumArrow = ">>----->";

        public const string LargeArrow = ">>>----->>";

        public static void Main()
        {
            string arrowsDec = ReadInputAndCountArrows();
            string arrowsBin = Convert.ToString(int.Parse(arrowsDec), 2);

            var reverse = arrowsBin.ToCharArray();
            Array.Reverse(reverse);

            string arrowsBinReverse = string.Join("", reverse);

            string arrowBinNewValue = arrowsBin + arrowsBinReverse;

            Console.WriteLine(Convert.ToInt32(arrowBinNewValue, 2));
        }

        private static string ReadInputAndCountArrows()
        {
            var arrowsCount = new int[3]; // 0 small, 1 medium, 2 large

            for (int i = 0; i < 4; i++)
            {
                var input = Console.ReadLine();

                while (input.Contains(LargeArrow))
                {
                    input = ReplaceFirst(input, LargeArrow, "");
                    arrowsCount[2]++;
                }
                while (input.Contains(MediumArrow))
                {
                    input = input.Replace(MediumArrow, "");
                    arrowsCount[1]++;
                }
                while (input.Contains(SmallArrow))
                {
                    input = input.Replace(SmallArrow, "");
                    arrowsCount[0]++;
                }
            }

            return string.Join("", arrowsCount).TrimStart('0');
        }

        public static string ReplaceFirst(string input, string oldValue, string newValue)
        {
            int pos = input.IndexOf(oldValue);
            if (pos < 0)
            {
                return input;
            }
            return input.Substring(0, pos) + newValue + input.Substring(pos + oldValue.Length);
        }
    }
}