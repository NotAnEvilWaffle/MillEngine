namespace MillEngine.Shared.Models.DTOs;

public class DeckEntry : BaseEntry
{
    public List<CardEntry> DeckCards { get; init; } = [];
    public List<CardEntry> SideBoard { get; init; } = [];
    public List<CardEntry> MaybeList { get; init; } = [];
    public List<CardEntry> WishList { get; init; } = [];
    
    public CardEntry Commander { get; set; }
    public CardEntry Partner { get; set; }
    
}