using System;
using System.Collections.Generic;
using System.Linq;
using _05.BorderControl.Interfaces;
using _05.BorderControl.Models;

namespace _05.BorderControl
{
    public class Startup
    {
        public static void Main()
        {
            var suspectedRebels = new HashSet<IIdentifiable>();

            var inputLine = Console.ReadLine();

            while (inputLine != "End")
            {
                var cmdArgs = inputLine.Split().ToArray();

                if (cmdArgs.Length == 2)
                {
                    var suspectedRobot = new Robot(cmdArgs[0], cmdArgs[1]);
                    suspectedRebels.Add(suspectedRobot);
                }
                else
                {
                    var suspectedCitizen = new Citizen(cmdArgs[0], int.Parse(cmdArgs[1]), cmdArgs[2]);
                    suspectedRebels.Add(suspectedCitizen);
                }

                inputLine = Console.ReadLine();
            }

            var idEndingToCheck = Console.ReadLine();
            CheckForRebels(suspectedRebels, idEndingToCheck);
        }

        private static void CheckForRebels(HashSet<IIdentifiable> suspectedRebels, string idEndingToCheck)
        {
            foreach (var rebel in suspectedRebels)
            {
                if (rebel.Id.EndsWith(idEndingToCheck))
                {
                    Console.WriteLine(rebel.Id);
                }
            }
        }
    }
}
