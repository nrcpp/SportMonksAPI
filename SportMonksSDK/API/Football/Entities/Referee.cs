using SportMonksSDK.API.Core.Entities;

namespace SportMonksSDK.API.Football.Entities
{
    public class Referee
    {
        public int id { get; set; }
        public int? sport_id { get; set; }
        public Sport sport { get; set; }
        public int? country_id { get; set; }
        public Country country { get; set; }
        public int? nationality_id { get; set; }
        public string? city_id { get; set; }
        public City city { get; set; }
        public string? common_name { get; set; }
        public string? firstname { get; set; }
        public string? lastname { get; set; }
        public string? name { get; set; }
        public string? display_name { get; set; }
        public string? image_path { get; set; }
        public double? height { get; set; }
        public double? weight { get; set; }
        public string? date_of_birth { get; set; }
        public string? gender { get; set; }
    }
}
