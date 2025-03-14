using Microsoft.Extensions.Primitives;
using SportMonksSDK.API.Football.Entities;

namespace SportMonksSDK.API.Football
{
    public class PremiumOddsApiClient : BaseApiClient
    {
        public async Task<AllPremiumOddsResponse?> GetAllPremiumOdds(string parametersPart = "include=fixture;market;bookmaker;")
            => await GetAll<AllPremiumOddsResponse, PremiumOdd>(
                endpointPart: "football/odds/premium",
                parametersPart: parametersPart
                );

        public async Task<AllPremiumOddsResponse?> GetAllPremiumOddsByFixtureId(string fixtureId, string parametersPart = "include=fixture;market;bookmaker;")
            => await GetAll<AllPremiumOddsResponse, PremiumOdd>(
                endpointPart: $"football/odds/premium/fixtures/{fixtureId}",
                parametersPart: parametersPart
                );

        public async Task<AllPremiumOddsResponse?> GetAllPremiumOddsByFixtureIdAndBookmakerId(string fixtureId, string bookMakerId, string parametersPart = "include=fixture;market;bookmaker;")
            => await GetAll<AllPremiumOddsResponse, PremiumOdd>(
                endpointPart: $"football/odds/premium/fixtures/{fixtureId}/bookmakers/{bookMakerId}",
                parametersPart: parametersPart
            );

        public async Task<AllPremiumOddsResponse?> GetAllPremiumOddsByFixtureIdAndMarketId(string fixtureId, string marketId, string parametersPart = "include=fixture;market;bookmaker;")
            => await GetAll<AllPremiumOddsResponse, PremiumOdd>(
                endpointPart: $"football/odds/premium/fixtures/{fixtureId}/markets/{marketId}",
                parametersPart: parametersPart
            );

        public async Task<AllPremiumOddsResponse?> UpdatePremiumOddsBetweenTimeRange(string from, string to, string parametersPart = "include=fixture;market;bookmaker;")
            => await GetAll<AllPremiumOddsResponse, PremiumOdd>(
                endpointPart: $"football/odds/premium/updated/between/{from}/{to}",
                parametersPart: parametersPart
            );

        public async Task<AllPremiumOddsResponse?> UpdateHistoricalOddsBetweenTimeRange(string from, string to, string parametersPart = "include=fixture;market;bookmaker;")
            => await GetAll<AllPremiumOddsResponse, PremiumOdd>(
                endpointPart: $"football/odds/premium/history/updated/between/{from}/{to}",
                parametersPart: parametersPart
            );

        public async Task<AllPremiumOddsResponse?> GetAllHistoricalOdds(string parametersPart = "include=fixture;market;bookmaker;")
            => await GetAll<AllPremiumOddsResponse, PremiumOdd>(
                endpointPart: $"football/odds/premium/history",
                parametersPart: parametersPart
            );
    }

    #region Models
    public class AllPremiumOddsResponse : ListResponse<PremiumOdd>
    {
    }
    #endregion
}
