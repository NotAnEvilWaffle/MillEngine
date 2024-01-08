using System.Text.Json.Serialization;


namespace MillEngine.ScryfallClient.Models.CardComponents;

public class PurchaseUriList
{
    [JsonPropertyName("tcgplayer")]
    public string Tcgplayer { get; set; }

    [JsonPropertyName("cardmarket")]
    public string Cardmarket { get; set; }

    [JsonPropertyName("cardhoarder")]
    public string Cardhoarder { get; set; }
}