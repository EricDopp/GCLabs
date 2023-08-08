namespace Lab8_MovieDatabaseLab;

public class Movie
{
    public string Title { get; set; }

    public int DebutYear { get; set; }
    public string Category { get; set; }

    public Movie(string title,int debutYear, string category)
    {
        this.Title = title;
        this.DebutYear = debutYear;
        this.Category = category;
    }
}
