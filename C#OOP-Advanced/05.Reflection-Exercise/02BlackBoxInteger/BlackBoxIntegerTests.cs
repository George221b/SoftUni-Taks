using System.Linq;
using System.Reflection;

namespace _02BlackBoxInteger
{
    using System;

    public class BlackBoxIntegerTests
    {
        public static void Main()
        {
            Type blackBoxClass = typeof(BlackBoxInt);
            BlackBoxInt blackBox = (BlackBoxInt)Activator.CreateInstance(blackBoxClass, true);

            var input = Console.ReadLine();

            while (input != "END")
            {
                var tokens = input.Split('_').ToArray();
                var methodName = tokens[0];
                var number = int.Parse(tokens[1]);

                blackBoxClass.GetMethod(methodName, BindingFlags.Instance | BindingFlags.NonPublic)
                    .Invoke(blackBox, new Object[] { number });

                Console.WriteLine(blackBoxClass.GetFields(BindingFlags.Instance | BindingFlags.NonPublic).First().GetValue(blackBox));

                input = Console.ReadLine();
            }
        }
    }
}
