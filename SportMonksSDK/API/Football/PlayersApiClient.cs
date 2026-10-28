using SportMonksSDK.API.Football.Entities;

namespace SportMonksSDK.API.Football
{
    public class PlayersApiClient : BaseApiClient
    {
        public async Task<AllPlayersResponse?> GetAllPlayers(string parametersPart = "include=sport;country;city;")
            => await GetAll<AllPlayersResponse, Player>(
                endpointPart: "football/players",
                parametersPart: parametersPart
                );
        public async Task<PlayerResponse?> GetPlayerById(string id, string include = "include=sport;country;city;nationality;")
        => await GetSingle<PlayerResponse>(
            endpointPart: $"football/players/{id}",
            include: include
            );
    }

    #region Models
    public class AllPlayersResponse : ListResponse<Player>
    {

    }

    public class PlayerResponse : SingleResponse<Player>
    {

    }
    #endregion
}
