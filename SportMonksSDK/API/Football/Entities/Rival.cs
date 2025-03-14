using SportMonksSDK.API.Core.Entities;

namespace SportMonksSDK.API.Football.Entities
{
    public class Rival
    {
        public int id { get; set; }
        public int? sport_id { get; set; }
        public Sport sport { get; set; }
        public int? team_id { get; set; }
        public Team team { get; set; }
        public int? rival_id { get; set; }
    }
}
