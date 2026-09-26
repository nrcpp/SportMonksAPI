using SportMonksSDK.API.Core.Entities;

namespace SportMonksSDK.API.Football.Entities
{
    public class Standing
    {
        public int id { get; set; }
        public int? participant_id { get; set; }
        public Participant participant { get; set; }
        public int? sport_id { get; set; }
        public Sport sport { get; set; }
        public int? league_id { get; set; }
        public League league { get; set; }
        public int? season_id { get; set; }
        public Season season { get; set; }
        public int? stage_id { get; set; }
        public Stage stage { get; set; }
        public int? group_id { get; set; }
        public Group group { get; set; }
        public int? round_id { get; set; }
        public Round round { get; set; }
        public int? standing_rule_id { get; set; }
        public int? position { get; set; }
        public string? result { get; set; }
        public int? points { get; set; }
        // Per-metric breakdown (played/won/goals-for/home-away splits/...); keyed by `type.developer_name`,
        // NOT by array order - real payload order is not a stable contract.
        public List<StandingDetail>? details { get; set; }
    }

    public class StandingDetail
    {
        public long id { get; set; }
        public string? standing_type { get; set; }
        public long? standing_id { get; set; }
        public int? type_id { get; set; }
        public double? value { get; set; }
        public StandingDetailType? type { get; set; }
    }

    public class StandingDetailType
    {
        public int id { get; set; }
        public string? name { get; set; }
        public string? code { get; set; }
        public string? developer_name { get; set; }
        public string? model_type { get; set; }
        public string? stat_group { get; set; }
    }
}
