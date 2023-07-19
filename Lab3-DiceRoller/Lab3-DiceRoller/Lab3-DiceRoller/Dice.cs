namespace Lab3_DiceRoller
{
    public class Dice
    {
        public static string SumD6(int firstD6, int secondD6)
        {
            int total = firstD6 + secondD6;
            if (total == 2)
            {
                return $"You rolled a {firstD6} and a {secondD6}: ({total} total). Snake Eyes: Two 1s";
            }
            else if (total == 3)
            {
                return $"You rolled a {firstD6} and a {secondD6}: ({total} total). Ace Deuce: A 1 and 2";
            }
            else if (total == 12)
            {
                return $"You rolled a {firstD6} and a {secondD6}: ({total} total). Box Cars: Two 6s";
            }
            else
                return $"You rolled a {firstD6} and a {secondD6}: ({total} total).";
        }
    }
}

