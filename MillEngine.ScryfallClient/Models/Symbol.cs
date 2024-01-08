using System.Text.Json.Serialization;

namespace MillEngine.ScryfallClient.Models;

public class Symbol : BaseItem
{
    [JsonPropertyName("symbol")]
    public string SymbolText { get; set; }

    [JsonPropertyName("svg_uri")]
    public string? SvgUri { get; set; }

    [JsonPropertyName("loose_variant")]
    public string? LooseVariant { get; set; }

    [JsonPropertyName("english")]
    public string English { get; set; }

    [JsonPropertyName("transposable")]
    public bool Transposable { get; set; }

    [JsonPropertyName("represents_mana")]
    public bool RepresentsMana { get; set; }

    [JsonPropertyName("appears_in_mana_costs")]
    public bool AppearsInManaCosts { get; set; }

    [JsonPropertyName("mana_value")]
    public decimal? ManaValue { get; set; }

    [JsonPropertyName("hybrid")]
    public bool Hybrid { get; set; }

    [JsonPropertyName("phyrexian")]
    public bool Phyrexian { get; set; }

    [JsonPropertyName("cmc")]
    public decimal? Cmc { get; set; }

    [JsonPropertyName("funny")]
    public bool Funny { get; set; }

    [JsonPropertyName("colors")]
    public List<string> Colors { get; set; }

    [JsonPropertyName("gatherer_alternates")]
    public List<string>? GathererAlternates { get; set; }

}