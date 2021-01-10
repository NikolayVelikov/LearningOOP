using System;

using FootballTeamGenerator1.Core;
using FootballTeamGenerator1.Models;

namespace FootballTeamGenerator1
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Engine engine = new Engine();

            engine.Run();
        }
    }
}
