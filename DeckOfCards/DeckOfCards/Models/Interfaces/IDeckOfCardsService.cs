namespace DeckOfCards.Models.Interfaces;

public interface IDeckOfCardsService
{
    Task<string> CreateNewDeckAsync();
    Task<List<Card>> GetCardsAynsc(string deckId);
}
