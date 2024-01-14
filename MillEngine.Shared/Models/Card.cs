using System.ComponentModel.DataAnnotations.Schema;
using Scryfall = ScryfallApi.Client.Models;

namespace MillEngine.Shared.Models;

public class Card
{
    public int CardId { get; set; }
    public string CardName { get; set; }
    public string TypeLine { get; set; }
    public decimal Cmc { get; set; }
    public string Power { get; set; }
    public string Toughness { get; set; }
    public string RawData { get; set; }
    
    [NotMapped]
    public Scryfall.Card BaseCard { get; set; }
}