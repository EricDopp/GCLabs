using Lab10_Roshambo;

Console.WriteLine("Welcome to Roshambo: Rock Paper Scissors!");

string userName = HumanPlayer.GetName();
string playerName = Validator.GetOtherPlayer().ToLower();

RandomPlayer Rando = new RandomPlayer();
Rando.Name = "Rando";
RockPlayer Rocky = new RockPlayer();
Rocky.Name = "Rocky";
HumanPlayer Human = new HumanPlayer();
Human.Name = userName;

bool userContinue = true;
int wins = 0;
int losses = 0;
int games = 0;

while (userContinue)
{
    Roshambo roshambo = Human.GenerateRoshambo();
    Roshambo computerRoshambo;
    switch (playerName)
    {
        case "rocky":
            computerRoshambo = Rocky.GenerateRoshambo();
            break;
        case "rando":
            computerRoshambo = Rando.GenerateRoshambo();
            break;
        default:
            Console.WriteLine("I need this default case here in order for this to work, I don't know why");
            return;
    }
    {
        if (roshambo == computerRoshambo)
        {
            Console.WriteLine($"{Rando.Name}: threw {computerRoshambo}!");
            Console.WriteLine($"{userName}: threw {roshambo}!");
            Console.WriteLine("It's a draw.");
            games++;
            Console.WriteLine($"Wins: {wins} | Losses: {losses} | Games played: {games}");
            userContinue = false;
        }
        else if ((roshambo == Roshambo.ROCK && computerRoshambo == Roshambo.SCISSORS) ||
                (roshambo == Roshambo.PAPER && computerRoshambo == Roshambo.ROCK) ||
                (roshambo == Roshambo.SCISSORS && computerRoshambo == Roshambo.PAPER))
        {
            Console.WriteLine($"{Rando.Name} threw {computerRoshambo}!");
            Console.WriteLine($"{userName} threw {roshambo}!");
            Console.WriteLine("You won!");
            wins++;
            games++;
            Console.WriteLine($"Wins: {wins} | Losses: {losses} | Games played: {games}");
            userContinue = false;
        }
        else
        {
            Console.WriteLine($"{Rando.Name}: threw {computerRoshambo}!");
            Console.WriteLine($"{userName}: threw {roshambo}!");
            Console.WriteLine("You lose.");
            losses++;
            games++;
            Console.WriteLine($"Wins: {wins} | Losses: {losses} | Games played: {games}");
            userContinue = false;
        }
    }
    userContinue = Validator.GetYN();
}