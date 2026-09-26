using SportMonksSDK.API.Football.Entities;

namespace SportMonksSDK.API.Football
{
    public class LeaguesApiClient : BaseApiClient
    {
        public async Task<AllLeaguesResponse?> GetAllLeagues(string parametersPart = "include=sport;country;seasons;stages;")
            => await GetAll<AllLeaguesResponse, League>(
                endpointPart: "football/leagues",
                parametersPart: parametersPart
                );
        public async Task<LeagueResponse?> GetLeagueById(string id, string include = "include=sport;country;seasons;stages")
        => await GetSingle<LeagueResponse>(
            endpointPart: $"football/leagues/{id}",
            include: include
            );

        public async Task<LeagueResponse?> GetLeagueByIdWithCurrentSeason(string id)
        => await GetSingle<LeagueResponse>(
            endpointPart: $"football/leagues/{id}",
            include: "include=currentSeason;country"
            );
    }

    #region Models
    public class AllLeaguesResponse : ListResponse<League>
    {

    }

    public class LeagueResponse : SingleResponse<League>
    {

    }
    #endregion
}