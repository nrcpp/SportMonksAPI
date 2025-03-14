using SportMonksSDK.API.Core.Entities;

namespace SportMonksSDK.API.Core
{
    public class CitiesApiClient : BaseApiClient
    {
        public async Task<AllCitiesResponse?> GetAllCities(string parametersPart = "includes=region")
            => await base.GetAll<AllCitiesResponse, City>(
                endpointPart: "core/cities",
                parametersPart: parametersPart
            );
        public async Task<CityResponse?> GetCityById(string cityId)
            => await base.GetSingle<CityResponse>(
                endpointPart: $"core/cities/{cityId}",
                include: "includes=region"
            );
    }

    #region Models
    public class AllCitiesResponse : ListResponse<City>
    {
    }
    public class CityResponse : SingleResponse<City>
    {
    }
    #endregion
}
