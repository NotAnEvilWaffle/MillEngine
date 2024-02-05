using System.ComponentModel.DataAnnotations;

namespace MillEngine.Shared.Models.DTOs;

public abstract class BaseEntry
{
    [Key]
    public int Id { get; init; }
    [Required]
    public string Name { get; set; }
}