using System.Text.Json;
using SportMonksSDK.API.Core.Entities;
using Type = SportMonksSDK.API.Core.Entities.Type;

namespace SportMonksSDK.API.Football.Entities
{
    public class Fixture
    {
        public int id { get; set; }
        public int? sport_id { get; set; }
        public Sport? sport { get; set; }
        public int? league_id { get; set; }
        public League? league { get; set; }
        public int? season_id { get; set; }
        public Season? season { get; set; }
        public int? stage_id { get; set; }
        public Stage? stage { get; set; }
        public int? group_id { get; set; }
        public Group? group { get; set; }
        public int? aggregate_id { get; set; }
        public Aggregate? aggregate { get; set; }
        public int? state_id { get; set; }
        public State state { get; set; }
        public int? round_id { get; set; }
        public Round round { get; set; }
        public int? venue_id { get; set; }
        public Venue venue { get; set; }
        public string? name { get; set; }
        public string? starting_at { get; set; }
        public string? result_info { get; set; }
        public string? leg { get; set; }
        public string? details { get; set; }
        public int? length { get; set; }
        public bool? has_odds { get; set; }
        public bool? has_premium_odds { get; set; }
        public long? starting_at_timestamp { get; set; }
        public List<Participant>? participants { get; set; } = [];
        public List<ScoreParent>? scores { get; set; } = [];
        public List<Coach> coaches { get; set; } = [];
        public List<FixtureReferee> referees { get; set; } = [];

        // Iteration 3 (match detail): events / lineups / fixture-level statistics / xG / pressure.
        // Include string used: "include=participants;scores;events.type;lineups.details.type;statistics.type;xGFixture;pressure"
        public List<MatchEventSm>? events { get; set; } = [];
        public List<MatchLineupSm>? lineups { get; set; } = [];
        public List<FixtureStatisticSm>? statistics { get; set; } = [];
        // NOTE: real JSON key is lowercase "xgfixture" despite the include param being "xGFixture".
        public List<XgFixtureItemSm>? xgfixture { get; set; } = [];
        public List<PressurePointSm>? pressure { get; set; } = [];

        // Iteration 4: per-team formation, from the "formations" include (added to detailInclude
        // alongside coaches/referees).
        public List<FixtureFormationSm>? formations { get; set; } = [];
    }

    // fixture-level referee assignment; NOT the full Referee profile (see RefereesApiClient for that)
    public class FixtureReferee
    {
        public int id { get; set; }
        public int? fixture_id { get; set; }
        public int? referee_id { get; set; }
        public int? type_id { get; set; }
    }

    // per-team formation for one fixture, from the "formations" include.
    public class FixtureFormationSm
    {
        public long id { get; set; }
        public int? fixture_id { get; set; }
        public int? participant_id { get; set; }
        public string? formation { get; set; }
        public string? location { get; set; }
    }

    /// <summary>A single match event (goal/card/substitution/VAR/...), from `events.type` include.</summary>
    public class MatchEventSm
    {
        public long id { get; set; }
        public int? fixture_id { get; set; }
        public int? period_id { get; set; }
        public int? participant_id { get; set; }
        public int? type_id { get; set; }
        public string? section { get; set; }
        public int? player_id { get; set; }
        public int? related_player_id { get; set; }
        public string? player_name { get; set; }
        public string? related_player_name { get; set; }
        public string? result { get; set; }
        public string? info { get; set; }
        public string? addition { get; set; }
        public int? minute { get; set; }
        public int? extra_minute { get; set; }
        public bool? injured { get; set; }
        public bool? on_bench { get; set; }
        public int? coach_id { get; set; }
        public int? sub_type_id { get; set; }
        public int? detailed_period_id { get; set; }
        public bool? rescinded { get; set; }
        public int? sort_order { get; set; }
        public Type? type { get; set; }
    }

    /// <summary>A single row of `data: { value }`, shared by lineup details, fixture statistics and xG items.</summary>
    public class StatisticDataSm
    {
        public JsonElement value { get; set; }
    }

    /// <summary>One player's lineup entry (starting XI or bench), from `lineups.details.type` include.</summary>
    public class MatchLineupSm
    {
        public long id { get; set; }
        public int? sport_id { get; set; }
        public int? fixture_id { get; set; }
        public int? player_id { get; set; }
        public int? team_id { get; set; }
        public int? position_id { get; set; }
        public string? formation_field { get; set; }
        // type_id 11 = starting lineup, 12 = bench (inferred from real data: exactly 11 rows with
        // type_id 11 per team, matching a starting XI; see Sportmonks_Docs/output/sportmonks_responses.md).
        public int? type_id { get; set; }
        public int? formation_position { get; set; }
        public string? player_name { get; set; }
        public int? jersey_number { get; set; }
        public List<MatchLineupDetailSm>? details { get; set; } = [];
    }

    /// <summary>A single per-player match statistic (rating, minutes played, passes, ...).</summary>
    public class MatchLineupDetailSm
    {
        public long id { get; set; }
        public int? fixture_id { get; set; }
        public int? player_id { get; set; }
        public int? team_id { get; set; }
        public long? lineup_id { get; set; }
        public int? type_id { get; set; }
        public StatisticDataSm? data { get; set; }
        public Type? type { get; set; }
    }

    /// <summary>A single fixture-level, per-team statistic (corners, possession, shots, ...).</summary>
    public class FixtureStatisticSm
    {
        public long id { get; set; }
        public int? fixture_id { get; set; }
        public int? type_id { get; set; }
        public int? participant_id { get; set; }
        public StatisticDataSm? data { get; set; }
        public string? location { get; set; }
        public Type? type { get; set; }
    }

    /// <summary>
    /// A single xG-model value for one team. Real JSON has no nested `type` object (unlike
    /// `statistics`), so `type_id` must be resolved against the full `core/types` catalog to know
    /// which xG variant it is (e.g. developer_name "EXPECTED_GOALS" vs "EXPECTED_GOALS_ON_TARGET").
    /// </summary>
    public class XgFixtureItemSm
    {
        public long id { get; set; }
        public int? fixture_id { get; set; }
        public int? type_id { get; set; }
        public int? participant_id { get; set; }
        public StatisticDataSm? data { get; set; }
        public string? location { get; set; }
    }

    /// <summary>A single per-minute pressure-index reading for one team.</summary>
    public class PressurePointSm
    {
        public long id { get; set; }
        public int? fixture_id { get; set; }
        public int? participant_id { get; set; }
        public int? minute { get; set; }
        public double? pressure { get; set; }
    }
}
