using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using _08.MillitaryElite.Interfaces;
using _08.MillitaryElite.Models;

namespace _08.MillitaryElite
{
    public class Startup
    {
        public static void Main()
        {
            var soldiers = new HashSet<ISoldier>();

            var inputLine = Console.ReadLine();
            while (inputLine != "End")
            {
                var cmdArgs = inputLine.Split().ToList();
                var command = cmdArgs[0];
                cmdArgs.Remove(command);

                switch (command)
                {
                    case "Private":
                        ISoldier currSoldier = new Private(
                            cmdArgs[0], cmdArgs[1], cmdArgs[2], double.Parse(cmdArgs[3]));
                        soldiers.Add(currSoldier);
                        break;
                    case "LeutenantGeneral":
                        AddLeutenant(soldiers, cmdArgs);
                        break;
                    case "Engineer":
                        AddEngineer(soldiers, cmdArgs);
                        break;
                    case "Commando":
                        AddCommando(soldiers, cmdArgs);
                        break;
                    case "Spy":
                        ISoldier spy = new Spy(cmdArgs[0], cmdArgs[1], cmdArgs[2], int.Parse(cmdArgs[3]));
                        soldiers.Add(spy);
                        break;
                    default:
                        throw new ArgumentException("No soldier with this type can be created.");
                        break;

                }

                inputLine = Console.ReadLine();
            }

            foreach (ISoldier soldier in soldiers)
            {
                Console.WriteLine(soldier);
            }
        }

        private static void AddCommando(HashSet<ISoldier> soldiers, List<string> cmdArgs)
        {
            try
            {
                var commando = new Commando(
                    cmdArgs[0], cmdArgs[1], cmdArgs[2], double.Parse(cmdArgs[3]), cmdArgs[4]);

                cmdArgs.RemoveRange(0, 5);

                for (int i = 0; i < cmdArgs.Count - 1; i++)
                {
                    try
                    {
                        var mission = new Mission(cmdArgs[i], cmdArgs[i + 1]);
                        commando.AddMission(mission);
                    }
                    catch (Exception ex)
                    {
                    }
                    i++;
                }

                soldiers.Add(commando);
            }
            catch (Exception e)
            {
            }
        }

        private static void AddEngineer(HashSet<ISoldier> soldiers, List<string> cmdArgs)
        {
            try
            {
                Engineer engineer = new Engineer(
                    cmdArgs[0], cmdArgs[1], cmdArgs[2], double.Parse(cmdArgs[3]), cmdArgs[4]);

                cmdArgs.RemoveRange(0, 5);

                for (int i = 0; i < cmdArgs.Count - 1; i++)
                {
                    var repair = new Repair(cmdArgs[i], int.Parse(cmdArgs[i + 1]));
                    engineer.Repairs.Add(repair);
                    i++;
                }

                soldiers.Add(engineer);
            }
            catch (Exception e)
            {
            }
        }

        private static void AddLeutenant(HashSet<ISoldier> soldiers, List<string> cmdArgs)
        {
            LeutenantGeneral leutenant = new LeutenantGeneral(
                cmdArgs[0], cmdArgs[1], cmdArgs[2], double.Parse(cmdArgs[3]));
            cmdArgs.RemoveRange(0, 4);

            for (int i = 0; i < cmdArgs.Count; i++)
            {
                var leutenantSubordinate = soldiers.First(x => x.Id == cmdArgs[i]);
                leutenant.AddPrivate((IPrivate)leutenantSubordinate);
            }

            soldiers.Add(leutenant);
        }
    }
}
