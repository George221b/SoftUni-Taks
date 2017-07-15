using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.SpeedRacing
{
    public class Startup
    {
        public static void Main()
        {
            var cars = new HashSet<Car>();
            var numberOfCars = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCars; i++)
            {
                var carInput = Console.ReadLine().Split();

                var car = new Car(carInput[0], double.Parse(carInput[1]), double.Parse(carInput[2]));
                cars.Add(car);
            }

            var drive = Console.ReadLine();
            while (drive != "End")
            {
                var driveArgs = drive.Split();
                cars.FirstOrDefault(c => c.Model == driveArgs[1]).Drive(double.Parse(driveArgs[2]));
                drive = Console.ReadLine();
            }

            foreach (Car car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:F2} {car.DistanceTravelled}");
            }
        }
    }
}
