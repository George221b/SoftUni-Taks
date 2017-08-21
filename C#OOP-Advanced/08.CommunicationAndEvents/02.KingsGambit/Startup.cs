using System;
using System.Collections.Generic;
using System.Linq;
using _02.KingsGambit.Models;

namespace _02.KingsGambit
{
    public class Startup
    {
        public static void Main()
        {
            List<Soldier> army = new List<Soldier>();
            King king = new King(Console.ReadLine());

            string[] royalGuards = ReadSoldiersFromConsole();
            foreach (var royalGuard in royalGuards)
            {
                RoyalGuard guard = new RoyalGuard(royalGuard);
                army.Add(guard);
                king.UnderAttack += guard.KingUnderAttack;
            }

            string[] footmen = ReadSoldiersFromConsole();
            foreach (var footman in footmen)
            {
                Footman foot = new Footman(footman);
                army.Add(foot);
                king.UnderAttack += foot.KingUnderAttack;
            }


            string[] command = Console.ReadLine().Split();
            while (command[0] != "End")
            {
                switch (command[0])
                {
                    case "Kill":
                        Soldier soldier = army.FirstOrDefault(s => s.Name == command[1]);
                        king.UnderAttack -= soldier.KingUnderAttack;
                        army.Remove(soldier);
                        break;
                    case "Attack":
                        king.OnUnderAttack();
                        break;
                }
                command = Console.ReadLine().Split();
            }
        }

        private static string[] ReadSoldiersFromConsole()
        {
            return Console.ReadLine().Split().ToArray();
        }
    }
}
