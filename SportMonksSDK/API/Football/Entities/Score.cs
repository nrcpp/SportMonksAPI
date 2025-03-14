using Type = SportMonksSDK.API.Core.Entities.Type;

namespace SportMonksSDK.API.Football.Entities
{
    public class ScoreParent
    {
        public int? id { get; set; }
        public int? fixture_id { get; set; }
        public int? type_id { get; set; }
        public int? participant_id { get; set; }
        public ScoreChild? score { get; set; }
        public string? description { get; set; }
        public Fixture fixture { get; set; }
        public Type type { get; set; }
    }

    public class ScoreChild
    {
        public int? goals { get; set; }
        public string? participant { get; set; }
    }
}
