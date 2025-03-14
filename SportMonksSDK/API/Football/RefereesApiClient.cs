using SportMonksSDK.API.Football.Entities;

namespace SportMonksSDK.API.Football
{
    public class RefereesApiClient : BaseApiClient
    {
        public async Task<AllRefereesResponse?> GetAllReferees(string parametersPart = "include=sport;country;city")
            => await GetAll<AllRefereesResponse, Referee>(
                endpointPart: "football/referees",
                parametersPart: parametersPart
                );
        public async Task<RefereeResponse?> GetRefereeById(string id)
        => await GetSingle<RefereeResponse>(
            endpointPart: $"football/referees/{id}",
            include: "include=sport;country;city"
            );
    }

    #region Models
    public class AllRefereesResponse : ListResponse<Referee>
    {

    }

    public class RefereeResponse : SingleResponse<Referee>
    {

    }
    #endregion
}
