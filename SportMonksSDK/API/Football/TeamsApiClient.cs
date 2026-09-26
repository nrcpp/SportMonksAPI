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
