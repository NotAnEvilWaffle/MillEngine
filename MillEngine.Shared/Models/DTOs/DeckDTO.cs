namespace MillEngine.Shared.Models.DTOs;

public class DeckDTO : BaseDTO
{
    public List<CardDTO> DeckCards { get; set; }
    public List<CardDTO> SideBoard { get; set; }
    public List<CardDTO> MaybeList { get; set; }
    public List<CardDTO> WishList { get; set; }
    
    public CardDTO Commander { get; set; }
    public CardDTO Partner { get; set; }
    
}