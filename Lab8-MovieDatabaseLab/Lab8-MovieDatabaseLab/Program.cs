using Lab8_MovieDatabaseLab;

List<Movie> movies = new List<Movie>()
{
    new Movie("Inception", 2010, "Science Fiction"),
    new Movie("The Shawshank Redemption", 1994, "Drama"),
    new Movie("The Dark Knight", 2008, "Action"),
    new Movie("Pulp Fiction", 1994, "Crime"),
    new Movie("Forrest Gump", 1994, "Drama"),
    new Movie("The Matrix", 1999, "Science Fiction"),
    new Movie("The Godfather", 1972, "Crime"),
    new Movie("Star Wars: Episode IV - A New Hope", 1977, "Science Fiction"),
    new Movie("Jurassic Park", 1993, "Adventure"),
    new Movie("The Lord of the Rings: The Fellowship of the Ring", 2001, "Fantasy")
};


bool userContinue1 = true;
bool userContinue2 = true;
bool userContinue3 = true;
var categories = movies.Select(x  => x.Category)
    .Distinct()
    .OrderBy(t => t)
    .ToList();

Console.WriteLine("Welcome to the Movie List Application!");
Console.WriteLine($"There are {movies.Count()} movies in this list.");
while (userContinue1)
{
    Console.WriteLine($"The categories are: ");
    categories.ForEach(x => Console.WriteLine(x));
    Console.WriteLine("");
    Console.WriteLine($"What category are you interested in?");
    string userCategory = Console.ReadLine();
    while (userContinue2)
    {
        var userCategories = movies.Where(x => x.Category == userCategory)
        .OrderBy(t => t.Title)
        .ToList();
        if (userCategories.Count > 0)
        {
            foreach (var userCategory2 in userCategories)
            {
                Console.WriteLine($"{userCategory2.Title}, {userCategory2.DebutYear}");
            }
            userContinue2 = false;
        }
        else
        {
            Console.WriteLine("Please input a valid category");
            userCategory = Console.ReadLine();
        }
    }
    userContinue3 = true;
    Console.WriteLine("");
    Console.WriteLine("Would you like to continue? y/n");
    string userChoice = Console.ReadLine();
    while (userContinue3)
    {
        if (userChoice.ToLower() == "y")
        {
            userContinue3 = false;
            userContinue2 = true;
        }
        else if (userChoice.ToLower() == "n")
        {
            Console.WriteLine("Goodbye!");
            userContinue3 = false;
            userContinue1 = false;
        }
        else
        {
            Console.WriteLine("Please enter 'y' or 'n'");
            userChoice = Console.ReadLine();
        }
    }
}