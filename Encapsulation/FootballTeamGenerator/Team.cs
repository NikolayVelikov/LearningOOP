using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FootballTeamGenerator
{
    public class Team
    {
        private const string ERROR_MESSAGE_TEAM_NAME = "A name should not be empty.";
        private string name;
        private List<Player> players;

        public Team(string name)
        {
            this.Name = name;
            this.players = new List<Player>();
        }
        public string Name
        {
            get { return this.name; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ERROR_MESSAGE_TEAM_NAME);
                }
                this.name = value;
            }
        }

        public IReadOnlyCollection<Player> Players { get {return this.players.AsReadOnly(); } }

        public void Add(Player player)
        {
            players.Add(player);
        }
        public void Remove(string player)
        {
            Player currentPlayer = null;
            foreach (var item in players)
            {
                if (item.Name == player)
                {
                    currentPlayer = item;
                    break;
                }
            }
            if (currentPlayer==null)
            {
                throw new ArgumentException($"Player {player} is not in {this.Name} team.");
            }
            this.players.Remove(currentPlayer);
        }

        public void Rating()
        {
            if (this.players.Count == 0)
            {                
                Console.WriteLine($"{this.Name} - 0");
            }
            else
            {
                int rating = (int)Math.Round(this.players.Sum(p => p.SkillLevel()) * 1.0 / this.players.Count);
                Console.WriteLine($"{this.Name} - {rating}");
            }
            
        }
    }
}
