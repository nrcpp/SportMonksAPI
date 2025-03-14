using SportMonksSDK.API.Football.Entities;

namespace SportMonksSDK.API.Football
{
    public class TeamSquadsApiClient : BaseApiClient
    {
        public async Task<AllTeamSquadsResponse?> GetAllTeamSquads(string id, string parametersPart = "filters=populate")
            => await GetAll<AllTeamSquadsResponse, TeamSquad>(
                endpointPart: $"football/squads/teams/{id}",
                parametersPart: parametersPart
                );

        public async Task<AllTeamSquadsResponse?> GetAllTeamSquadsExtended(string id, string parametersPart = "filters=populate")
            => await GetAll<AllTeamSquadsResponse, TeamSquad>(
                endpointPart: $"football/squads/teams/{id}/extended",
                parametersPart: parametersPart
            );
    }

    #region Models
    public class AllTeamSquadsResponse : ListResponse<TeamSquad>
    {

    }

    public class TeamSquadResponse : SingleResponse<TeamSquad>
    {

    }
    #endregion
}
