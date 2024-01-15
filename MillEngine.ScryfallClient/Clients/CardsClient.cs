

using System.Web;
using MillEngine.ScryfallClient.Models;

namespace MillEngine.ScryfallClient.Clients;

public class CardsClient : ICardsClient
{
    private ApiClient _apiClient;

    public CardsClient(ApiClient client)
    {
        _apiClient = client;
    }
    
    public Task<RequestedList<Card>> Search(string q, int page = 1)
    {
        // The query string may have some characters that need to be properly encoded
        q = HttpUtility.UrlEncode(q);
        var cardList = _apiClient.GetApiResponseAsync<RequestedList<Card>>($"/cards/search?q={q}");
        return cardList;
    }

    public Task<Card> GetRandom()
    {
        // Disable cache so it doesn't repeatedly get the same card
        var randomCard = _apiClient.GetApiResponseAsync<Card>("/cards/random", useCache: false);
        return randomCard;
    }

    public Task<Card> GetById(Guid id)
    {
        var card = _apiClient.GetApiResponseAsync<Card>($"/cards/{id.ToString()}");
        return card;
    }
}