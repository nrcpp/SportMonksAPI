namespace SportMonksSDK.API.Football.Entities
{
    public class CoachStatistic
    {
        public int id { get; set; }
        public int? coach_id { get; set; }
        public int? team_id { get; set; }
        public int? season_id { get; set; }
    }
}
