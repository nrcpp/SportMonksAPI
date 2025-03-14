using SportMonksSDK.API.Core.Entities;

namespace SportMonksSDK.API.Football.Entities
{
    public class Schedule
    {
        public int id { get; set; }
        public int? sport_id { get; set; }
        public Sport sport { get; set; }
        public int? league_id { get; set; }
        public League league { get; set; }
        public int? season_id { get; set; }
        public Season season { get; set; }
        public int? type_id { get; set; }
        public string? name { get; set; }
        public bool? finished { get; set; }
        public bool? is_current { get; set; }
        public string? starting_at { get; set; }
        public string? ending_at { get; set; }
        public bool? games_in_current_week { get; set; }
        public int? tie_breaker_rule_id { get; set; }
        public List<Round> Rounds { get; set; } = [];
    }
}
