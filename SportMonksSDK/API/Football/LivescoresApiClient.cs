using SportMonksSDK.API.Football.Entities;

namespace SportMonksSDK.API.Football
{
    public class LivescoresApiClient : BaseApiClient
    {
        public async Task<AllFixturesResponse?> GetAllLivescores(string parametersPart = "include=participants;scores;coaches;referees;venue;sport;league;season;stage;aggregate;state;round;")
            => await GetAll<AllFixturesResponse, Fixture>(
                endpointPart: "football/livescores",
                parametersPart: parametersPart
            );
    }
}
