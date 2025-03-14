using SportMonksSDK.API.Core.Entities;

namespace SportMonksSDK.API.Football.Entities
{
    public class Round
    {
        public int id { get; set; }
        public int? sport_id { get; set; }
        public Sport sport { get; set; }
        public int? league_id { get; set; }
        public League league { get; set; }
        public int? season_id { get; set; }
        public Season season { get; set; }
        public int? group_id { get; set; }
        public Group group { get; set; }
        public string? name { get; set; }
        public bool? finished { get; set; }
        public bool? pending { get; set; }
        public bool? is_current { get; set; }
        public string? starting_at { get; set; }
        public string? ending_at { get; set; }
        public List<Fixture>? Fixtures { get; set; } = [];
    }
}
