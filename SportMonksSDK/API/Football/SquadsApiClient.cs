using SportMonksSDK.API.Football.Entities;

namespace SportMonksSDK.API.Football
{
    public class SquadsApiClient : BaseApiClient
    {
        public async Task<AllSquadsByTeamIdResponse?> GetAllSquadsByTeamId(string teamId, string parametersPart = "filters=populate")
            => await GetAll<AllSquadsByTeamIdResponse, Squad>(
                endpointPart: $"football/squads/teams/{teamId}",
                parametersPart: parametersPart
                );

        public async Task<AllSquadsBySeasonAndTeamIdResponse?> GetAllSquadsBySeasonAndTeamId(string seasonId, string teamId, string parametersPart = "filters=populate")
        => await GetAll<AllSquadsBySeasonAndTeamIdResponse, Squad>(
            endpointPart: $"football/squads/seasons/{seasonId}/teams/{teamId}",
            parametersPart: parametersPart
            );

        // Same endpoint with `include=details`: returns one PlayerStatistic row (with season stat
        // details) per squad player - the per-team replacement for per-player season statistics.
        public async Task<AllSeasonPlayerStatisticsResponse?> GetSquadPlayerStatisticsBySeasonAndTeamId(
            string seasonId, string teamId, string parametersPart = "include=details;player")
        => await GetAll<AllSeasonPlayerStatisticsResponse, PlayerStatistic>(
            endpointPart: $"football/squads/seasons/{seasonId}/teams/{teamId}",
            parametersPart: parametersPart
            );
    }

    #region Models
    public class AllSquadsByTeamIdResponse : ListResponse<Squad>
    {
    }

    public class AllSquadsBySeasonAndTeamIdResponse : ListResponse<Squad>
    {
    }
    #endregion
}
