namespace _02.KaminoFactory2
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    public class Program
    {
        public static void Main()
        {
            var n = Console.ReadLine();
            var input = Console.ReadLine();

            var allSequences = new List<Sequence>();

            string pattern = @"(1+)";
            var counter = 0;

            while (input != "Clone them!")
            {
                counter++;

                var currentSequences = input.Split(new char[] { '!' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                var currentSum = currentSequences.Where(el => el == 1).Sum();

                var matches =
                    Regex.Matches(string.Join("", currentSequences), pattern)
                        .Select(m => new Sequence()
                        {
                            SequenceArr = currentSequences,
                            Length = m.Length,
                            Index = m.Index,
                            Sum = currentSum,
                            SequenceId = counter
                        })
                        .ToArray();

                allSequences.AddRange(matches);

                input = Console.ReadLine();
            }

            var result = allSequences
                .OrderByDescending(seq => seq.Length)
                .ThenBy(seq => seq.Index)
                .ThenByDescending(seq => seq.Sum)
                .FirstOrDefault();

            if (result != null)
            {
                Console.WriteLine("Best DNA sample {0} with sum: {1}.", result.SequenceId, result.Sum);

                Console.WriteLine(String.Join(" ", result.SequenceArr));
            }
            else
            {
                Console.WriteLine("Best DNA sample 0 with sum: 0.");
            }
        }
    }

    public class Sequence
    {
        public int[] SequenceArr { get; set; }

        public int SequenceId { get; set; }

        public int Length { get; set; }

        public int Index { get; set; }

        public int Sum { get; set; }
    }
}
