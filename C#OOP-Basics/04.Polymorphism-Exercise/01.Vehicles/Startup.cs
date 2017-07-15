using System;
using System.Linq;
using _01.Vehicles.Models;

namespace _01.Vehicles
{
    public class Startup
    {
        public static void Main()
        {
            var carArgs = Console.ReadLine().Split().Skip(1).Select(double.Parse).ToArray();
            var truckArgs = Console.ReadLine().Split().Skip(1).Select(double.Parse).ToArray();

            Vehicle car = new Car(carArgs[0], carArgs[1]);
            Vehicle truck = new Truck(truckArgs[0], truckArgs[1]);

            int numberOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCommands; i++)
            {
                var commandArgs = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                switch (commandArgs[1].ToLower())
                {
                    case "car":
                        DoCommand(car, commandArgs);
                        break;
                    case "truck":
                        DoCommand(truck, commandArgs);
                        break;

                }
            }

            Console.WriteLine($"Car: {car.FuelQuantity:F2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:F2}");
        }

        private static void DoCommand(Vehicle vehicle, string[] commandArgs)
        {
            switch (commandArgs[0].ToLower())
            {
                case "drive":
                    Console.WriteLine(vehicle.Drive(double.Parse(commandArgs[2])));
                    break;
                case "refuel":
                    vehicle.Refuel(double.Parse(commandArgs[2]));
                    break;
            }
        }
    }
}
