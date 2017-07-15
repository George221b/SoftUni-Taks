using System;

namespace _15.MelrahShake
{
    public class MelrahShake
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var pattern = Console.ReadLine();

            while (true)
            {
                int firstIndex = input.IndexOf(pattern);
                int lastIndex = input.LastIndexOf(pattern);

                if (firstIndex == -1 || firstIndex == lastIndex)
                {
                    break;
                }

                input = input.Remove(lastIndex, pattern.Length);
                input = input.Remove(firstIndex, pattern.Length);
                Console.WriteLine("Shaked it.");

                pattern = pattern.Remove(pattern.Length / 2, 1);
                if (pattern.Length < 1)
                {
                    break;
                }
            }

            Console.WriteLine("No shake.");
            Console.WriteLine(input);
        }
    }
}
