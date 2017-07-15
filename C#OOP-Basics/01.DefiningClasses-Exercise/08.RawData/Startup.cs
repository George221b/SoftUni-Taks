using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.RawData
{
    public class Startup
    {
        public static void Main()
        {
            int numberOfCars = int.Parse(Console.ReadLine());

            var cars = new HashSet<Car>();

            for (int i = 0; i < numberOfCars; i++)
            {
                var inputCar = Console.ReadLine().Split();

                var car = new Car(inputCar[0], int.Parse(inputCar[1]), int.Parse(inputCar[2]), int.Parse(inputCar[3]), inputCar[4], double.Parse(inputCar[5]), double.Parse(inputCar[6]), double.Parse(inputCar[7]), double.Parse(inputCar[8]), double.Parse(inputCar[9]), double.Parse(inputCar[10]), double.Parse(inputCar[11]), double.Parse(inputCar[12]));

                cars.Add(car);
            }

            var command = Console.ReadLine();

            switch (command)
            {
                case "fragile":
                    foreach (Car car in cars
                        .Where(c => c.Cargo.Type == "fragile"))
                    {
                        if (car.Tires.Any(t => t.Age < 1))
                        {
                            Console.WriteLine($"{car.Model}");
                        }
                    }
                    break;

                case "flamable":
                    foreach (Car car in cars.Where(
                        c => c.Cargo.Type == "flamable"
                        && c.Engine.Power > 250))
                    {
                        Console.WriteLine($"{car.Model}");
                    }
                    break;
            }
        }
    }
}
