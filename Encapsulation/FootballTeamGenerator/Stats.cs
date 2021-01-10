using System;
using System.Collections.Generic;
using System.Text;

namespace FootballTeamGenerator
{
    public class Stats
    {
        private const string ERROR_MESSAGE = " should be between 0 and 100.";
        private int endurance;
        private int sprint;
        private int dribble;
        private int passing;
        private int shooting;
        public Stats(int endurance,int sprint,int dribble, int passing, int shooting)
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
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException($"Endurance{ERROR_MESSAGE}");
                }
                this.endurance = value; ;
            }
        }
        public int Sprint
        {
            get { return this.sprint; }
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException($"Sprint{ERROR_MESSAGE}");
                }
                this.sprint = value; ;
            }
        }
        public int Dribble
        {
            get { return this.dribble; }
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException($"Dribble{ERROR_MESSAGE}");
                }
                this.dribble = value; ;
            }
        }
        public int Passing
        {
            get { return this.passing; }
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException($"Passing{ERROR_MESSAGE}");
                }
                this.passing = value; ;
            }
        }
        public int Shooting
        {
            get { return this.shooting; }
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException($"Shooting{ERROR_MESSAGE}");
                }
                this.shooting = value; ;
            }
        }
    }
}
