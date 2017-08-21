using System;
using System.Collections.Generic;
using System.Linq;
using _11.InfernoInfinity.Entities;
using _11.InfernoInfinity.Enums;
using _11.InfernoInfinity.Factories;
using _11.InfernoInfinity.Utilities;

namespace _11.InfernoInfinity.Core
{
    public class Engine
    {
        private bool isRunning;
        private List<Weapon> weapons;

        public Engine()
        {
            this.isRunning = true;
            this.weapons = new List<Weapon>();
        }

        public void Run()
        {
            while (isRunning)
            {
                var tokens = ConsoleReader.ReadLine()
                    .Split(';').ToList();
                var command = tokens[0];
                tokens.Remove(command);

                DistributeCommand(command, tokens);
            }
        }

        private void DistributeCommand(string command, List<string> tokens)
        {
            switch (command.ToLower())
            {
                case "create":
                    var rarityAndType = tokens[0].Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries).ToArray();
                    var typeOfWeapon = rarityAndType[1];
                    var rarity = (WeaponRarity)Enum.Parse(typeof(WeaponRarity), rarityAndType[0]);
                    var name = tokens[1];

                    var weapon = WeaponFactory.GetWeapon(typeOfWeapon, name, rarity);
                    this.weapons.Add(weapon);
                    break;
                case "add":
                    var weaponToAddGem = this.weapons.First(x => x.Name == tokens[0]);
                    int indexOfSocket = int.Parse(tokens[1]);

                    var typeAndClarityOfGem = tokens[2].Split(new [] {' '}, StringSplitOptions.RemoveEmptyEntries).ToArray();
                    var type = typeAndClarityOfGem[1];
                    var clarity = (GemClarity)Enum.Parse(typeof(GemClarity), typeAndClarityOfGem[0]);
                    var gem = GemFactory.GetGem(type, clarity);

                    weaponToAddGem.AddGem(gem, indexOfSocket);
                    break;
                case "remove":
                    var weaponToRemoveGem = this.weapons.First(x => x.Name == tokens[0]);
                    var indexOfSocketToRemove = int.Parse(tokens[1]);

                    weaponToRemoveGem.RemoveGem(indexOfSocketToRemove);
                    break;
                case "print":
                    var weaponToPrint = this.weapons.First(x => x.Name == tokens[0]);
                    ConsoleWriter.WriteLine(weaponToPrint);
                    break;
                case "end":
                    this.isRunning = false;
                    break;
            }
        }
    }
}
