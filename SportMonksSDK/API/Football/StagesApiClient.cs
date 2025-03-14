using SportMonksSDK.API.Football.Entities;

namespace SportMonksSDK.API.Football
{
    public class StagesApiClient : BaseApiClient
    {
        public async Task<AllStagesResponse?> GetAllStages(string parametersPart = "includes=league;season;sport;rounds;groups;fixtures;aggregates;topscorers;")
            => await GetAll<AllStagesResponse, Stage>(
                endpointPart: "football/stages",
                parametersPart: parametersPart
                );
        public async Task<StageResponse?> GetStageById(string id)
        => await GetSingle<StageResponse>(
            endpointPart: $"football/stages/{id}",
            include: "includes=league;season;sport;rounds;groups;fixtures;aggregates;topscorers;"
            );
    }

    #region Models
    public class AllStagesResponse : ListResponse<Stage>
    {

    }

    public class StageResponse : SingleResponse<Stage>
    {

    }

    #endregion
}
