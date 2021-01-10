using System;

using System.Linq;
using System.Collections.Generic;

using FootballTeamGenerator1.Common;

namespace FootballTeamGenerator1.Models
{
    public class Team
    {
        private string name;
        private readonly IList<Player> players;
        public Team()
        {
            this.players = new List<Player>();
        }
        public Team(string name) : this()
        {
            this.Name = name;            
        }

        public string Name
        {
            get { return this.name; }
            private set
            {
                CheckingTheName(value);

                this.name = value;
            }
        }
        public int Rating => TeamRating();
        private void CheckingTheName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException(ValidationMessages.NAME_EMPTY_Msg);
            }
        }
        private int TeamRating()
        {
            if (this.players.Count == 0)
            {
                return 0;
            }
            return (int)(Math.Round(players.Average(p => p.SkillLevel())));
        }
        public void Add(Player player)
        {
            //IfPlayerExist(player.Name);
            this.players.Add(player);
        }
        public void Remove(string name)
        {
            IfPlayerExist(name);
            this.players.Remove(this.players.First(p=>p.Name == name));
        }
        public void IfPlayerExist(string playerName)
        {
            if (this.players.FirstOrDefault(p=>p.Name == playerName) == null)
            {
                throw new ArgumentException(string.Format(ValidationMessages.MISSING_PLAYER_IN_THE_TEAM_Msg, playerName, this.Name));
            }
        }

        public override string ToString()
        {
            return $"{this.Name} - {this.Rating}";
        }
    }
}
