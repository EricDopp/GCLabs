namespace Lab10_Roshambo;

public abstract class Player
{
    public string Name { get; set; }
    public Roshambo Roshambo { get; set; }
    public abstract Roshambo GenerateRoshambo();
}
