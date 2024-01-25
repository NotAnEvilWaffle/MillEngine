using System.Text.Json;
using System.Text.Json.Serialization;
using Microsoft.Extensions.Caching.Memory;
using MillEngine.ScryfallClient.Models;

namespace MillEngine.ScryfallClient.Clients;

public class ApiClient
{
    private IMemoryCache _cache;
    private HttpClient _client;
    private MemoryCacheEntryOptions _cacheOptions;
    
    public ApiClient(HttpClient client, IMemoryCache cache, string baseAddress, TimeSpan cacheTime)
    {
        _client = client;
        _cache = cache;
        _client.BaseAddress = new Uri(baseAddress);
        _cacheOptions = new MemoryCacheEntryOptions { AbsoluteExpirationRelativeToNow = cacheTime };
        
    }

    // Cache needs to be disabled in cases where getting a random card
   public async Task<T> GetApiResponseAsync<T>(string endpoint, bool useCache = true) where T : BaseItem
   {
       string fullResourceUri = _client.BaseAddress.AbsoluteUri + endpoint;
       if (useCache &&  _cache.TryGetValue(fullResourceUri, out T cachedResult))
       {
           return cachedResult;
       }

       try
       {
           HttpResponseMessage response = await _client.GetAsync(fullResourceUri);

           if (response.IsSuccessStatusCode)
           {
               // Can't Deserialize asynchronously from a string for some reason
               // So we need ReadAsStream instead of ReadAsString
               var responseBody = await response.Content.ReadAsStreamAsync();
               T? result = await JsonSerializer.DeserializeAsync<T>(responseBody);

               _cache.Set(fullResourceUri, result, _cacheOptions);
               return result;
           }
           
           Console.WriteLine($"Error: {response.StatusCode} - {response.Content}");
           return default(T);
       }
       catch (Exception e)
       {
           Console.WriteLine(e);
           return default(T);
       }
       
   }
}