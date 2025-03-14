namespace SportMonksSDK.API.Core.Entities
{
    public class Continent
    {
        public int id { get; set; }
        public string? name { get; set; }
        public string? code { get; set; }
        public List<Country> countries { get; set; } = [];
    }
}
