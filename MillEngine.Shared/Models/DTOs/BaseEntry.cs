using System.ComponentModel.DataAnnotations;

namespace MillEngine.Shared.Models.DTOs;

public abstract class BaseEntry
{
    [Key]
    public int Id { get; init; }
    public string Name { get; init; }
}