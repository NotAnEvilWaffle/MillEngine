using System.ComponentModel.DataAnnotations;

namespace MillEngine.Shared.Models.DTOs;

public abstract class BaseDTO
{
    [Key]
    public int Id { get; init; }
    public string Name { get; init; }
}