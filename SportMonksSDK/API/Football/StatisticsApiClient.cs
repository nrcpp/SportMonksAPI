using SportMonksSDK.API.Football.Entities;

namespace SportMonksSDK.API.Football
{
    public class StatisticsApiClient : BaseApiClient
    {
        public async Task<AllSeasonPlayerStatisticsResponse> GetAllSeasonPlayerStatisticsResponse(string playerId, string parametersPart = "include=player;")
        => await GetAll<AllSeasonPlayerStatisticsResponse, PlayerStatistic>(
            endpointPart: $"football/statistics/seasons/{ParticipantType.Players}/{playerId}",
            parametersPart: parametersPart
            );

        // Iteration 4: team season statistics. No dedicated client existed for this endpoint;
        // verified live via "football/statistics/seasons/teams/{teamId}" (real response returns
        // every season the team has data for, including many past seasons - callers must filter
        // to the current season_id before use).
        public async Task<AllSeasonTeamStatisticsResponse> GetAllSeasonTeamStatisticsResponse(string teamId, string parametersPart = "include=team;")
        => await GetAll<AllSeasonTeamStatisticsResponse, TeamStatistic>(
            endpointPart: $"football/statistics/seasons/teams/{teamId}",
            parametersPart: parametersPart
            );
    }

    public class PlayerStatistic
    {
        public int id { get; set; }
        public int? player_id { get; set; }
        public Player player { get; set; }
        public int? team_id { get; set; }
        public int? jersey_number { get; set; }
        public int? position_id { get; set; }
        public int? season_id { get; set; }
        public bool? has_values { get; set; }
        public List<StatisticDetail>? details { get; set; }
    }

    public class AllSeasonPlayerStatisticsResponse : ListResponse<PlayerStatistic>
    {
    }

    public class AllSeasonTeamStatisticsResponse : ListResponse<TeamStatistic>
    {
    }

}
