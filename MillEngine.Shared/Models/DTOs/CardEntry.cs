namespace MillEngine.Shared.Models.DTOs;

public class CardEntry : BaseEntry
{
    public int Count { get; set; }
    public Guid ScryfallId { get; init; }
    public Guid SetId { get; init; }
    
}