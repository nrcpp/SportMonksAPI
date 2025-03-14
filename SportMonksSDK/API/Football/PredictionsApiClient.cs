using SportMonksSDK.API.Football.Entities;

namespace SportMonksSDK.API.Football
{
    public class PredictionsApiClient : BaseApiClient
    {
        public async Task<AllPredictionsResponse?> GetAllPredictions(string parametersPart = "include=fixture;")
            => await GetAll<AllPredictionsResponse, PredictionParent>(
                endpointPart: "football/predictions/probabilities",
                parametersPart: parametersPart
                );
        public async Task<AllPredictionsByFixtureIdResponse?> GetAllPredictionsByFixtureId(string fixtureId, string parametersPart = "include=fixture;")
            => await GetAll<AllPredictionsByFixtureIdResponse, PredictionParent>(
                endpointPart: $"football/predictions/probabilities/fixtures/{fixtureId}",
                parametersPart: parametersPart
                );
    }

    #region Models
    public class AllPredictionsResponse : ListResponse<PredictionParent>
    {
    }
    public class AllPredictionsByFixtureIdResponse : ListResponse<PredictionParent>
    {
    }
    #endregion
}
