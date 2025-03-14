using SportMonksSDK.API.Core.Entities;

namespace SportMonksSDK.API.Football.Entities
{
    public class League
    {
        public int id { get; set; }
        public int? sport_id { get; set; }
        public Sport sport { get; set; }
        public int? country_id { get; set; }
        public Country country { get; set; }
        public string? name { get; set; }
        public bool? active { get; set; }
        public string? short_code { get; set; }
        public string? image_path { get; set; }
        public string? type { get; set; }
        public string? sub_type { get; set; }
        public string? last_played_at { get; set; }
        public List<Season> seasons { get; set; } = [];
        public List<Stage> stages { get; set; } = [];
    }
}
