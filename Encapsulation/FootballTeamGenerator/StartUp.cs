using System;
using System.Collections.Generic;
using System.Linq;

namespace FootballTeamGenerator
{
    class StartUp
    {
        static void Main(string[] args)
        {
            List<Team> teams = new List<Team>();
            string comand = string.Empty;
            while ((comand = Console.ReadLine()) != "END")
            {
                try
                {
                    string[] input = comand.Split(';', StringSplitOptions.RemoveEmptyEntries);
                    if (input[0] == "Team")
                    {
                        string name = input[1];
                        Team newTeam = new Team(name);
                        teams.Add(newTeam);
                    }
                    else if (input[0] == "Add")
                    {
                        Team currentTeam = teams.FirstOrDefault(t => t.Name == input[1]);
                        if (currentTeam == null)
                        {
                            throw new ArgumentException($"Team {input[1]} does not exist.");
                        }
                        string name = input[2];
                        int edurance = int.Parse(input[3]);
                        int sprint = int.Parse(input[4]);
                        int dribble = int.Parse(input[5]);
                        int passing = int.Parse(input[6]);
                        int shooting = int.Parse(input[7]);
                        Player player = new Player(name, new Stats(edurance, sprint, dribble, passing, shooting));
                        currentTeam.Add(player);
                    }
                    else if (input[0] == "Remove")
                    {
                        Team currentTeam = teams.FirstOrDefault(t => t.Name == input[1]);
                        if (currentTeam == null)
                        {
                            throw new ArgumentException($"Team {input[1]} does not exist.");
                        }
                        string player = input[2];                        
                        currentTeam.Remove(player);
                    }
                    else if (input[0] == "Rating")
                    {
                        Team currentTeam = teams.FirstOrDefault(t => t.Name == input[1]);
                        if (currentTeam == null)
                        {
                            throw new ArgumentException($"Team {input[1]} does not exist.");
                        }

                        currentTeam.Rating();
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    continue;
                }
            }
        }
    }
}
