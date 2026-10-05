using SportMonksSDK.API.Football.Entities;

namespace SportMonksSDK.API.Football
{
    public class TeamsApiClient : BaseApiClient
    {
        public async Task<AllTeamsResponse?> GetAllTeams(string parametersPart = "include=seasons;players;coaches;venue;country;sport;")
            => await GetAll<AllTeamsResponse, Team>(
                endpointPart: "football/teams",
                parametersPart: parametersPart
                );
        public async Task<TeamResponse?> GetTeamById(string id, string include = "include=seasons;players;coaches;venue;country;sport;")
        => await GetSingle<TeamResponse>(
            endpointPart: $"football/teams/{id}",
            include: include
            );

        // Every team of one season with that season's statistics in a single request
        // (verified live: 22 teams, no pagination with per_page=50).
        public async Task<AllTeamsResponse?> GetTeamsWithSeasonStatisticsBySeasonId(string seasonId)
            => await GetAll<AllTeamsResponse, Team>(
                endpointPart: $"football/teams/seasons/{seasonId}",
                parametersPart: $"include=statistics.details&filters=teamStatisticSeasons:{seasonId}&per_page=50"
                );
    }

    #region Models
    public class AllTeamsResponse : ListResponse<Team>
    {

    }

    public class TeamResponse : SingleResponse<Team>
    {

    }
    #endregion
}
