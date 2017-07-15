using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.CarSalesman
{
    public class Startup
    {
        public static void Main()
        {
            var numberOfEngines = int.Parse(Console.ReadLine());
            var engines = new HashSet<Engine>();

            for (int i = 0; i < numberOfEngines; i++)
            {
                var engineArgs = Console.ReadLine().Split();
                var engine = new Engine(engineArgs[0], int.Parse(engineArgs[1]));
                if (engineArgs.Length == 3)
                {
                    int displacement;
                    if (int.TryParse(engineArgs[2], out displacement))
                    {
                        engine.Displacement = displacement.ToString();
                    }
                    else
                    {
                        engine.Efficiency = engineArgs[2];
                    }

                }
                else if(engineArgs.Length == 4)
                {
                    int displacement = int.Parse(engineArgs[2]);
                    string eff = engineArgs[3];

                    engine.Displacement = displacement.ToString();
                    engine.Efficiency = eff;
                }

                engines.Add(engine);
            }

            var numberOfCars = int.Parse(Console.ReadLine());
            var cars = new HashSet<Car>();
            for (int i = 0; i < numberOfCars; i++)
            {
                // “<Model> <Engine> <Weight> <Color>
                var carArgs = Console.ReadLine().Split(new [] {' '}, StringSplitOptions.RemoveEmptyEntries);
                var car = new Car(carArgs[0], engines.FirstOrDefault(e => e.Model == carArgs[1]));
                if (carArgs.Length == 3)
                {
                    int weight;
                    if (int.TryParse(carArgs[2], out weight))
                    {
                        car.Weight = weight.ToString();
                    }
                    else
                    {
                        car.Color = carArgs[2];
                    }
                }
                else if(carArgs.Length == 4)
                {
                    car.Weight = carArgs[2];
                    car.Color = carArgs[3];
                }

                cars.Add(car);
            }

            foreach (Car car in cars)
            {
                Console.WriteLine(car.ToString());
            }
        }
    }
}
