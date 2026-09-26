using SportMonksSDK.API.Football.Entities;

namespace SportMonksSDK.API.Football
{
    public class StandigsApiClient : BaseApiClient
    {
        public async Task<AllStandingsResponse?> GetAllStandings(string parametersPart = "include=participant;season;league;stage;group;round;sport;")
            => await GetAll<AllStandingsResponse, Standing>(
                endpointPart: "football/standings",
                parametersPart: parametersPart
                );

        public async Task<AllStandingsResponse?> GetAllStandingsBySeasonId(string seasonId, string parametersPart = "include=participant;details.type;")
            => await GetAll<AllStandingsResponse, Standing>(
                endpointPart: $"football/standings/seasons/{seasonId}",
                parametersPart: parametersPart
                );
    }

    #region Models
    public class AllStandingsResponse : ListResponse<Standing>
    {
    }
    #endregion
}
