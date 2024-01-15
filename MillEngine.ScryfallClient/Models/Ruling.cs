using System.Text.Json.Serialization;

namespace MillEngine.ScryfallClient.Models;

public class Ruling : BaseItem
{
    [JsonPropertyName("oracle_id")]
    public Guid OracleId  { get; set; }
    
    [JsonPropertyName("source")]
    public string Source { get; set; }
    
    [JsonPropertyName("published_at")]
    public DateTime PublishDate { get; set; }
    
    [JsonPropertyName("comment")]
    public string Comment { get; set; }
}