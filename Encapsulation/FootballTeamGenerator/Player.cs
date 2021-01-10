using System;
using System.Collections.Generic;
using System.Text;

namespace FootballTeamGenerator
{
    public class Player
    {
        private const string ERROR_MESSAGE_PLAYER_NAME = "A name should not be empty.";
        private string name;

        public Player(string name, Stats stats)
        {
            this.Name = name;
            this.Stats = stats;
        }
        public string Name
        {
            get { return this.name; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException(ERROR_MESSAGE_PLAYER_NAME);
                }
                this.name = value;
            }
        }
        public Stats Stats { get; private set; }

        public int SkillLevel()
        {
            int average = (int)Math.Round((this.Stats.Endurance + this.Stats.Sprint +
                this.Stats.Dribble + this.Stats.Passing + this.Stats.Shooting)*1.0 / 5);
            return average;
        }
    }
}
