namespace SportMonksSDK.API.Football.Entities
{
    public class TeamSquad
    {
        public int id { get; set; }
        public int? transfer_id { get; set; }
        public int player_id { get; set; }
        public int? team_id { get; set; }
        public int? position_id { get; set; }
        public int? detailed_position_id { get; set; }
        public int? jersey_number { get; set; }
        public string? start { get; set; }
        public string? end { get; set; }
    }
}
