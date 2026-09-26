using SportMonksSDK.API.Football.Entities;

namespace SportMonksSDK.API.Football
{
    public class RoundsApiClient : BaseApiClient
    {
        public async Task<AllRoundsResponse?> GetAllRounds(string parametersPart = "include=sport;league;season;stage;fixtures;")
            => await GetAll<AllRoundsResponse, Round>(
                endpointPart: "football/rounds",
                parametersPart: parametersPart
                );
        public async Task<RoundResponse?> GetRoundById(string id)
        => await GetSingle<RoundResponse>(
            endpointPart: $"football/rounds/{id}",
            include: "include=sport;league;season;stage;fixtures;"
            );
    }

    #region Models
    public class AllRoundsResponse : ListResponse<Round>
    {

    }

    public class RoundResponse : SingleResponse<Round>
    {

    }
    #endregion
}
