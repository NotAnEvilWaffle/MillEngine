
namespace MillEngine.Shared.Models.DTOs;

public class DeckEntry : BaseEntry
{
    
    
    public List<CardEntry> DeckCards { get; init; } = new List<CardEntry>();
    public List<CardEntry> SideBoard { get; init; } = new List<CardEntry>();
    public List<CardEntry> MaybeList { get; init; } = new List<CardEntry>();
    public List<CardEntry> WishList { get; init; } = new List<CardEntry>();
    
    // A deck does not require a Commander nor a Partner
    // Also nullable because JSON will not set it by default
    public CardEntry? Commander { get; set; }
    public CardEntry? Partner { get; set; }
    
}