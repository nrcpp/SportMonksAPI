namespace SportMonksSDK.API.Football.Entities
{
    public class TopScorer
    {
        public int id { get; set; }
        public int? season_id { get; set; }
        public int? stage_id { get; set; }
        public int? player_id { get; set; }
        public int? type_id { get; set; }
        public int? position { get; set; }
        public int? total { get; set; }
        public string? participant_type { get; set; }
        public int? participant_id { get; set; }
    }
}
