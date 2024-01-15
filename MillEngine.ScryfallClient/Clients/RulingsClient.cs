using MillEngine.ScryfallClient.Models;

namespace MillEngine.ScryfallClient.Clients;

public class RulingsClient : IRulingsClient
{
    private ApiClient _apiClient;

    public RulingsClient(ApiClient client)
    {
        _apiClient = client;
    }
    
    public Task<RequestedList<Ruling>> GetRulingsById(Guid scryfallId)
    {
        var rulingList = _apiClient.GetApiResponseAsync<RequestedList<Ruling>>($"/cards/{scryfallId.ToString()}");
        return rulingList;
    }
}