using System;
using System.Collections.Generic;
using System.Linq;

namespace FootballTeamGenerator
{
    public class Team
    {
        // number of players, a name and a rating. 
        private string name;
        private int rating;
        private HashSet<Player> players;

        public Team(string name)
        {
            this.Name = name;
            this.Rating = rating;
            this.players = new HashSet<Player>();
        }

        public string Name
        {
            get { return this.name; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("A name should not be empty.");
                }
                this.name = value;
            }
        }

        public int Rating
        {
            get { return this.rating; }
            private set { this.rating = value; }
        }

        private HashSet<Player> Players
        {
            get { return this.players; }
            set { this.players = value; }
        }

        public void AddPlayer(Player player)
        {
            this.Players.Add(player);
        }

        public void RemovePlayer(string nameOfPlayer)
        {
            var remove = this.players.First(p => p.Name == nameOfPlayer);
            this.Players.Remove(remove);
        }

        public int GetStats()
        {
            var playerStats = 0.0;

            foreach (Player player in this.players)
            {
                double sum = (player.Dribble + player.Endurance + player.Passing + player.Shooting + player.Sprint) / 5.0;
                playerStats += sum;
            }
            if (playerStats != 0)
            {
                return (int)Math.Round(playerStats / this.players.Count, MidpointRounding.AwayFromZero);
            }

            return 0;
        }
    }
}
