namespace MillEngine.Shared.Models.DTOs;

public class CollectionDTO : BaseDTO
{
    public List<CardDTO> CollectionCards { get; init; } = [];
}