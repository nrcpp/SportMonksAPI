namespace SportMonksSDK.API.Core.Entities
{
    public class City
    {
        public int id { get; set; }
        public int? country_id { get; set; }
        public int? region_id { get; set; }
        public Region region { get; set; }
        public string? name { get; set; }
        public string? latitude { get; set; }
        public string? longitude { get; set; }
    }
}
