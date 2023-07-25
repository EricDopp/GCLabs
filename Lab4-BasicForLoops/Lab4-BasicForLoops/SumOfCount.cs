namespace Lab4_BasicForLoops
{
    public class SumOfCount
    {
        public SumOfCount()
        {
            bool userChoice = true;
            bool userChoice2 = true;
            while (userChoice)
            {
                int i, x, sum = 0;
                Console.Write("Enter a number: ");
                bool parseGood = int.TryParse(Console.ReadLine(), out x);
                while (!parseGood)
                {
                    Console.Write("Please input a valid number: ");
                    parseGood = int.TryParse(Console.ReadLine(), out x);
                }
                for (i = 0; i <= x; i++)
                {
                    sum += i;
                }
                Console.WriteLine(sum);
                userChoice = false;
                while (userChoice2)
                {
                    Console.WriteLine("Would you like to continue? (y/n)");
                    string userInput = Console.ReadLine();
                    if (userInput.ToLower() == "y")
                    {
                        userChoice = true;
                        break;
                    }
                    else if (userInput.ToLower() == "n")
                    {
                        Console.WriteLine("Goodbye!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Please input 'y' or 'n'.");
                    }
                }
            }
        }
    }
}