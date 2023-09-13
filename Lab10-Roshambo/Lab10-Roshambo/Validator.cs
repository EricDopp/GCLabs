namespace Lab10_Roshambo;

public class Validator
{
    public static bool GetYN()
    {
        bool userContinue = true;
        while (userContinue)
        {
            Console.WriteLine("Do you want to continue? (y/n)");
            string userInput = Console.ReadLine();
            if (userInput.ToLower() == "y")
            {
                break;
            }
            else if (userInput.ToLower() == "n")
            {
                Console.WriteLine("Goodbye!");
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Please input 'y' or 'n'.");
                userInput = Console.ReadLine();
            }
        }
        return true;
    }
    public static string GetOtherPlayer()
    {
        bool userContinue = true;
        string playerName = "";
        RandomPlayer rando = new RandomPlayer();
        RockPlayer rocky = new RockPlayer();
        while (userContinue)
        {
            Console.WriteLine("Please choose your opponent: Rocky or Rando");
            playerName = Console.ReadLine();
            if (playerName.ToLower() == "rocky")
            {
                userContinue = false;
            }
            else if (playerName.ToLower() == "rando")
            {
                userContinue = false;
            }
            else
            {
                Console.WriteLine("Please enter 'Rocky' or 'Rando'");
            }
        }
        return playerName;
    }
    public static void Scoreboard(int wins, int losses, int games, Roshambo computerRoshambo, Roshambo roshambo, string userName, string playerName)
    {
        Console.WriteLine($"{playerName}: threw {computerRoshambo}!");
        Console.WriteLine($"{userName}: threw {roshambo}!");
        Console.WriteLine("You lose.");
        Console.WriteLine($"Wins: {wins} | Losses: {losses} | Games played: {games}");
    }
}
