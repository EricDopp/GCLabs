namespace Lab10_Roshambo;

public class RockPlayer : Player
{
    public override Roshambo GenerateRoshambo()
    {
        Roshambo roshambo = new Roshambo();
        roshambo = Roshambo.ROCK;
        return roshambo;
    }
}
