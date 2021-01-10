using System;

using FootballTeamGenerator1.Common;

namespace FootballTeamGenerator1.Models
{
    public class Player
    {
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
                ValidationPlayerName(value);
                
                this.name = value;
            }
        }
        public Stats Stats { get; private set; }

        private void ValidationPlayerName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException(string.Format(ValidationMessages.NAME_EMPTY_Msg));
            }
        }
        public double SkillLevel()
        {
            return this.Stats.Skill();
        }
    }
}
