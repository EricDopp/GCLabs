namespace Lab10_Roshambo;

public class RandomPlayer : Player
{
    public override Roshambo GenerateRoshambo()
    {
        Random random = new Random();
        int randomNumber = random.Next(1, 4);
        Roshambo roshambo = new Roshambo();
        if (randomNumber == 0 )
        {
            roshambo = Roshambo.ROCK;
        }
        else if (randomNumber == 1 )
        {
            roshambo = Roshambo.PAPER;
        }
        else
        {
            roshambo = Roshambo.SCISSORS;
        }
        return roshambo;
    }
}
