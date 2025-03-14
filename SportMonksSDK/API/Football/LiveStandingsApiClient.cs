using SportMonksSDK.API.Football.Entities;

namespace SportMonksSDK.API.Football
{
    public class LiveStandingsApiClient : BaseApiClient
    {
        public async Task<LiveStandingsResponse?> GetAllLiveStandingsByLeagueId(string id, string parametersPart = "include=participant;sport;league;season;stage;group;round;")
            => await GetAll<LiveStandingsResponse, Standing>(
                endpointPart: $"football/standings/seasons/{id}",
                parametersPart: parametersPart
            );
    }

    #region Models
    public class LiveStandingsResponse : ListResponse<Standing>
    {

    }
    #endregion
}
