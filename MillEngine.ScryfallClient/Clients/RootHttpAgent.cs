using Microsoft.Extensions.Caching.Memory;
using MillEngine.ScryfallClient.Models;

namespace MillEngine.ScryfallClient.Clients;

public class RootHttpAgent
{
    private IMemoryCache _cache;
    private HttpClient _client;
    private MemoryCacheEntryOptions _cacheOptions;
    
    public RootHttpAgent(HttpClient client, IMemoryCache cache, string baseAddress, TimeSpan cacheTime)
    {
        _client = client;
        _cache = cache;
        _client.BaseAddress = new Uri(baseAddress);
        _cacheOptions = new MemoryCacheEntryOptions { AbsoluteExpirationRelativeToNow = cacheTime };
    }

   
}