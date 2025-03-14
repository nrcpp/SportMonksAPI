using SportMonksSDK.API.Core.Entities;
using Type = SportMonksSDK.API.Core.Entities.Type;

namespace SportMonksSDK.API.Football.Entities
{
    public class Player
    {
        public int? id { get; set; }
        public int? sport_id { get; set; }
        public Sport sport { get; set; }
        public int? country_id { get; set; }
        public Country country { get; set; }
        public int? nationality_id { get; set; }
        public int? city_id { get; set; }
        public City city { get; set; }
        public int? position_id { get; set; }
        public int? detailed_position_id { get; set; }
        public int? type_id { get; set; }
        public Type type { get; set; }
        public string? common_name { get; set; }
        public string? first_name { get; set; }
        public string? last_name { get; set; }
        public string? name { get; set; }
        public string display_name { get; set; }
        public string? image_path { get; set; }
        public double? height { get; set; }
        public double? weight { get; set; }
        public string? date_of_birth { get; set; }
        public string? gender { get; set; }
    }
}
