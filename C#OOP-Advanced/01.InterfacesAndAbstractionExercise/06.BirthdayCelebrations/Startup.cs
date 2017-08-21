using System;
using System.Collections.Generic;
using System.Linq;
using _06.BirthdayCelebrations.Interfaces;
using _06.BirthdayCelebrations.Models;

namespace _06.BirthdayCelebrations
{
    public class Startup
    {
        public const string DateFormat = "dd/MM/yyyy";

        public static void Main()
        {
            var animals = new HashSet<IAnimal>();
            var inputLine = Console.ReadLine();

            while (inputLine != "End")
            {
                var cmdArgs = inputLine.Split().ToList();
                var command = cmdArgs[0];
                cmdArgs.Remove(command);

                IAnimal currentAnimal;
                switch (command)
                {
                    case "Citizen":
                        currentAnimal = new Citizen(cmdArgs[0], int.Parse(cmdArgs[1]),
                            cmdArgs[2], cmdArgs[3]);
                        animals.Add(currentAnimal);
                        break;
                    case "Pet":
                        currentAnimal = new Pet(cmdArgs[0], cmdArgs[1]);
                        animals.Add(currentAnimal);
                        break;
                }

                inputLine = Console.ReadLine();
            }

            var year = Console.ReadLine();

            foreach (var animal in animals)
            {
                if (animal.Birthday.EndsWith(year))
                {
                    Console.WriteLine(animal.Birthday);
                }
            }
        }
    }
}
