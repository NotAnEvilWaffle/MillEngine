using System.Text.Json.Serialization;

namespace MillEngine.ScryfallClient.Models;

public class RequestedList<T> : BaseItem where T : BaseItem
{
    [JsonPropertyName("object")]
    public string Object { get; set; }
    
    [JsonPropertyName("data")]
    public IEnumerable<T> Data { get; set; }
    
    [JsonPropertyName("has_more")]
    public bool HasMore { get; set; }
    
    [JsonPropertyName("next_page")]
    public Uri? NextPage { get; set; }
    
    [JsonPropertyName("total_cards")]
    public int TotalCards { get; set; }
    
}