using Microsoft.Extensions.Caching.Memory;
using MillEngine.ScryfallClient.Clients;

namespace MillEngine.ScryfallClient;

public class ScryfallClient
{
    private ICardsClient _cardsClient;
    private IRulingsClient _rulingsClient;
    private ISetsClient _setsClient;
    private ISymbologyClient _symbologyClient;

    public ICardsClient CardsClient => _cardsClient;
    public IRulingsClient RulingsClient => _rulingsClient;
    public ISetsClient SetsClient => _setsClient;
    public ISymbologyClient SymbologyClient => _symbologyClient;

    public ScryfallClient(HttpClient client, IMemoryCache cache, string baseAddress, TimeSpan cacheLifeSpan)
    {
        var baseClient = new ApiClient(client, cache, baseAddress,cacheLifeSpan );

        _cardsClient = new CardsClient(baseClient);
        _rulingsClient = new RulingsClient(baseClient);
        _setsClient = new SetsClient(baseClient);
        _symbologyClient = new SymbologyClient(baseClient);
    }
}