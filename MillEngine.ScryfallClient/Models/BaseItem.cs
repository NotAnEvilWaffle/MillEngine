using System.Text.Json.Serialization;

namespace MillEngine.ScryfallClient.Models;

public class BaseItem
{
    [JsonPropertyName("object")]
    public string Object { get; set; }
}