using System.Web;
using MillEngine.ScryfallClient.Models;

namespace MillEngine.ScryfallClient.Clients;

public class SymbologyClient : ISymbologyClient
{

    private ApiClient _apiClient;

    public SymbologyClient(ApiClient client)
    {
        _apiClient = client;
    }
    public Task<RequestedList<Symbol>> GetAllSymbols()
    {
        var symbology = _apiClient.GetApiResponseAsync<RequestedList<Symbol>>($"/symbology");
        return symbology;
    }

    public Task<ManaCost> ParseMana(string cost)
    {
        cost = HttpUtility.UrlEncode(cost);
        var parsedMana = _apiClient.GetApiResponseAsync<ManaCost>($"/symbology/parse-mana?cost={cost}");
        return parsedMana;
    }
}