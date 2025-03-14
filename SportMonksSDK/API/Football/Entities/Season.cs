using SportMonksSDK.API.Core.Entities;

namespace SportMonksSDK.API.Football.Entities
{
    public class Season
    {
        public int id { get; set; }
        public int? sport_id { get; set; }
        public Sport sport { get; set; }
        public int? league_id { get; set; }
        public League league { get; set; }
        public int? tie_breaker_rule_id { get; set; }
        public string? name { get; set; }
        public bool? finished { get; set; }
        public bool? pending { get; set; }
        public bool? is_current { get; set; }
        public string? standing_method { get; set; }
        public string? starting_at { get; set; }
        public string? ending_at { get; set; }
        public List<Team> teams { get; set; } = [];
        public List<Stage> stages { get; set; } = [];
        public List<Fixture> fixtures { get; set; } = [];
        public List<Group> groups { get; set; } = [];
        public List<TopScorer> topscorers { get; set; } = [];
    }
}
