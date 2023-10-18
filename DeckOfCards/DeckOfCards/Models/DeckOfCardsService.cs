using DeckOfCards.Models.Interfaces;
using static System.Net.WebRequestMethods;

namespace DeckOfCards.Models;

public class DeckOfCardsService : IDeckOfCardsService
{
    //Make a call to the API to generate a new deck. Capture the deck ID returned.
    //https://deckofcardsapi.com/api/deck/new/shuffle/?deck_count=1

    public async Task<string> CreateNewDeckAsync() //Don't use async void
    {
        string apiUrl = "https://deckofcardsapi.com/api/deck/new/shuffle/?deck_count=1";


        using (HttpClient client = new HttpClient())
        {
            try
            {
                GenerateDeckResponse generateDeckResponse = await client.GetFromJsonAsync<GenerateDeckResponse>(apiUrl); //Please name any async methods with "async" in there somewhere, please

                if(generateDeckResponse ==null)
                {
                    return null;
                }

                return generateDeckResponse.deck_id;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        return null;
    }
    //Draw 5 cards from the deck
    //https://deckofcardsapi.com/api/deck/<<deck_id>>/draw/?count=5

    public async Task<List<Card>> GetCardsAynsc(string deckId)
    {
        string apiUrl = $"https://deckofcardsapi.com/api/deck/{deckId}/draw/?count=5";

        using (HttpClient client = new HttpClient()) //using means that this request is made and then disposed after it's done
        {
            try
            {
                DrawDeckResponse drawDeckResponse = await client.GetFromJsonAsync<DrawDeckResponse>(apiUrl);

                if(drawDeckResponse ==null)
                {
                    return null;
                }
                return drawDeckResponse.cards;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        return null;
    }

    //Return said 5 cards


}
