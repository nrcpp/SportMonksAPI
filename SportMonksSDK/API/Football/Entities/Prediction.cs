namespace SportMonksSDK.API.Football.Entities
{
    public class PredictionParent
    {
        public int id { get; set; }
        public int? fixture_id { get; set; }
        public Fixture fixture { get; set; }
        // shape varies by type_id (e.g. yes/no, home/away/draw, home_home/home_away/...)
        public Dictionary<string, double>? predictions { get; set; }
        public int? type_id { get; set; }
    }
}
