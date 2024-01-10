

using MillEngine.ScryfallClient.Models;

namespace MillEngine.ScryfallClient.Clients;

public class CardsClient : ICardsClient
{
    public Task<RequestedList<Card>> Search(string q, int page = 1)
    {
        throw new NotImplementedException();
    }

    public Task<Card> GetRandom()
    {
        throw new NotImplementedException();
    }

    public Task<Card> GetById(Guid id)
    {
        throw new NotImplementedException();
    }
}