using SportMonksSDK.API.Core.Entities;

namespace SportMonksSDK.API.Core
{
    public class ContinentsApiClient : BaseApiClient
    {
        public async Task<AllContinentsResponse?> GetAllContinents(string parametersPart = "includes=countries;")
            => await base.GetAll<AllContinentsResponse, Continent>(
                endpointPart: "core/continents",
                parametersPart: parametersPart
                );
        public async Task<ContinentResponse?> GetContinentById(string continentId)
            => await base.GetSingle<ContinentResponse>(
                endpointPart: $"core/continents/{continentId}",
                include: "includes=countries;"
                );
    }

    #region Models
    public class AllContinentsResponse : ListResponse<Continent>
    {
    }
    public class ContinentResponse : SingleResponse<Continent>
    {
    }
    #endregion
}
