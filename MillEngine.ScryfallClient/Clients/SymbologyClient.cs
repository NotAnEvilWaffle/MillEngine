using MillEngine.ScryfallClient.Models;

namespace MillEngine.ScryfallClient.Clients;

public class SymbologyClient : ISymbologyClient
{
    public Task<RequestedList<Symbol>> GetAllSymbols()
    {
        throw new NotImplementedException();
    }
}