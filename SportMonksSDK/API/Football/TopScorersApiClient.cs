using SportMonksSDK.API.Football.Entities;

namespace SportMonksSDK.API.Football
{
    public class TopScorersApiClient : BaseApiClient
    {
        public async Task<AllTopScorersByStageIdResponse?> GetAllTopScorersByStageId(string stageId, string parametersPart = "filters=populate")
            => await GetAll<AllTopScorersByStageIdResponse, TopScorer>(
                endpointPart: $"football/topscorers/stages/{stageId}",
                parametersPart: parametersPart
                );
        public async Task<AllTopScorersBySeasonIdResponse?> GetAllTopScorersBySeasonId(string seasonId, string parametersPart = "filters=populate")
            => await GetAll<AllTopScorersBySeasonIdResponse, TopScorer>(
                endpointPart: $"football/topscorers/seasons/{seasonId}",
                parametersPart: parametersPart
                );
    }

    public class AllTopScorersByStageIdResponse : ListResponse<TopScorer>
    {
    }
    public class AllTopScorersBySeasonIdResponse : ListResponse<TopScorer>
    {
    }
}
