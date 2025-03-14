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
