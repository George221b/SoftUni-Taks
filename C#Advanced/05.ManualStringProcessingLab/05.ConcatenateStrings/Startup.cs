using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ConcatenateStrings
{
    public class Startup
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                var word = Console.ReadLine();

                builder.Append(word + ' ');
            }
            Console.WriteLine(builder);
        }
    }
}
