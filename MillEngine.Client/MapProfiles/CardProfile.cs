using AutoMapper;


namespace MillEngine.Client.MapProfiles;

public class CardProfile : Profile
{
    public CardProfile()
    {
        CreateMap<ScryfallClient.Models.Card, Shared.Models.DTOs.CardEntry>()
            .ForMember(c => c.ScryfallId, cfg => cfg.MapFrom(sc => sc.Id))
            .ForMember(c => c.SetId, cfg => cfg.MapFrom(sc => sc.SetId))
            .ForMember(c => c.Name, cfg => cfg.MapFrom(sc => sc.Name));
    }
}