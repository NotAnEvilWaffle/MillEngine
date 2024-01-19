using MillEngine.ScryfallClient.Models;

namespace MillEngine.ScryfallClient.Clients;

public class SetsClient : ISetsClient
{
    private ApiClient _apiClient;

    public SetsClient(ApiClient client)
    {
        _apiClient = client;
    }
    
    public Task<RequestedList<Set>> GetAllSets()
    {
        var setList = _apiClient.GetApiResponseAsync<RequestedList<Set>>("/sets");
        return setList;
    }

    public Task<Set> GetSetById(Guid id)
    {
        var set = _apiClient.GetApiResponseAsync<Set>($"/sets/{id.ToString()}");
        return set;
    }
}