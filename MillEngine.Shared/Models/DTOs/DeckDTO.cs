namespace MillEngine.Shared.Models.DTOs;

public class DeckDTO : BaseDTO
{
    public List<CardDTO> DeckCards { get; init; } = [];
    public List<CardDTO> SideBoard { get; init; } = [];
    public List<CardDTO> MaybeList { get; init; } = [];
    public List<CardDTO> WishList { get; init; } = [];
    
    public CardDTO Commander { get; set; }
    public CardDTO Partner { get; set; }
    
}