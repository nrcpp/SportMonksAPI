namespace SportMonksSDK.API.Football.Entities
{
    public class CoachStatistic
    {
        public int id { get; set; }
        public int? coach_id { get; set; }
        public int? team_id { get; set; }
        public int? season_id { get; set; }
        public bool? has_values { get; set; }
        public List<StatisticDetail>? details { get; set; }
    }

    // shared by Player/Team/Coach/Referee statistics; "value" shape varies per type_id
    // (e.g. {total}, {in,out}, {count,average}) so it is captured as a flexible dictionary
    public class StatisticDetail
    {
        public int id { get; set; }
        public int? type_id { get; set; }
        public Dictionary<string, double>? value { get; set; }
    }
}
