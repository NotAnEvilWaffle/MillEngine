namespace MillEngine.Shared.Models.DTOs;

public class CardDTO : BaseDTO
{
    public int Count { get; set; }
    public Guid ScryfallId { get; init; }
    public Guid SetId { get; init; }
    
}