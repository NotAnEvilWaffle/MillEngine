using MillEngine.Shared.Models.DTOs;

namespace MillEngine.Client.Memory;

// Provides a way to avoid having to query the database every time we want to pass or change the deck
// Before sending updates to efcore through the controller
public class DeckStateContainer
{
    private DeckEntry? savedDeck;

    public DeckEntry? SavedDeck
    {
        get => savedDeck;
        set
        {
            savedDeck = value;
            NotifyOnStateChanged();
        }
    }

    public event Action? OnChange;
    private void NotifyOnStateChanged() => OnChange?.Invoke();
}