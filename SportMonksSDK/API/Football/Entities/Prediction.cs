using System.Text.Json;

namespace SportMonksSDK.API.Football.Entities
{
    public class PredictionParent
    {
        public int id { get; set; }
        public int? fixture_id { get; set; }
        public Fixture fixture { get; set; }
        // Shape varies by type_id: usually a flat map of selection label -> probability percentage
        // (e.g. yes/no, home/away/draw, home_home/home_away/...), but some type_ids (e.g. the
        // correct-score distribution) nest a further object under a key (e.g. "scores"). Captured
        // as JsonElement values so both shapes deserialize safely; flat numeric entries are used,
        // nested-object entries are skipped (see epl-seed-iteration-4-summary.md).
        public Dictionary<string, JsonElement>? predictions { get; set; }
        public int? type_id { get; set; }
    }
}
