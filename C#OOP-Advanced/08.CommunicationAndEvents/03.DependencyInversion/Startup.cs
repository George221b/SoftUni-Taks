using System;
using System.Collections.Generic;
using _03.DependencyInversion.Interfaces;
using _03.DependencyInversion.Strategies;

namespace _03.DependencyInversion
{
    public class Startup
    {
        public static void Main()
        {
            Dictionary<char, IStrategy> strategies = new Dictionary<char, IStrategy>()
            {
                {'+', new AdditionStrategy()},
                {'-', new SubtractionStrategy()},
                {'*', new MultiplyStrategy()},
                {'/', new DivideStrategy()},
            };

            PrimitiveCalculator calc = new PrimitiveCalculator(strategies['+'], strategies);
            string[] input = Console.ReadLine().Split();
            while (input[0] != "End")
            {
                if (input[0] == "mode")
                {
                    calc.ChangeStrategy(char.Parse(input[1]));
                }
                else
                {
                    Console.WriteLine(calc.performCalculation(int.Parse(input[0]), int.Parse(input[1])));
                }

                input = Console.ReadLine().Split();
            }
        }
    }
}