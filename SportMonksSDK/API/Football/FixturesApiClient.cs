using SportMonksSDK.API.Football.Entities;

namespace SportMonksSDK.API.Football
{
    public class FixturesApiClient : BaseApiClient
    {
        public async Task<AllFixturesResponse?> GetAllFixtures(string parametersPart = "include=participants;scores;coaches;referees;venue;sport;league;season;stage;aggregate;state;round;")
            => await GetAll<AllFixturesResponse, Fixture>(
                endpointPart: "football/fixtures",
                parametersPart: parametersPart
                );

        public async Task<FixtureResponse?> GetFixtureById(
            string id,
            string include = "include=participants;scores;coaches;referees;venue;sport;league;season;stage;aggregate;state;round;")
        => await GetSingle<FixtureResponse>(
            endpointPart: $"football/fixtures/{id}",
            include: include
            );

        // GET Fixtures by Multiple IDs: at most 50 ids per request (Sportmonks limit).
        public async Task<AllFixturesResponse?> GetFixturesByMultipleIds(IReadOnlyCollection<int> ids, string parametersPart = "include=participants;scores")
        {
            if (ids.Count is 0 or > 50)
                throw new ArgumentOutOfRangeException(nameof(ids), ids.Count, "Sportmonks multi-fixture endpoint accepts 1..50 ids.");
            return await GetAll<AllFixturesResponse, Fixture>(
                endpointPart: $"football/fixtures/multi/{string.Join(',', ids)}",
                parametersPart: parametersPart);
        }

        // yyyy-mm-dd
        public async Task<AllFixturesResponse?> GetFixturesByDate(string date, string parametersPart = "include=participants;scores;coaches;referees;venue;sport;league;season;stage;aggregate;state;round;")
           => await GetAll<AllFixturesResponse, Fixture>(
               endpointPart: $"football/fixtures/date/{date}",
               parametersPart: parametersPart
               );
    }

    #region Models
    public class AllFixturesResponse : ListResponse<Fixture>
    {

    }

    public class FixtureResponse : SingleResponse<Fixture>
    {

    }
    #endregion
}
