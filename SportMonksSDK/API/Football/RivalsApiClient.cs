using SportMonksSDK.API.Football.Entities;

namespace SportMonksSDK.API.Football
{
    public class RivalsApiClient : BaseApiClient
    {
        public async Task<AllRivalsResponse?> GetAllRivals(string parametersPart = "includes=team;")
            => await GetAll<AllRivalsResponse, Rival>(
                endpointPart: "football/rivals",
                parametersPart: parametersPart
                );
        public async Task<AllRivalsByTeamIdResponse?> GetAllRivalsByTeamId(string teamId, string parametersPart = "includes=team;")
            => await GetAll<AllRivalsByTeamIdResponse, Rival>(
                endpointPart: $"football/rivals/teams/{teamId}",
                parametersPart: parametersPart
                );
    }

    #region Models
    public class AllRivalsResponse : ListResponse<Rival>
    {
    }
    public class AllRivalsByTeamIdResponse : ListResponse<Rival>
    {
    }

    #endregion
}
