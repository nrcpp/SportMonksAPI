using SportMonksSDK.API.Football.Entities;

namespace SportMonksSDK.API.Football
{
    public class StandigsApiClient : BaseApiClient
    {
        public async Task<AllStandingsResponse?> GetAllStandings(string parametersPart = "includes=participant;season;league;stage;group;round;sport;")
            => await GetAll<AllStandingsResponse, Standing>(
                endpointPart: "football/standings",
                parametersPart: parametersPart
                );
    }

    #region Models
    public class AllStandingsResponse : ListResponse<Standing>
    {
    }
    #endregion
}
