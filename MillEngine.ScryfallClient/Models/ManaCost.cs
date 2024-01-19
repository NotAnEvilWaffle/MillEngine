
using System.Text.Json.Serialization;

namespace MillEngine.ScryfallClient.Models;

public class ManaCost : BaseItem
{
    [JsonPropertyName("cost")]
    public string Cost { get; set; }
    
    [JsonPropertyName("cmc")]
    public decimal Cmc { get; set; }
    
    [JsonPropertyName("colors")]
    public IEnumerable<string> Colors { get; set; }
    
    [JsonPropertyName("colorless")]
    public bool IsColorless { get; set; }
    
    [JsonPropertyName("monocolored")]
    public bool IsMonocolored { get; set; }
    
    [JsonPropertyName("multicolored")]
    public bool IsMulticolored { get; set; }
}