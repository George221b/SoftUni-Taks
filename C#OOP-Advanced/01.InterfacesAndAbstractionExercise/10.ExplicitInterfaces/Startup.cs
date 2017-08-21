using System;
using _10.ExplicitInterfaces.Interfaces;
using _10.ExplicitInterfaces.Models;

namespace _10.ExplicitInterfaces
{
    public class Startup
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            while (input != "End")
            {
                var tokens = input.Split();
                var citizen = new Citizen(tokens[0], tokens[1], int.Parse(tokens[2]));

                Console.WriteLine(((IPerson)citizen).GetName());

                var resident = (IResident)citizen;
                Console.WriteLine(resident.GetName());

                input = Console.ReadLine();
            }
        }
    }
}
