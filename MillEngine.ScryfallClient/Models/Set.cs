using System.Text.Json.Serialization;

namespace MillEngine.ScryfallClient.Models;

public class Set : BaseItem
{
    [JsonPropertyName("id")]
    public Guid Id { get; set; }
    
    [JsonPropertyName("code")]
    public string Code { get; set; }
    
    [JsonPropertyName("mtgo_code")]
    public string? MtgoCode { get; set; }
    
    [JsonPropertyName("arena_code")]
    public string? ArenaCode { get; set; }
    
    [JsonPropertyName("tcgplayer_id")]
    public string? TcgplayerId { get; set; }
    
    [JsonPropertyName("name")]
    public string Name { get; set; }
    
    [JsonPropertyName("set_type")]
    public string SetType { get; set; }
    
    [JsonPropertyName("released_at")]
    public DateTime? ReleasedAt { get; set; }
    
    [JsonPropertyName("block_code")]
    public string? BlockCode { get; set; }
    
    [JsonPropertyName("block")]
    public string? Block { get; set; }
    
    [JsonPropertyName("parent_set_code")]
    public string? ParentSetCode { get; set; }
    
    [JsonPropertyName("card_count")]
    public int CardCount { get; set; }
    
    [JsonPropertyName("printed_size")]
    public int? PrintedSize { get; set; }
    
    [JsonPropertyName("digital")]
    public bool IsDigital { get; set; }
    
    [JsonPropertyName("foil_only")]
    public bool IsFoilOnly { get; set; }
    
    [JsonPropertyName("nonfoil_only")]
    public bool IsNonFoilOnly { get; set; }
    
    [JsonPropertyName("scryfall_uri")]
    public Uri ScryfallUri { get; set; }
    
    [JsonPropertyName("uri")]
    public Uri SetUri { get; set; }
    
    [JsonPropertyName("icon_svg_uri")]
    public Uri IconSvgUri { get; set; }
    
    [JsonPropertyName("search_uri")]
    public Uri SearchUri { get; set; }
    
    
}