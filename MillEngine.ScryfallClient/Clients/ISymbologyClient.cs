using MillEngine.ScryfallClient.Models;

namespace MillEngine.ScryfallClient.Clients;

public interface ISymbologyClient
{
    Task<RequestedList<Symbol>> GetAllSymbols();
    Task<ManaCost> ParseMana(string cost);
}