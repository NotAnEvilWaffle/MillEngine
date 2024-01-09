using MillEngine.ScryfallClient.Models;

namespace MillEngine.ScryfallClient;

public interface ICardsClient
{
    Task<RequestedList<Card>> Search(string q, int page = 1);

    Task<Card> GetRandom();

    Task<Card> GetById(Guid id);
}