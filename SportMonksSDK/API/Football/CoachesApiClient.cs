using SportMonksSDK.API.Football.Entities;

namespace SportMonksSDK.API.Football
{
    public class CoachesApiClient : BaseApiClient
    {
        public async Task<AllCoachesResponse?> GetAllCoaches(string parametersPart = "include=player;sport;country;fixtures;")
            => await GetAll<AllCoachesResponse, Coach>(
                endpointPart: "football/coaches",
                parametersPart: parametersPart
                );
        public async Task<CoachResponse?> GetCoachById(string id)
        => await GetSingle<CoachResponse>(
            endpointPart: $"football/coaches/{id}",
            include: "include=player;sport;country;fixtures;"
            );
    }

    #region Models
    public class AllCoachesResponse : ListResponse<Coach>
    {

    }

    public class CoachResponse : SingleResponse<Coach>
    {

    }
    #endregion
}
