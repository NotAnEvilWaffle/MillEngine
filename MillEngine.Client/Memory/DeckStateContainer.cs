using MillEngine.Shared.Models.DTOs;

namespace MillEngine.Client.Memory;

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