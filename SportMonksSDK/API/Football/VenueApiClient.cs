using SportMonksSDK.API.Football.Entities;

namespace SportMonksSDK.API.Football
{
    public class VenueApiClient : BaseApiClient
    {
        public async Task<AllVenuesResponse?> GetAllVenues(string parametersPart = "includes=country;city;fixtures;")
            => await GetAll<AllVenuesResponse, Venue>(
                endpointPart: "football/venues",
                parametersPart: parametersPart
                );
        public async Task<VenueResponse?> GetVenueById(string id)
        => await GetSingle<VenueResponse>(
            endpointPart: $"football/venues/{id}",
            include: "includes=country;city;fixtures;"
            );
    }

    #region Models
    public class AllVenuesResponse : ListResponse<Venue>
    {
    }

    public class VenueResponse : SingleResponse<Venue>
    {
    }
    #endregion
}
