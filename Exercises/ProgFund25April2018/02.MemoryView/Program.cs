namespace _02.MemoryView
{
    using System;
    using System.Linq;
    using System.Text;

    public class Program
    {
        public static void Main()
        {
            var line = Console.ReadLine();
            var sb = new StringBuilder();

            while (line != "Visual Studio crash")
            {
                sb.AppendLine(line);

                line = Console.ReadLine();
            }

            var input = sb.ToString().Split(new char[] { '\n', '\r', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            for (int i = 0; i < input.Count; i++)
            {
                if (i + 6 < input.Count)
                {
                    if (input[i] == "32656" &&
                        input[i + 1] == "19759" &&
                        input[i + 2] == "32763" &&
                        input[i + 3] == "0" &&
                        input[i + 5] == "0")
                    {
                        int num = int.Parse(input[i + 4]);

                        var nameChars = input.GetRange(i + 6, num).Select(int.Parse).Select(n => Convert.ToChar(n));

                        Console.WriteLine(string.Join("", nameChars));
                    }
                }
            }
        }
    }
}
