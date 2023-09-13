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
            playerName = Rocky.Name;
            break;
        case "rando":
            computerRoshambo = Rando.GenerateRoshambo();
            playerName = Rando.Name;
            break;
        default:
            Console.WriteLine("I need this default case here in order for this to work, I don't know why");
            return;
    }
    {
        if (roshambo == computerRoshambo)
        {
            games++;
            Validator.Scoreboard(wins, losses, games, computerRoshambo, roshambo, userName, playerName);
            userContinue = false;
        }
        else if ((roshambo == Roshambo.ROCK && computerRoshambo == Roshambo.SCISSORS) ||
                (roshambo == Roshambo.PAPER && computerRoshambo == Roshambo.ROCK) ||
                (roshambo == Roshambo.SCISSORS && computerRoshambo == Roshambo.PAPER))
        {
            wins++;
            games++;
            Validator.Scoreboard(wins, losses, games, computerRoshambo, roshambo, userName, playerName);

            userContinue = false;
        }
        else
        {
            losses++;
            games++;
            Validator.Scoreboard(wins, losses, games, computerRoshambo, roshambo, userName, playerName);
            userContinue = false;
        }
    }
    userContinue = Validator.GetYN();
}