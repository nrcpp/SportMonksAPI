namespace SportMonksSDK.API.Football.Entities
{
    public class PremiumOdd
    {
        public int id { get; set; }
        public int? fixtureId { get; set; }
        public Fixture fixture { get; set; }
        public int? marketId { get; set; }
        public Market market { get; set; }
        public int? bookmaker_id { get; set; }
        public Bookmaker bookmaker { get; set; }
        public string? label { get; set; }
        public string? value { get; set; }
        public string? name { get; set; }
        public string? market_description { get; set; }
        public string? probability { get; set; }
        public string? dp3 { get; set; }
        public string? fractional { get; set; }
        public string? american { get; set; }
        public bool? stopped { get; set; }
        public string? total { get; set; }
        public string? handicap { get; set; }
        public string? latest_bookmaker_update { get; set; }
    }
}
