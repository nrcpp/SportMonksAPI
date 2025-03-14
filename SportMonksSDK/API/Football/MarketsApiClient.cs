using SportMonksSDK.API.Football.Entities;

namespace SportMonksSDK.API.Football
{
    public class MarketsApiClient : BaseApiClient
    {
        public async Task<AllMarketsResponse?> GetAllMarkets(string parametersPart = "filters=populate")
            => await GetAll<AllMarketsResponse, Market>(
                endpointPart: "odds/markets",
                parametersPart: parametersPart
                );
        public async Task<MarketResponse?> GetMarketById(string id)
        => await GetSingle<MarketResponse>(
            endpointPart: $"odds/markets/{id}"
            );
    }

    #region Models

    public class AllMarketsResponse : ListResponse<Market>
    {
    }

    public class MarketResponse : SingleResponse<Market>
    {
    }

    #endregion
}
