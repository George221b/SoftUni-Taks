namespace _03.TseamAccount
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static List<string> games;

        static void Main(string[] args)
        {
            games = Console.ReadLine().Split().ToList();

            var line = Console.ReadLine();

            while (line != "Play!")
            {
                var commandTokens = line.Split();
                var command = commandTokens[0];
                var currentGame = commandTokens[1];

                if (command == "Install")
                {
                    if (!games.Contains(currentGame))
                    {
                        games.Add(currentGame);
                    }
                }
                else if (command == "Uninstall")
                {
                    if (games.Exists(g => g == currentGame))
                    {
                        games.Remove(currentGame);
                    }
                }
                else if (command == "Update")
                {
                    if (games.Exists(g => g == currentGame))
                    {
                        games.Remove(currentGame);
                        games.Add(currentGame);
                    }
                }
                else if (command == "Expansion")
                {
                    var expansionTokens = currentGame.Split('-');
                    currentGame = expansionTokens[0];
                    var expansion = expansionTokens[1];

                    if (games.Exists(g => g == currentGame))
                    {
                        var indexToInsert = games.IndexOf(currentGame) + 1;

                        if (indexToInsert >= games.Count)
                        {
                            games.Add($"{currentGame}:{expansion}");
                        }
                        else
                        {
                            games.Insert(indexToInsert, $"{currentGame}:{expansion}");

                        }
                    }
                }

                line = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", games));
        }
    }
}