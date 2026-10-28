using SportMonksSDK.API.Core.Entities;

namespace SportMonksSDK.API.Core
{
    public class CountriesApiClient : BaseApiClient
    {
        public async Task<AllCountriesResponse?> GetAllCountries(string parametersPart = "filters=populate")
            => await base.GetAll<AllCountriesResponse, Country>(
                endpointPart: "core/countries",
                parametersPart: parametersPart
            );

        public async Task<CountryResponse?> GetCountryById(int countryId)
            => await base.GetSingle<CountryResponse>(
                endpointPart: $"core/countries/{countryId}"
            );

        public async Task<AllCountriesResponse?> SearchCountries(string name)
            => await base.GetAll<AllCountriesResponse, Country>(
                endpointPart: $"core/countries/search/{name}",
                parametersPart: ""
            );
    }

    #region Models
    public class AllCountriesResponse : ListResponse<Country>
    {
    }
    public class CountryResponse : SingleResponse<Country>
    {
    }
    #endregion
}

