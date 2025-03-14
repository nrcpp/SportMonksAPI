using SportMonksSDK.API.Football.Entities;

namespace SportMonksSDK.API.Football
{
    public class CommentariesApiClient : BaseApiClient
    {
        public async Task<AllCommentariesResponse?> GetAllCommentaries(string parametersPart = "include=player;fixture;")
            => await GetAll<AllCommentariesResponse, Commentary>(
                endpointPart: "football/commentaries",
                parametersPart: parametersPart
                );
        public async Task<AllCommentariesByFixtureIdResponse?> GetAllCommentariesByFixtureId(string fixtureId, string parametersPart = "include=player;fixture;")
            => await GetAll<AllCommentariesByFixtureIdResponse, Commentary>(
                endpointPart: $"football/commentaries/fixtures/{fixtureId}",
                parametersPart: parametersPart
                );

    }

    #region Models
    public class AllCommentariesResponse : ListResponse<Commentary>
    {
    }
    public class AllCommentariesByFixtureIdResponse : ListResponse<Commentary>
    {
    }
    #endregion
}
