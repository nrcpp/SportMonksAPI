namespace SportMonksSDK.API.Football.Entities
{
    public class Commentary
    {
        public int id { get; set; }
        public int? fixture_id { get; set; }
        public Fixture fixture { get; set; }
        public string? comment { get; set; }
        public int? minute { get; set; }
        public int? extra_minute { get; set; }
        public bool? is_goal { get; set; }
        public bool? is_important { get; set; }
        public int? order { get; set; }
        public Player player { get; set; }
    }
}
