using System;
namespace SportMonksSDK;

public class BaseResponse
{
    
}


public class SingleResponse<T> : BaseResponse
    where T : class
{
    public T data { get; set; }
    
    public List<Subscription> subscription { get; set; }
    public RateLimit rate_limit { get; set; }
    public string timezone { get; set; }  
}


public class ListResponse<T> where T : class
{
    public List<T> data { get; set; }

    public Pagination pagination { get; set; }

    public List<Subscription> subscription { get; set; }
    public RateLimit rate_limit { get; set; }
    public string timezone { get; set; }
}




