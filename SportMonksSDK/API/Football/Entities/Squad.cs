namespace SportMonksSDK.API.Football.Entities
{
    public class Squad
    {
        public int id { get; set; }
        public int? transfer_id { get; set; }
        public Transfer transfer { get; set; }
        public int? player_id { get; set; }
        public Player player { get; set; }
        public int? team_id { get; set; }
        public Team team { get; set; }
        public int? position_id { get; set; }
        public int? detailed_position_id { get; set; }
        public string? start { get; set; }
        public string? end { get; set; }
        public bool? captain { get; set; }
        public int? jersey_number { get; set; }
    }
}
