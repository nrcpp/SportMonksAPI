using SportMonksSDK.API.Football.Entities;

namespace SportMonksSDK.API.Football
{
    public class BookmakersApiClient : BaseApiClient
    {
        public async Task<AllBookmakersResponse?> GetAllBookmakers(string parametersPart = "filters=populate")
            => await GetAll<AllBookmakersResponse, Bookmaker>(
                endpointPart: "odds/bookmakers",
                parametersPart: parametersPart
                );
        public async Task<BookmakerResponse?> GetBookmakerById(string id)
        => await GetSingle<BookmakerResponse>(
            endpointPart: $"odds/bookmakers/{id}"
            );
    }

    #region Models

    public class AllBookmakersResponse : ListResponse<Bookmaker>
    {
    }

    public class BookmakerResponse : SingleResponse<Bookmaker>
    {
    }

    #endregion
}
