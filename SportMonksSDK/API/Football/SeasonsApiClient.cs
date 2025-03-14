using SportMonksSDK.API.Football.Entities;

namespace SportMonksSDK.API.Football
{
    public class SeasonsApiClient : BaseApiClient
    {
        public async Task<AllSeasonsResponse?> GetAllSeasons(string parametersPart = "includes=sport;league;teams;stages;fixtures;groups;topscorers;")
            => await GetAll<AllSeasonsResponse, Season>(
                endpointPart: "football/seasons",
                parametersPart: parametersPart
                );
        public async Task<SeasonResponse?> GetSeasonById(string id)
        => await GetSingle<SeasonResponse>(
            endpointPart: $"football/seasons/{id}",
            include: "includes=sport;league;teams;stages;fixtures;groups;topscorers;"
            );
    }

    #region Models
    public class AllSeasonsResponse : ListResponse<Season>
    {

    }

    public class SeasonResponse : SingleResponse<Season>
    {

    }
    #endregion
}
