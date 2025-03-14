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

        public async Task<FixtureResponse?> GetFixtureById(string id)
        => await GetSingle<FixtureResponse>(
            endpointPart: $"football/fixtures/{id}",
            include: "include=participants;scores;coaches;referees;venue;sport;league;season;stage;aggregate;state;round;"
            );

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
