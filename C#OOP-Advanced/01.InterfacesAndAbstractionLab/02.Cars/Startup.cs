using System;
using _02.Cars.Interfaces;
using _02.Cars.Models;

namespace _02.Cars
{
    public class Startup
    {
        public static void Main()
        {
            ICar seat = new Seat("Leon", "Grey");
            ICar tesla = new Tesla("Model 3", "Red", 2);

            Console.WriteLine(seat.ToString());
            Console.WriteLine(tesla.ToString());
        }
    }
}
