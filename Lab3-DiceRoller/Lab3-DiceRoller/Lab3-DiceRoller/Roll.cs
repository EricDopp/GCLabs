namespace Lab3_DiceRoller
{
    internal class Roll
    {
        public static int D6(int x)
        {
            Random random = new Random();
            x = random.Next(1, 7);

            return (x);
        }
    }
}
