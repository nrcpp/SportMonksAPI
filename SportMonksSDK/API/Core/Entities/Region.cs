namespace SportMonksSDK.API.Core.Entities
{
    public class Region
    {
        public int id { get; set; }
        public int? country_id { get; set; }
        public Country country { get; set; }
        public string? name { get; set; }
        public List<City> cities { get; set; } = [];
    }
}
