namespace MillEngine.Shared.Models.DTOs;

public class CollectionEntry : BaseEntry
{
    public List<CardEntry> CollectionCards { get; init; } = [];
}