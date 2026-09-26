namespace SportMonksSDK.API.Football.Entities
{
    public class RefereeStatistic
    {
        public int id { get; set; }
        public int? referee_id { get; set; }
        public int? season_id { get; set; }
        public bool? has_values { get; set; }
        public List<StatisticDetail>? details { get; set; }
    }
}
