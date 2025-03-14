using SportMonksSDK.API.Football.Entities;

namespace SportMonksSDK.API.Football
{
    public class StatesApiClient : BaseApiClient
    {
        public async Task<AllStatesResponse?> GetAllStates(string parametersPart = "filters=populate")
            => await GetAll<AllStatesResponse, State>(
                endpointPart: "football/states",
                parametersPart: parametersPart
                );

        public async Task<StateResponse?> GetStateById(string id)
        => await GetSingle<StateResponse>(
            endpointPart: $"football/states/{id}"
            );
    }

    #region Models

    public class AllStatesResponse : ListResponse<State>
    {

    }

    public class StateResponse : SingleResponse<State>
    {

    }

    #endregion
}
