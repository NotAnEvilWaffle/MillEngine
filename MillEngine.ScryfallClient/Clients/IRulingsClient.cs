using MillEngine.ScryfallClient.Models;

namespace MillEngine.ScryfallClient.Clients;

public interface IRulingsClient
{
    public Task<RequestedList<Ruling>> GetRulingsById(Guid scryfallId);
}