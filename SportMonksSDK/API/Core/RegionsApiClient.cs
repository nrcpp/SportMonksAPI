using SportMonksSDK.API.Core.Entities;

namespace SportMonksSDK.API.Core
{
    public class RegionsApiClient : BaseApiClient
    {
        public async Task<AllRegionsResponse?> GetAllRegions(string parametersPart = "includes=country;cities;")
            => await base.GetAll<AllRegionsResponse, Region>(
                endpointPart: "core/regions",
                parametersPart: parametersPart
                );
        public async Task<RegionResponse?> GetRegionById(string regionId, string parametersPart = "includes=country;cities;")
            => await base.GetSingle<RegionResponse>(
                endpointPart: $"core/regions/{regionId}"
                );
    }

    #region Models

    public class AllRegionsResponse : ListResponse<Region>
    {
    }

    public class RegionResponse : SingleResponse<Region>
    {
    }

    #endregion
}
