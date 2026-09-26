using SportMonksSDK.API.Football.Entities;

namespace SportMonksSDK.API.Football
{
    public class TransferApiClient : BaseApiClient
    {
        public async Task<AllTransfersResponse?> GetAllTransfers(string parametersPart = "include=sport;player;")
            => await GetAll<AllTransfersResponse, Transfer>(
                endpointPart: "football/transfers",
                parametersPart: parametersPart
                );

        public async Task<TransferResponse?> GetTransferById(string id)
        => await GetSingle<TransferResponse>(
            endpointPart: $"football/transfers/{id}",
            include: "include=sport;player;"
            );
    }

    #region Models
    public class AllTransfersResponse : ListResponse<Transfer>
    {
    }
    public class TransferResponse : SingleResponse<Transfer>
    {
    }
    #endregion
}
