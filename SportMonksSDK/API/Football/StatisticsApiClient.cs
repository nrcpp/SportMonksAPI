using SportMonksSDK.API.Football.Entities;

namespace SportMonksSDK.API.Football
{
    public class StatisticsApiClient : BaseApiClient
    {
        public async Task<AllSeasonPlayerStatisticsResponse> GetAllSeasonPlayerStatisticsResponse(string playerId, string parametersPart = "includes=player;")
        => await GetAll<AllSeasonPlayerStatisticsResponse, PlayerStatistic>(
            endpointPart: $"football/statistics/seasons/{ParticipantType.Players}/{playerId}",
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
    }

    public class AllSeasonPlayerStatisticsResponse : ListResponse<PlayerStatistic>
    {
    }


}
