using SportMonksSDK.API.Core.Entities;

namespace SportMonksSDK.API.Football.Entities
{
    public class Venue
    {
        public int id { get; set; }
        public int? country_id { get; set; }
        public Country country { get; set; }
        public string? name { get; set; }
        public string? address { get; set; }
        public string? zipcode { get; set; }
        public string? state { get; set; }
        public string? latitude { get; set; }
        public string? longitude { get; set; }
        public int? capacity { get; set; }
        public string? image_path { get; set; }
        public string? city_name { get; set; }
        public string? surface { get; set; }
        public bool? national_team { get; set; }
        public City city { get; set; }
        public List<Fixture> fixtures { get; set; } = [];
    }
}
