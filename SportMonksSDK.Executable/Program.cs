using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using SportMonksSDK.API.Core;
using SportMonksSDK.API.Football;

namespace SportMonksSDK.Executable
{
    // Put test methods in this file

    // API Documentation
    // https://docs.sportmonks.com/football 
    // https://docs.sportmonks.com/football/endpoints-and-entities/entities - API entities 

    // API Tester
    // https://my.sportmonks.com/api/tester

    // Postman Collection(run locally or test onsite)
    // https://postman.sportmonks.com/ 

    
    public class Program
    {
        static async Task Main(string[] args)
        {
            var host = Host.CreateDefaultBuilder(args)
                .ConfigureAppConfiguration((context, config) =>
                {
                    config.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
                })
                .ConfigureServices((context, services) =>
                {
   
                })
                .ConfigureLogging(logging =>
                {
                    logging.ClearProviders();
                    logging.AddConsole();
                })
                .Build();

            // var getAllFixturesResponse = await new FixturesApiClient().GetAllFixtures();
            // var getFixtureByIdResponse = await new FixturesApiClient().GetFixtureById("18862080");
            // var getFixtureByDateResponse = await new FixturesApiClient().GetFixturesByDate("2024-02-18");
            // var getAllStatesResponse = await new StatesApiClient().GetAllStates();
            // var getStateByIdResponse = await new StatesApiClient().GetStateById("1");
            // var getAllLeaguesResponse = await new LeaguesApiClient().GetAllLeagues();
            // var getLeagueByIdResponse = await new LeaguesApiClient().GetLeagueById("271");
            // var getAllSeasonsResponse = await new SeasonsApiClient().GetAllSeasons();
            // var getSeasonByIdResponse = await new SeasonsApiClient().GetSeasonById("759");
            // var getAllTeamsResponse = await new TeamsApiClient().GetAllTeams();
            // var getTeamByIdResponse = await new TeamsApiClient().GetTeamById("53");
            // var getAllCoachesResponse = await new CoachesApiClient().GetAllCoaches();
            // var getCoachByIdResponse = await new CoachesApiClient().GetCoachById("50");
            // var getTeamSquadByTeamId = await new TeamSquadsApiClient().GetAllTeamSquads("53");
            // var getTeamSquadByTeamIdExtended = await new TeamSquadsApiClient().GetAllTeamSquadsExtended("53");
            // var getAllRefereesResponse = await new RefereesApiClient().GetAllReferees();
            // var getRefereeByIdResponse = await new RefereesApiClient().GetRefereeById("37");
            // var getAllStagesResponse = await new StagesApiClient().GetAllStages();
            // var getStageByIdResponse = await new StagesApiClient().GetStageById("1086");
            // var getAllRoundsResponse = await new RoundsApiClient().GetAllRounds();
            // var getRoundByIdResponse = await new RoundsApiClient().GetRoundById("23317");
            // var getAllLivescores = await new LivescoresApiClient().GetAllLivescores();
            // var getAllSeasonPlayerStatisticsResponse = await new StatisticsApiClient().GetAllSeasonPlayerStatisticsResponse("8"); // null data
            // var getAllStandingsResponse = await new StandigsApiClient().GetAllStandings();
            // var getAllLiveStandingsResponse = await new LiveStandingsApiClient().GetAllLiveStandingsByLeagueId("19686");
            // var getAllSchedulesBySeasonIdResponse = await new SchedulesApiClient().GetAllSchedulesBySeasonId(759);
            // var getAllSchedulesByTeamIdResponse = await new SchedulesApiClient().GetAllSchedulesByTeamId(53);
            // var getAllVenuesResponse = await new VenueApiClient().GetAllVenues();
            // var getVenueByIdResponse = await new VenueApiClient().GetVenueById("219");
            // var getAllSquadsByTeamIdResponse = await new SquadsApiClient().GetAllSquadsByTeamId("53");
            // var getAllSquadsBySeasonAndTeamIdResponse = await new SquadsApiClient().GetAllSquadsBySeasonAndTeamId("21787", "53");
            // var getAllTopScorersByStageIdResponse = await new TopScorersApiClient().GetAllTopScorersByStageId("1100");
            // var getAllTopScorersBySeasonIdResponse = await new TopScorersApiClient().GetAllTopScorersBySeasonId("19686");
            // var getAllRivalsResponse = await new RivalsApiClient().GetAllRivals();
            // var getAllRivalsByTeamIdResponse = await new RivalsApiClient().GetAllRivalsByTeamId("53");
            // var getAllCommentariesResponse = await new CommentariesApiClient().GetAllCommentaries();
            // var getAllCommentariesByFixtureIdResponse = await new CommentariesApiClient().GetAllCommentariesByFixtureId("18538011");
            // var getAllTransferResponse = await new TransferApiClient().GetAllTransfers();
            // var getTransferByIdResponse = await new TransferApiClient().GetTransferById("112");
            // // var getAllPredictionsResponse = await new PredictionsApiClient().GetAllPredictions(); // 403 Forbidden
            // // var getPredictionByFixtureIdResponse = await new PredictionsApiClient().GetAllPredictionsByFixtureId("16774022"); // 403 Forbidden
            // var getAllContinentsResponse = await new ContinentsApiClient().GetAllContinents();
            // var getContinentByIdResponse = await new ContinentsApiClient().GetContinentById("1");
            // var getAllRegionsResponse = await new RegionsApiClient().GetAllRegions();
            // var getRegionByIdResponse = await new RegionsApiClient().GetRegionById("1");
            // var getAllCitiesResponse = await new CitiesApiClient().GetAllCities();
            // var getCityByIdResponse = await new CitiesApiClient().GetCityById("1");
            // var getAllTypesResponse = await new TypesApiClient().GetAllTypes();
            // var getTypeByIdResponse = await new TypesApiClient().GetTypeById("5");
            // var getAllTimezonesResponse = await new TimezonesApiClient().GetAllTimezones();
            // var getAllPlayersResponse = await new PlayersApiClient().GetAllPlayers();
            // var getPlayerByIdResponse = await new PlayersApiClient().GetPlayerById("14");
            // var getAllMarketsResponse = await new MarketsApiClient().GetAllMarkets();
            // var getMarketByIdResponse = await new MarketsApiClient().GetMarketById("1");
            // var getAllBookmakersResponse = await new BookmakersApiClient().GetAllBookmakers();
            // var getBookmakerByIdResponse = await new BookmakersApiClient().GetBookmakerById("1");
            // var getAllExpectationsByTeamResponse = await new ExpectationsApiClient().GetExpectationsByTeam(); // 403 forbidden
            // var getAllExpectationsByPlayerResponse = await new ExpectationsApiClient().GetExpectationsByPlayer(); // 403 forbidden
            // var getAllPremiumOddsResponse = await new PremiumOddsApiClient().GetAllPremiumOdds(); // 403 forbidden
            // var getAllPremiumOddsByFixtureIdResponse = await new PremiumOddsApiClient().GetAllPremiumOddsByFixtureId("18862080"); // 403 forbidden
            await host.RunAsync();
        }

        static void TestCountries()
        {
            var ac = new CountriesApiClient();
            //var response1 = ac.All().Result ?? new();


            //foreach (var item in response.data)
            //    Console.WriteLine(item.name);


            var r2 = ac.ByID(2).Result;     // poland
            var r3 = ac.Search("united").Result;

            Console.WriteLine(r2.data);
            Console.WriteLine(r3.data.Count());

            Console.ReadKey();
        }


        static void TestContinents()
        {

        }
    }
}
