namespace Lab3_DiceRoller
{
    internal class Craps
    {
        public static string SumD6(int firstD6, int secondD6)
        {
            int total = firstD6 + secondD6;
            if (total == 7 || total == 11)
            {
                return $"Win: A total of 7 or 11";
            }
            else if (total == 2 || total == 3 || total == 12)
            {
                return $"Craps: A total of 2, 3, or 12";
            }
            else
                return $"";
        }
    }
}