using System;

using FootballTeamGenerator1.Common;

namespace FootballTeamGenerator1.Models
{
    public class Stats
    {
        private const double skillsNumbers = 5;
        private int endurance;
        private int sprint;
        private int dribble;
        private int passing;
        private int shooting;

        public Stats(int endurance, int sprint, int dribble, int passing, int shooting)
        {
            this.Endurance = endurance;
            this.Sprint = sprint;
            this.Dribble = dribble;
            this.Passing = passing;
            this.Shooting = shooting;
        }

        public int Endurance
        {
            get { return this.endurance; }
            private set
            {
                ValidationMetod(value, nameof(Endurance));

                this.endurance = value;
            }
        }
        public int Sprint
        {
            get { return this.sprint; }
            private set
            {
                ValidationMetod(value, nameof(Sprint));

                this.sprint = value;
            }
        }
        public int Dribble
        {
            get { return this.dribble; }
            private set
            {
                ValidationMetod(value, nameof(Dribble));

                this.dribble = value;
            }
        }
        public int Passing
        {
            get { return this.passing; }
            private set
            {
                ValidationMetod(value, nameof(Passing));

                this.passing = value;
            }
        }
        public int Shooting
        {
            get { return this.shooting; }
            private set
            {
                ValidationMetod(value, nameof(Shooting));

                this.shooting = value;
            }
        }

        private void ValidationMetod(int value, string skill)
        {
            if (value < 0 || value > 100)
            {
                throw new ArgumentException(string.Format(ValidationMessages.STATS_OUT_OF_RANGE_Msg, skill));
            }
        }
        public double Skill()
        {
            double skill = (this.Endurance + this.Sprint + this.Dribble + this.Passing + this.Shooting) / skillsNumbers;

            return skill;
        }
    }
}
