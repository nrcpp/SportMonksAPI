using System.Text.Json;

namespace SportMonksSDK;

public class BaseApiClient : IDisposable
{
    public readonly string apiKey = "";        // put your SportMonks API key here 
    public const string baseUrl = "api.sportmonks.com";
    public const string version = "v3";
    public const int maxAllRecords = int.MaxValue;

    protected HttpClient _httpClient;

    
    public BaseApiClient()
    {
        if (apiKey?.Length < 5 && File.Exists("token.txt"))
            apiKey = File.ReadAllText("token.txt");         // for debugging purposes

        if (string.IsNullOrWhiteSpace(apiKey))
            throw new InvalidOperationException("SportMonkns API Key not set. Go to https://my.sportmonks.com/api/tokens");


        _httpClient = new HttpClient();
        _httpClient.BaseAddress = new Uri($"https://{baseUrl}/");

        _httpClient.DefaultRequestHeaders.Add($"Authorization", apiKey);   
    }




    // Returns response with list of objects
    // Example of ResponseType - AllContriesResponse  which is derived from ListResponse<CountryData>
    public async Task<ResponseType> GetAll<ResponseType, DataType>(string endpointPart,
                               string parametersPart,        // include, filters, fields etc.
                                                             // https://docs.sportmonks.com/football/api/request-options/includes
                                                             // https://docs.sportmonks.com/football/api/request-options/filtering
                                                             // https://docs.sportmonks.com/football/api/request-options/selecting-fields
                               int pageStart = 1,            // https://docs.sportmonks.com/football/endpoints-and-entities/endpoints/fixtures/get-all-fixtures#pagination
                               int pageEnd = int.MaxValue)  
                                        
                            where ResponseType : ListResponse<DataType>
                            where DataType : class
    {
        ResponseType result = null;

        int pageNum = pageStart;
        while (true)
        {
            string fullEndpoint = $"{version}/{endpointPart}?&page={pageNum}";

            if (!string.IsNullOrWhiteSpace(parametersPart)) fullEndpoint += '&' + parametersPart;
            
            var response = await _httpClient.GetAsync(fullEndpoint);     // e.g. v3/core/countries
            response.EnsureSuccessStatusCode();

            var responseContent = await response.Content.ReadAsStreamAsync();
            // using (var reader = new StreamReader(responseContent))
            // {
            //     var responseString = await reader.ReadToEndAsync();
            // }
            var responseObj = (await JsonSerializer.DeserializeAsync<ResponseType>(responseContent));       // ListResponse

            if (result == null)
                result = responseObj;

            else
            {
                result.data.AddRange(responseObj.data);
            }

            if (responseObj?.pagination?.has_more != true)
                break;

            if (pageNum == pageEnd)     // break on last page passed in parameters
                break;

            pageNum++;
        }

        return result;
    }



    /// <summary>
    /// Returns single object (usually by ID)
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="endpointPart"></param>
    /// <param name="include"></param>
    /// <param name="filters"></param>
    /// <param name="fields"></param>
    /// <param name="pageNum"></param>
    /// <param name="per_page"></param>
    /// <returns></returns>
    public async Task<T?> GetSingle<T>(string endpointPart,
                               string include = "",         // https://docs.sportmonks.com/football/api/request-options/includes  (ignores if filters=populate)
                               string filters = "",         // https://docs.sportmonks.com/football/api/request-options/filtering
                               string fields = "",           // https://docs.sportmonks.com/football/api/request-options/selecting-fields

                               int pageNum = 0,              // https://docs.sportmonks.com/football/tutorials-and-guides/tutorials/introduction/pagination - pagination
                               uint per_page = 25

                               ) where T : class
    {
        string fullEndpoint = $"{version}/{endpointPart}?";

        if (pageNum > 1) fullEndpoint += $"&page={pageNum}";
        if (per_page != 25) fullEndpoint += $"&per_page={per_page}";

        if (!string.IsNullOrWhiteSpace(include)) fullEndpoint += '&' + include;
        if (!string.IsNullOrWhiteSpace(filters)) fullEndpoint += '&' + filters;
        if (!string.IsNullOrWhiteSpace(fields)) fullEndpoint += '&' + fields;


        var response = await _httpClient.GetAsync(fullEndpoint);     // e.g. v3/core/countries
        response.EnsureSuccessStatusCode();

        var responseContent = await response.Content.ReadAsStreamAsync();
        // using (var reader = new StreamReader(responseContent))
        // {
        //     var responseString = await reader.ReadToEndAsync();
        // }
        T? responseObj = await JsonSerializer.DeserializeAsync<T>(responseContent);

        return responseObj;
    }


    #region IDisposable
    public void Dispose()
    {
        _httpClient?.Dispose();
    }
    #endregion
}



#region Shared Models


public class Pagination
{
    public int count { get; set; }
    public int per_page { get; set; }
    public int current_page { get; set; }
    public string next_page { get; set; }
    public bool has_more { get; set; }
}

public class Plan
{
    public string plan { get; set; }
    public string sport { get; set; }
    public string category { get; set; }
}

public class RateLimit
{
    public int resets_in_seconds { get; set; }
    public int remaining { get; set; }
    public string requested_entity { get; set; }
}

public class Subscription
{
    public List<object> meta { get; set; }
    public List<Plan> plans { get; set; }
    public List<object> add_ons { get; set; }
    public List<object> widgets { get; set; }
}


#endregion


