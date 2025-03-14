using SportMonksSDK.API.Core.Entities;

namespace SportMonksSDK;


// API client
public class CountriesApiClient : BaseApiClient
{
    // 
    public async Task<AllCountriesResponse> All()
    {
        return await base.GetAll<AllCountriesResponse, Country>("core/countries",
                                                                    parametersPart: Constants.Filter_1000_Per_Page);
    }

    /// 
    /// <param name="countryId">
    /// The ID of the country you want to retrieve.
    /// </param>
    public async Task<CountryReponse> ByID(int countryId)
    {
        return await base.GetSingle<CountryReponse>($"core/countries/{countryId}");        
    }


    /// <param name="version">
    /// The version of the API.
    /// </param>
    /// <param name="name">
    /// The name you want to search on
    /// </param>
    public async Task<AllCountriesResponse> Search(string name)
    {
        return await base.GetAll<AllCountriesResponse, Country>($"core/countries/search/{name}", parametersPart: "");
    }
}



#region Models


public class AllCountriesResponse : ListResponse<Country>
{
   
}

public class CountryReponse : SingleResponse<Country>
{    
}


// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);


#endregion      // countries

