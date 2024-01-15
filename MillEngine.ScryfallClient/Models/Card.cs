using System.Text.Json.Serialization;
using MillEngine.ScryfallClient.Models.CardComponents;

namespace MillEngine.ScryfallClient.Models;

public class Card : BaseItem
{
    // Core Properties
    [JsonPropertyName("arena_id")]
    public int? ArenaId { get; set; }

    [JsonPropertyName("id")]
    public Guid Id { get; set; }

    [JsonPropertyName("lang")]
    public string Lang { get; set; }

    [JsonPropertyName("mtgo_id")]
    public int? MtgoId { get; set; }

    [JsonPropertyName("mtgo_foil_id")]
    public int? MtgoFoilId { get; set; }

    [JsonPropertyName("multiverse_ids")]
    public IEnumerable<int>? MultiverseIds { get; set; }

    [JsonPropertyName("tcgplayer_id")]
    public int? TcgplayerId { get; set; }

    [JsonPropertyName("tcgplayer_etched_id")]
    public int? TcgplayerEtchedId { get; set; }

    [JsonPropertyName("cardmarket_id")]
    public int? CardmarketId { get; set; }

    [JsonPropertyName("layout")]
    public string Layout { get; set; }

    [JsonPropertyName("oracle_id")]
    public Guid? OracleId { get; set; }

    [JsonPropertyName("prints_search_uri")]
    public Uri PrintsSearchUri { get; set; }

    [JsonPropertyName("rulings_uri")]
    public Uri RulingsUri { get; set; }

    [JsonPropertyName("scryfall_uri")]
    public Uri ScryfallUri { get; set; }

    [JsonPropertyName("uri")]
    public Uri Uri { get; set; }

    // Gameplay Fields
    [JsonPropertyName("all_parts")]
    public IEnumerable<RelatedCard>? AllParts { get; set; }

    [JsonPropertyName("card_faces")]
    public IEnumerable<CardFace>? CardFaces { get; set; }

    [JsonPropertyName("cmc")]
    public decimal Cmc { get; set; }

    [JsonPropertyName("color_identity")]
    public IEnumerable<string>? ColorIdentity { get; set; }

    [JsonPropertyName("color_indicator")]
    public IEnumerable<string>? ColorIndicator { get; set; }

    [JsonPropertyName("defense")]
    public string? Defense { get; set; }

    [JsonPropertyName("edhrec_rank")]
    public int? EdhrecRank { get; set; }

    [JsonPropertyName("hand_modifier")]
    public string? HandModifier { get; set; }

    [JsonPropertyName("keywords")]
    public IEnumerable<string>? Keywords { get; set; }

    [JsonPropertyName("legalities")]
    public Legality Legalities { get; set; }

    [JsonPropertyName("life_modifier")]
    public string? LifeModifier { get; set; }

    [JsonPropertyName("loyalty")]
    public string? Loyalty { get; set; }

    [JsonPropertyName("mana_cost")]
    public string? ManaCost { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("oracle_text")]
    public string? OracleText { get; set; }

    [JsonPropertyName("penny_rank")]
    public int? PennyRank { get; set; }

    [JsonPropertyName("power")]
    public string? Power { get; set; }

    [JsonPropertyName("produced_mana")]
    public IEnumerable<string>? ProducedMana { get; set; }

    [JsonPropertyName("reserved")]
    public bool Reserved { get; set; }

    [JsonPropertyName("toughness")]
    public string? Toughness { get; set; }

    [JsonPropertyName("type_line")]
    public string TypeLine { get; set; }

    // Print Fields
    [JsonPropertyName("artist")]
    public string? Artist { get; set; }

    [JsonPropertyName("artist_ids")]
    public IEnumerable<string>? ArtistIds { get; set; }

    [JsonPropertyName("attraction_lights")]
    public IEnumerable<string>? AttractionLights { get; set; }

    [JsonPropertyName("booster")]
    public bool Booster { get; set; }

    [JsonPropertyName("border_color")]
    public string BorderColor { get; set; }

    [JsonPropertyName("card_back_id")]
    public Guid CardBackId { get; set; }

    [JsonPropertyName("collector_number")]
    public string CollectorNumber { get; set; }

    [JsonPropertyName("content_warning")]
    public bool? ContentWarning { get; set; }

    [JsonPropertyName("digital")]
    public bool Digital { get; set; }

    [JsonPropertyName("finishes")]
    public IEnumerable<string>? Finishes { get; set; }

    [JsonPropertyName("flavor_name")]
    public string? FlavorName { get; set; }

    [JsonPropertyName("flavor_text")]
    public string? FlavorText { get; set; }

    [JsonPropertyName("frame_effects")]
    public IEnumerable<string>? FrameEffects { get; set; }

    [JsonPropertyName("frame")]
    public string Frame { get; set; }

    [JsonPropertyName("full_art")]
    public bool FullArt { get; set; }

    [JsonPropertyName("games")]
    public IEnumerable<string>? Games { get; set; }

    [JsonPropertyName("highres_image")]
    public bool HighresImage { get; set; }

    [JsonPropertyName("illustration_id")]
    public Guid? IllustrationId { get; set; }

    [JsonPropertyName("image_status")]
    public string ImageStatus { get; set; }

    [JsonPropertyName("image_uris")]
    public ImageUriList? ImageUris { get; set; }

    [JsonPropertyName("oversized")]
    public bool Oversized { get; set; }

    [JsonPropertyName("prices")]
    public Price? Prices { get; set; }

    [JsonPropertyName("printed_name")]
    public string? PrintedName { get; set; }

    [JsonPropertyName("printed_text")]
    public string? PrintedText { get; set; }

    [JsonPropertyName("printed_type_line")]
    public string? PrintedTypeLine { get; set; }

    [JsonPropertyName("promo")]
    public bool Promo { get; set; }

    [JsonPropertyName("promo_types")]
    public IEnumerable<string>? PromoTypes { get; set; }

    [JsonPropertyName("purchase_uris")]
    public PurchaseUriList? PurchaseUris { get; set; }

    [JsonPropertyName("rarity")]
    public string Rarity { get; set; }

    [JsonPropertyName("related_uris")]
    public RelatedUriList? RelatedUris { get; set; }

    [JsonPropertyName("released_at")]
    public DateTime ReleasedAt { get; set; }

    [JsonPropertyName("reprint")]
    public bool Reprint { get; set; }

    [JsonPropertyName("scryfall_set_uri")]
    public Uri ScryfallSetUri { get; set; }

    [JsonPropertyName("set_name")]
    public string SetName { get; set; }

    [JsonPropertyName("set_search_uri")]
    public Uri SetSearchUri { get; set; }

    [JsonPropertyName("set_type")]
    public string SetType { get; set; }

    [JsonPropertyName("set_uri")]
    public Uri SetUri { get; set; }

    [JsonPropertyName("set")]
    public string Set { get; set; }

    [JsonPropertyName("set_id")]
    public Guid SetId { get; set; }

    [JsonPropertyName("story_spotlight")]
    public bool StorySpotlight { get; set; }

    [JsonPropertyName("textless")]
    public bool Textless { get; set; }

    [JsonPropertyName("variation")]
    public bool Variation { get; set; }

    [JsonPropertyName("variation_of")]
    public Guid? VariationOf { get; set; }

    [JsonPropertyName("security_stamp")]
    public string? SecurityStamp { get; set; }

    [JsonPropertyName("watermark")]
    public string? Watermark { get; set; }

    [JsonPropertyName("preview")]
    public Preview? Preview { get; set; }


}