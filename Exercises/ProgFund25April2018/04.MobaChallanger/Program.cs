namespace _04.MobaChallanger
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static List<Player> playerDb;

        public static void Main()
        {
            playerDb = new List<Player>();

            var line = Console.ReadLine();

            while (line != "Season end")
            {
                if (!line.Contains(" vs "))
                { // New Player or Update Player
                    var playerTokens = line.Split(" -> ");

                    var playerName = playerTokens[0];
                    var playerLane = playerTokens[1];
                    var playerSkill = int.Parse(playerTokens[2]);

                    if (!playerDb.Any(p => p.Name == playerName))
                    {
                        playerDb.Add(
                            new Player()
                            {
                                Name = playerName,
                                Positions = new List<Position>()
                            });
                    }

                    var currentPlayer = playerDb.First(p => p.Name == playerName);

                    if (!currentPlayer.Positions.Any(p => p.Lane == playerLane))
                    {
                        currentPlayer.Positions.Add(new Position()
                        {
                            Lane = playerLane,
                            Skill = playerSkill
                        });
                    }
                    else
                    {
                        var currentPlayerSkill = currentPlayer.Positions.First(p => p.Lane == playerLane).Skill;

                        if (currentPlayerSkill < playerSkill)
                        {
                            currentPlayer.Positions.First(p => p.Lane == playerLane).Skill = currentPlayerSkill;
                        }
                    }
                }
                else
                { // Du-du-du duel Time
                    var duelTokens = line.Split(" vs ");

                    var firstPlayerName = duelTokens[0];
                    var secondPlayerName = duelTokens[1];

                    if (playerDb.Exists(p => p.Name == firstPlayerName) &&
                playerDb.Exists(p => p.Name == secondPlayerName))
                    {
                        var first = playerDb.First(p => p.Name == firstPlayerName);
                        var second = playerDb.First(p => p.Name == secondPlayerName);

                        Player.Duel(first, second, playerDb);
                    }
                }

                line = Console.ReadLine();
            }

            PrintPlayer();
        }

        private static void PrintPlayer()
        {
            foreach (var player in playerDb
    .OrderByDescending(p => p.Positions.Sum(pos => pos.Skill))
    .ThenBy(p => p.Name))
            {
                var playerPositions = player.Positions
                    .OrderByDescending(pos => pos.Skill)
                    .ThenBy(pos => pos.Lane)
                    .Select(pos => $"- {pos.Lane} <::> {pos.Skill}");

                Console.WriteLine($"{player.Name}: {player.Positions.Sum(pos => pos.Skill)} skill");

                Console.WriteLine(string.Join(Environment.NewLine, playerPositions));
            }
        }
    }

    public class Player
    {
        public string Name { get; set; }

        public List<Position> Positions { get; set; }

        public static void Duel(Player firstPlayer, Player secondPlayer, List<Player> playerDb)
        {
            if (firstPlayer.Positions.Select(p => p.Lane).ToList().Intersect(secondPlayer.Positions.Select(p => p.Lane).ToList()).Any())
            {
                var totalSkillFirst = firstPlayer.Positions.Sum(p => p.Skill);
                var totalSkillSecond = secondPlayer.Positions.Sum(p => p.Skill);

                if (totalSkillFirst > totalSkillSecond)
                {
                    playerDb.Remove(secondPlayer);
                }
                else if (totalSkillSecond > totalSkillFirst)
                {
                    playerDb.Remove(firstPlayer);
                }
            }
        }
    }

    public class Position
    {
        public string Lane { get; set; }

        public int Skill { get; set; }
    }
}