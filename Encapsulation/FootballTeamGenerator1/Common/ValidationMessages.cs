

namespace FootballTeamGenerator1.Common
{
   public static class ValidationMessages
    {
        public const string STATS_OUT_OF_RANGE_Msg = "{0} should be between 0 and 100.";
        public const string NAME_EMPTY_Msg = "A name should not be empty.";
        public const string MISSING_PLAYER_IN_THE_TEAM_Msg = "Player {0} is not in {1} team.";
        public const string MISSING_TEM_IN_THE_LIST_Msg = "Team {0} does not exist.";
    }
}
