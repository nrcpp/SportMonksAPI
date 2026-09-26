using SportMonksSDK.API.Core.Entities;

namespace SportMonksSDK.API.Football.Entities
{
    public class Coach
    {
        public int id { get; set; }
        public int? player_id { get; set; }
        public Player player { get; set; }
        public int? sport_id { get; set; }
        public Sport sport { get; set; }
        public int? country_id { get; set; }
        public Country country { get; set; }
        public int? nationality_id { get; set; }
        public int? city_id { get; set; }
        public string? common_name { get; set; }
        public string? firstname { get; set; }
        public string? lastname { get; set; }
        public string? name { get; set; }
        public string display_name { get; set; }
        public string? image_path { get; set; }
        public double? height { get; set; }
        public double? weight { get; set; }
        public string? date_of_birth { get; set; }
        public string? gender { get; set; }
        public CoachMeta? meta { get; set; }
        public List<Fixture> fixtures { get; set; } = [];
    }

    // present only when a Coach is nested under Fixture.coaches
    public class CoachMeta
    {
        public int? fixture_id { get; set; }
        public int? coach_id { get; set; }
        public int? participant_id { get; set; }
    }
}
