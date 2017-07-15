using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace FootballTeamGenerator
{
    public class Startup
    {
        public static void Main()
        {
            //Team; Arsenal
            //    Add; Arsenal; Kieran_Gibbs; 75; 85; 84; 92; 67
            //Add; Arsenal; Aaron_Ramsey; 195; 82; 82; 89; 68
            //Remove; Arsenal; Aaron_Ramsey
            //    Rating; Arsenal
            //    END

            try
            {
                var teams = new List<Team>();
                string inputLine = Console.ReadLine();
                while (inputLine != "END")
                {
                    var inputArgs = inputLine.Split(new[] {';'}, StringSplitOptions.RemoveEmptyEntries);
                    var command = inputArgs[0];
                    switch (command.ToLower())
                    {
                        case "team":
                            var team = new Team(inputArgs[1]);
                            teams.Add(team);
                            break;
                        case "add":
                            AddPlayerToTeam(teams, inputArgs);
                            break;
                        case "remove":
                            RemovePlayerFromTeam(teams, inputArgs);
                            break;
                        case "rating":
                            GetRatingForATeam(teams, inputArgs);
                            break;
                    }

                    inputLine = Console.ReadLine();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

        }

        private static void GetRatingForATeam(List<Team> teams, string[] inputArgs)
        {
            try
            {
                var teamToShow = teams.First(t => t.Name == inputArgs[1]);
                Console.WriteLine($"{teamToShow.Name} - {teamToShow.GetStats()}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Team {inputArgs[1]} does not exist.");
            }
        }

        private static void RemovePlayerFromTeam(List<Team> teams, string[] inputArgs)
        {
            try
            {
                var teamRemoveFrom = teams.FirstOrDefault(t => t.Name == inputArgs[1]);
                teamRemoveFrom.RemovePlayer(inputArgs[2]);

            }
            catch (Exception e)
            {
                Console.WriteLine($"Player {inputArgs[2]} is not in {inputArgs[1]} team.");
            }
        }

        private static void AddPlayerToTeam(List<Team> teams, string[] inputArgs)
        {
            try
            {
                var teamToAdd = teams.First(t => t.Name == inputArgs[1]);
                var player = new Player(inputArgs[2], int.Parse(inputArgs[3]), int.Parse(inputArgs[4]), int.Parse(inputArgs[5]), int.Parse(inputArgs[6]), int.Parse(inputArgs[7]));
                teamToAdd.AddPlayer(player);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Team {inputArgs[1]} does not exist.");
            }
        }
    }
}
