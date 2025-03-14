using SportMonksSDK.API.Core.Entities;

namespace SportMonksSDK.API.Football.Entities
{
    public class Participant
    {
        public int id { get; set; }
        public int? sport_id { get; set; }
        public int? country_id { get; set; }
        public int? venue_id { get; set; }
        public string? gender { get; set; }
        public string? name { get; set; }
        public string? short_code { get; set; }
        public string? image_path { get; set; }
        public Venue venue { get; set; }
        public Sport sport { get; set; }
    }
}
