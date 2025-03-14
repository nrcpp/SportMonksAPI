namespace SportMonksSDK.API.Football.Entities
{
    public class Aggregate
    {
        public int id { get; set; }
        public int? league_id { get; set; }
        public int? season_id { get; set; }
        public int? stage_id { get; set; }
        public string? name { get; set; }
        public int[]? fixture_ids { get; set; }
        public string? result { get; set; }
        public string? detail { get; set; }
        public int? winner_participant_id { get; set; }
    }
}
