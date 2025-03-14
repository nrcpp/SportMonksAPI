namespace SportMonksSDK.API.Core
{
    public class TimezonesApiClient : BaseApiClient
    {
        public async Task<AllTimezonesResponse?> GetAllTimezones(string parametersPart = "filters=populate")
            => await base.GetAll<AllTimezonesResponse, string>(
                endpointPart: "core/timezones",
                parametersPart: parametersPart
                );
    }

    public class AllTimezonesResponse : ListResponse<string>
    {
    }
}
