namespace SportMonksSDK.API.Football.Entities
{
    public class Group
    {
        public int id { get; set; }
        public int? sport_id { get; set; }
        public int? league_id { get; set; }
        public int? season_id { get; set; }
        public int? stage_id { get; set; }
        public string? name { get; set; }
        public string? starting_at { get; set; }
        public string? ending_at { get; set; }
    }
}
