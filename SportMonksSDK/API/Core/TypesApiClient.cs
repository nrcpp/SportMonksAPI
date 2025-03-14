namespace SportMonksSDK.API.Core
{
    public class TypesApiClient : BaseApiClient
    {
        public async Task<AllTypesResponse?> GetAllTypes(string parametersPart = "filters=populate")
            => await base.GetAll<AllTypesResponse, Entities.Type>(
                endpointPart: "core/types",
                parametersPart: parametersPart
                );
        public async Task<TypeResponse?> GetTypeById(string typeId, string parametersPart = "filters=populate")
            => await base.GetSingle<TypeResponse>(
                endpointPart: $"core/types/{typeId}"
                );
    }

    #region Models
    public class AllTypesResponse : ListResponse<Entities.Type>
    {
    }
    public class TypeResponse : SingleResponse<Entities.Type>
    {
    }
    #endregion
}
