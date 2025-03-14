namespace SportMonksSDK.API.Football.Entities
{
    public class PredictionParent
    {
        public int id { get; set; }
        public int? fixture_id { get; set; }
        public Fixture fixture { get; set; }
        public PredictionChild predictions { get; set; }
        public int? type_id { get; set; }
    }

    public class PredictionChild
    {
        public double? yes { get; set; }
        public double? no { get; set; }
    }
}
