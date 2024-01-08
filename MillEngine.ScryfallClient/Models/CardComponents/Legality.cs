﻿using System.Text.Json.Serialization;


namespace MillEngine.ScryfallClient.Models.CardComponents;

public class Legality
{
    [JsonPropertyName("standard")]
    public string Standard { get; set; }

    [JsonPropertyName("future")]
    public string Future { get; set; }

    [JsonPropertyName("historic")]
    public string Historic { get; set; }

    [JsonPropertyName("gladiator")]
    public string Gladiator { get; set; }

    [JsonPropertyName("pioneer")]
    public string Pioneer { get; set; }

    [JsonPropertyName("explorer")]
    public string Explorer { get; set; }

    [JsonPropertyName("modern")]
    public string Modern { get; set; }

    [JsonPropertyName("legacy")]
    public string Legacy { get; set; }

    [JsonPropertyName("pauper")]
    public string Pauper { get; set; }

    [JsonPropertyName("vintage")]
    public string Vintage { get; set; }

    [JsonPropertyName("penny")]
    public string Penny { get; set; }

    [JsonPropertyName("commander")]
    public string Commander { get; set; }

    [JsonPropertyName("oathbreaker")]
    public string Oathbreaker { get; set; }

    [JsonPropertyName("brawl")]
    public string Brawl { get; set; }

    [JsonPropertyName("historicbrawl")]
    public string Historicbrawl { get; set; }

    [JsonPropertyName("alchemy")]
    public string Alchemy { get; set; }

    [JsonPropertyName("paupercommander")]
    public string Paupercommander { get; set; }

    [JsonPropertyName("duel")]
    public string Duel { get; set; }

    [JsonPropertyName("oldschool")]
    public string Oldschool { get; set; }

    [JsonPropertyName("premodern")]
    public string Premodern { get; set; }

    [JsonPropertyName("predh")]
    public string Predh { get; set; }
}