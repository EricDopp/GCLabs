using PauperReddit.Models.Interfaces;

namespace PauperReddit.Models;

public class RedditService : IRedditService
{
    public async Task<List<Child>> GetDataJsonAsync()
    {
        string apiUrl = "https://www.reddit.com/r/Awww.json";

        using (HttpClient client = new HttpClient())
        {
            client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/123.0.0.1 Safari/537.36");
            try
            {
                Response response = await client.GetFromJsonAsync<Response>(apiUrl);

                if(response ==null)
                {
                    return null;
                }

                return response.data.children;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        return null;
    }
}