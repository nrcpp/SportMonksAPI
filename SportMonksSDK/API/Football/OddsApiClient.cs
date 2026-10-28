using SportMonksSDK.API.Football.Entities;

namespace SportMonksSDK.API.Football
{
    /// <summary>
    /// Iteration 4: standard (non-premium) pre-match odds. Verified live via
    /// "football/odds/pre-match/fixtures/{fixtureId}/bookmakers/{bookmakerId}", which lets
    /// Sportmonks do bookmaker filtering server-side - used exclusively with bookmaker id 20
    /// (Pinnacle) per the iteration's "Pinnacle only" requirement.
    /// </summary>
    public class OddsApiClient : BaseApiClient
    {
        public async Task<AllOddsResponse?> GetPreMatchOddsByFixtureIdAndBookmakerId(
            string fixtureId, string bookmakerId, string parametersPart = "")
            => await GetAll<AllOddsResponse, OddSm>(
                endpointPart: $"football/odds/pre-match/fixtures/{fixtureId}/bookmakers/{bookmakerId}",
                parametersPart: parametersPart
                );
    }

    public class AllOddsResponse : ListResponse<OddSm>
    {
    }
}
