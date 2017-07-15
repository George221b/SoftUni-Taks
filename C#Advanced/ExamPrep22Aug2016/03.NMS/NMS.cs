using System;
using System.Linq;
using System.Text;

namespace _03.NMS
{
    public class NMS
    {
        public static void Main()
        {
            var sb = new StringBuilder();
            var inputLine = Console.ReadLine();
            while (inputLine != "---NMS SEND---")
            {
                sb.Append(inputLine);

                inputLine = Console.ReadLine();
            }
            var delimiter = Console.ReadLine();

            var original = sb.ToString();
            var copy = sb.ToString().ToLower();
            var builder = new StringBuilder();
            builder.Append(copy[0]);
            for (int i = 1; i < copy.Length; i++)
            {
                var previous = builder.ToString().Last();
                var previousLetter = char.Parse(previous.ToString().ToLower());
                var currentLetter = copy[i];
                var currentOriginal = original[i];

                if (previousLetter <= currentLetter)
                {
                    if (currentLetter == currentOriginal)
                    {
                        builder.Append(currentLetter);
                    }
                    else
                    {
                        builder.Append(currentOriginal);
                    }
                }
                else
                {
                    if (currentLetter == currentOriginal)
                    {
                        builder.Append(delimiter + currentLetter);
                    }
                    else
                    {
                        builder.Append(delimiter + currentOriginal);
                    }
                }
            }
            var result = string.Empty;
            var startsWith = builder.ToString().First();
            var originalStartsWith = char.Parse(original.Substring(0, 1));
            if (startsWith != originalStartsWith)
            {
                result = originalStartsWith + builder.ToString().Substring(1);
            }
            else
            {
                result = builder.ToString();
            }
            Console.WriteLine(result);
        }
    }
}
