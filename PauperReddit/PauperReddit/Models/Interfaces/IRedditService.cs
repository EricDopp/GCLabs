namespace PauperReddit.Models.Interfaces;

public interface IRedditService
{
    Task<List<Child>> GetDataJsonAsync();
}
