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
        public async Task<TeamResponse?> GetTeamById(string id)
        => await GetSingle<TeamResponse>(
            endpointPart: $"football/teams/{id}",
            include: "include=seasons;players;coaches;venue;country;sport;"
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
