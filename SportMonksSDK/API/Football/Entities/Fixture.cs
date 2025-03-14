using SportMonksSDK.API.Core.Entities;

namespace SportMonksSDK.API.Football.Entities
{
    public class Fixture
    {
        public int id { get; set; }
        public int? sport_id { get; set; }
        public Sport? sport { get; set; }
        public int? league_id { get; set; }
        public League? league { get; set; }
        public int? season_id { get; set; }
        public Season? season { get; set; }
        public int? stage_id { get; set; }
        public Stage? stage { get; set; }
        public int? group_id { get; set; }
        public Group? group { get; set; }
        public int? aggregate_id { get; set; }
        public Aggregate? aggregate { get; set; }
        public int? state_id { get; set; }
        public State state { get; set; }
        public int? round_id { get; set; }
        public Round round { get; set; }
        public int? venue_id { get; set; }
        public Venue venue { get; set; }
        public string? name { get; set; }
        public string? starting_at { get; set; }
        public string? result_info { get; set; }
        public string? leg { get; set; }
        public string? details { get; set; }
        public int? length { get; set; }
        public bool? has_odds { get; set; }
        public bool? has_premium_odds { get; set; }
        public long? starting_at_timestamp { get; set; }
        public List<Participant>? participants { get; set; } = [];
        public List<ScoreParent>? scores { get; set; } = [];
        public List<Coach> coaches { get; set; } = [];
        public List<Referee> referees { get; set; } = [];
    }
}
