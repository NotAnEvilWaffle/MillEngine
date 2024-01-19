using System.Text.Json.Serialization;

namespace MillEngine.ScryfallClient.Models;

public class BaseItem
{
    // All Scryfall objects have this property
    [JsonPropertyName("object")]
    public string Object { get; set; }
}