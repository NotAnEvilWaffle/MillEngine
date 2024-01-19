using MillEngine.ScryfallClient.Models;

namespace MillEngine.ScryfallClient.Clients;

public interface ISetsClient
{
   Task<RequestedList<Set>> GetAllSets();

   Task<Set> GetSetById(Guid id);


}