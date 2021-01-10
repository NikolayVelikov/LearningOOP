using System;

using System.Linq;
using System.Collections.Generic;

using FootballTeamGenerator1.Models;
using FootballTeamGenerator1.Common;

namespace FootballTeamGenerator1.Core
{
    public class Engine
    {
        private readonly IList<Team> teams;
        private readonly IList<Player> players;
        public Engine()
        {
            this.teams = new List<Team>();
            this.players = new List<Player>();
        }

        public void Run()
        {
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "END")
            {
                try
                {
                    string[] comand = input.Split(';', StringSplitOptions.RemoveEmptyEntries);
                    if (comand[0] == "Team")
                    {
                        string name = comand[1];
                        Team newTeam = new Team(name);
                        this.teams.Add(newTeam);
                    }
                    else if (comand[0] == "Add")
                    {
                        IfTeamExist(comand[1]);
                        Player player = CreatingPlayer(comand.Skip(2).ToArray());
                        this.players.Add(player);
                        this.teams.First(t => t.Name == comand[1]).Add(player);
                    }
                    else if (comand[0] == "Remove")
                    {
                        IfTeamExist(comand[1]);
                        IfPlayerExist(comand[1], comand[2]);
                        this.teams.First(t => t.Name == comand[1]).Remove(comand[2]);
                    }
                    else if (comand[0] == "Rating")
                    {
                        IfTeamExist(comand[1]);
                        Console.WriteLine(this.teams.First(t => t.Name == comand[1]));
                    }
                }
                catch (Exception ae)
                {
                    Console.WriteLine(ae.Message);
                }
            }
        }

        private void IfTeamExist(string teamName)
        {
            if (this.teams.FirstOrDefault(t => t.Name == teamName) == null)
            {
                throw new ArgumentException(string.Format(ValidationMessages.MISSING_TEM_IN_THE_LIST_Msg, teamName));
            }
        }
        private void IfPlayerExist(string teamName, string playerName)
        {
            if (this.players.FirstOrDefault(p => p.Name == playerName) == null)
            {
                throw new ArgumentException(string.Format(ValidationMessages.MISSING_PLAYER_IN_THE_TEAM_Msg, playerName, teamName));
            }

        }
        private Player CreatingPlayer(string[] nameAndSkills)
        {
            string name = nameAndSkills[0];
            Player player = new Player(name, CreatingStats(nameAndSkills.Skip(1).ToArray()));

            return player;
        }
        private Stats CreatingStats(string[] skills)
        {
            int endurance = int.Parse(skills[0]);
            int sprint = int.Parse(skills[1]);
            int dribble = int.Parse(skills[2]);
            int passing = int.Parse(skills[3]);
            int shooting = int.Parse(skills[4]);
            Stats stats = new Stats(endurance, sprint, dribble, passing, shooting);

            return stats;
        }
    }
}
