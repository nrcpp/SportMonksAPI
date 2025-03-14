using SportMonksSDK.API.Football.Entities;

namespace SportMonksSDK.API.Football
{
    public class ExpectationsApiClient : BaseApiClient
    {
        public async Task<ExpectationsResponse?> GetExpectationsByTeam(string parametersPart = "include=fixture;participant;")
        => await GetAll<ExpectationsResponse, Expected>(
            endpointPart: "football/expected/fixtures",
            parametersPart: parametersPart
            );

        public async Task<ExpectationsResponse?> GetExpectationsByPlayer(string parametersPart = "include=fixture;player;team;")
            => await GetAll<ExpectationsResponse, Expected>(
                endpointPart: "football/expected/lineups",
                parametersPart: parametersPart
            );
    }

    #region Models
    public class ExpectationsResponse : ListResponse<Expected>
    {
    }
    #endregion
}
