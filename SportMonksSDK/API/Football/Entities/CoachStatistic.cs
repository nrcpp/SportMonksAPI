using System.Text.Json;

namespace SportMonksSDK.API.Football.Entities
{
    public class CoachStatistic
    {
        public int id { get; set; }
        public int? coach_id { get; set; }
        public int? team_id { get; set; }
        public int? season_id { get; set; }
        public bool? has_values { get; set; }
        public List<StatisticDetail>? details { get; set; }
    }

    // shared by Player/Team/Coach/Referee statistics; "value" shape varies wildly per type_id
    // (e.g. {total}, {in,out}, {count,average}, nested {all:{count,...},home:{...}}, or even a
    // bare string like {value:"6.94"}) so it is captured as a raw JsonElement and read on demand
    // via GetProperty/TryGetProperty, mirroring the Iteration 3 StatisticDataSm pattern.
    public class StatisticDetail
    {
        public int id { get; set; }
        public int? type_id { get; set; }
        public JsonElement value { get; set; }
    }
}
