namespace SportMonksSDK.API.Football.Entities
{
    public class TeamStatistic
    {
        public int id { get; set; }
        public int? team_id { get; set; }
        public int? season_id { get; set; }
        public bool? has_values { get; set; }
    }
}
