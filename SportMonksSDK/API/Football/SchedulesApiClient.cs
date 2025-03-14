using SportMonksSDK.API.Football.Entities;

namespace SportMonksSDK.API.Football
{
    public class SchedulesApiClient : BaseApiClient
    {
        public async Task<AllSchedulesBySeasonIdResponse?> GetAllSchedulesBySeasonId(int seasonId, string parametersPart = "filters=populate")
            => await GetAll<AllSchedulesBySeasonIdResponse, Schedule>(
                endpointPart: $"football/schedules/seasons/{seasonId}",
                parametersPart: parametersPart
                );
        public async Task<AllSchedulesByTeamIdResponse?> GetAllSchedulesByTeamId(int teamId, string parametersPart = "filters=populate")
            => await GetAll<AllSchedulesByTeamIdResponse, Schedule>(
                endpointPart: $"football/schedules/teams/{teamId}",
                parametersPart: parametersPart
                );
    }

    #region Models

    public class AllSchedulesBySeasonIdResponse : ListResponse<Schedule>
    {

    }

    public class AllSchedulesByTeamIdResponse : ListResponse<Schedule>
    {
    }
    #endregion
}