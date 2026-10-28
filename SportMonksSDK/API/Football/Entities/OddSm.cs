namespace SportMonksSDK.API.Football.Entities
{
    /// <summary>
    /// A single pre-match odds row from "football/odds/pre-match/fixtures/{fixtureId}/bookmakers/{bookmakerId}".
    /// Real response fields captured as-is; `value`/`probability` are strings on the wire.
    /// </summary>
    public class OddSm
    {
        public long id { get; set; }
        public int? fixture_id { get; set; }
        public int? market_id { get; set; }
        public int? bookmaker_id { get; set; }
        public string? label { get; set; }
        public string? value { get; set; }
        public string? name { get; set; }
        public int? sort_order { get; set; }
        public string? market_description { get; set; }
        public string? probability { get; set; }
        public string? dp3 { get; set; }
        public string? fractional { get; set; }
        public string? american { get; set; }
        public bool? winning { get; set; }
        public bool? stopped { get; set; }
        public string? total { get; set; }
        public string? handicap { get; set; }
        public string? participants { get; set; }
        public string? created_at { get; set; }
        public string? original_label { get; set; }
        public string? latest_bookmaker_update { get; set; }
    }
}
