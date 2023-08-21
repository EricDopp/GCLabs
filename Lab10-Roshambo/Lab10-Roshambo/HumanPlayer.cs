namespace Lab10_Roshambo;

public class HumanPlayer : Player
{
    public static string GetName()
    {
        bool nameContinue = true;
        string userName = "";
        while (nameContinue)
        {
            Console.WriteLine("Please enter your name.");
            userName = Console.ReadLine();
            if (string.IsNullOrEmpty(userName))
            {
                Console.WriteLine("Try to enter your name again.");
            }
            else
            {
                nameContinue = false;
            }
        }
        return userName;
    }
    public override Roshambo GenerateRoshambo()
    {
        bool userContinue = true;
        Roshambo roshambo = new Roshambo();
        while (userContinue)
        {
            string userInput = "";
            Console.WriteLine("What would you like to throw?");
            Console.WriteLine("Rock, Paper, or Scissors?");
            userInput = Console.ReadLine();
            if (userInput.ToLower() == "rock" || userInput.ToLower() == "r")
            {
                userContinue = false;
                roshambo = Roshambo.ROCK;
            }
            else if (userInput.ToLower() == "paper" || userInput.ToLower() == "p")
            {
                userContinue = false;
                roshambo = Roshambo.PAPER;
            }
            else if (userInput.ToLower() == "scissors" || userInput.ToLower() == "s")
            {
                userContinue = false;
                roshambo = Roshambo.SCISSORS;
            }
            else
            {
                Console.WriteLine("Please enter, 'Rock', 'Paper', or 'Scissors'");
            }
        }
        return roshambo;
    }
}
