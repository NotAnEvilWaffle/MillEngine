using System.Text.Json.Serialization;

namespace MillEngine.ScryfallClient.Models.CardComponents;

public class CardFace : BaseItem
{

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("mana_cost")]
    public string ManaCost { get; set; }

    [JsonPropertyName("type_line")]
    public string TypeLine { get; set; }

    [JsonPropertyName("oracle_text")]
    public string OracleText { get; set; }

    [JsonPropertyName("colors")]
    public IEnumerable<string> Colors { get; set; }

    [JsonPropertyName("power")]
    public string Power { get; set; }

    [JsonPropertyName("toughness")]
    public string Toughness { get; set; }

    [JsonPropertyName("artist")]
    public string Artist { get; set; }

    [JsonPropertyName("artist_id")]
    public string ArtistId { get; set; }

    [JsonPropertyName("illustration_id")]
    public string IllustrationId { get; set; }

    [JsonPropertyName("image_uris")]
    public ImageUriList ImageUris { get; set; }

    [JsonPropertyName("flavor_name")]
    public string FlavorName { get; set; }

    [JsonPropertyName("color_indicator")]
    public List<string> ColorIndicator { get; set; }
}