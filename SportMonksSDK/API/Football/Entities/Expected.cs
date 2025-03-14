namespace SportMonksSDK.API.Football.Entities
{
    public class Expected
    {
        public int id { get; set; }
        public int? fixture_id { get; set; }
        public Fixture fixture { get; set; }
        public int? type_id { get; set; }
        public int? value { get; set; }
        public Participant participant { get; set; }
        public Player player { get; set; }
        public Team team { get; set; }
    }
}
