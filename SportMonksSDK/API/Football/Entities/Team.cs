using SportMonksSDK.API.Core.Entities;

namespace SportMonksSDK.API.Football.Entities
{
    public class Team
    {
        public int? id { get; set; }
        public int? sport_id { get; set; }
        public Sport sport { get; set; }
        public int? country_id { get; set; }
        public Country country { get; set; }
        public int? venue_id { get; set; }
        public Venue venue { get; set; }
        public string? gender { get; set; }
        public string? name { get; set; }
        public string? short_code { get; set; }
        public string? image_path { get; set; }
        public int? founded { get; set; }
        public string? type { get; set; }
        public bool? placeholder { get; set; }
        public string? last_played_at { get; set; }
        public TeamMeta? meta { get; set; }
        public List<Season> seasons { get; set; } = [];
        public List<Player> players { get; set; } = [];
        public List<Coach> coaches { get; set; } = [];
    }

    public class TeamMeta
    {
        public string? location { get; set; }
        public string? winner { get; set; }
        public int? position { get; set; }
    }
}
