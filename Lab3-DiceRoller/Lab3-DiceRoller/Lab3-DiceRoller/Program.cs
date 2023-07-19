using Lab3_DiceRoller;

bool userChoice = true;
bool userResponse = false;
int rollCount = 0;
while (userChoice)
{
    Console.WriteLine("Welcome to the Grand Circus Casino!");
    Console.WriteLine("How many sides should each die have?");
    string userInput = Console.ReadLine();
    int nSideDice = 0;
    bool parseGood = int.TryParse(userInput, out nSideDice);

    while (!parseGood)
    {
        Console.WriteLine("Please enter a valid number for the amount of sides on each die for a pair of dice");
        userInput = Console.ReadLine();
        parseGood = int.TryParse(userInput, out nSideDice);
    }
    if (nSideDice == 6)
    {
        while (!userResponse)
        {
            Console.WriteLine("Roll the dice? (y/n)");
            string userRoll = Console.ReadLine();
            if (userRoll.ToLower() == ("y") || (userRoll.ToLower() == "yes"))
            {
                Roll roll = new Roll();
                int d6roll1 = Roll.D6(1);
                int d6roll2 = Roll.D6(1);
                string diceRoll = Dice.SumD6(d6roll1, d6roll2);
                string crapsRoll = Craps.SumD6(d6roll1, d6roll2);
                Console.WriteLine(diceRoll);
                Console.WriteLine(crapsRoll);
                //put the method instance here
            }
            else if (userRoll.ToLower() == ("n") || (userRoll.ToLower() == "no"))
            {
                userResponse = true;
                rollCount = 0;
            }
            else
            {
                Console.WriteLine("Please input 'y' or 'n'");
            }
        }
    }
    else
    {
        while (!userResponse)
        {
            Console.WriteLine("Roll the dice? (y/n)");
            string userRoll = Console.ReadLine();
            if (userRoll.ToLower() == ("y") || (userRoll.ToLower() == "yes"))
            {
                rollCount++;
                Random rand = new Random();
                int face = rand.Next(1, nSideDice + 1);
                Random rand2 = new Random();
                int face2 = rand2.Next(1, nSideDice + 1);
                Console.WriteLine($"Roll {rollCount}");
                Console.WriteLine($"You rolled a {face} and a {face2} ({face + face2} total)");
            }
            else if (userRoll.ToLower() == ("n") || (userRoll.ToLower() == "no"))
            {
                userResponse = true;
                rollCount = 0;
            }
            else
            {
                Console.WriteLine("Please input 'y' or 'n'");
            }
        }
    }

    Console.WriteLine("Want to pick different dice? (y/n)");
    string userDifferent = Console.ReadLine();
    if (userDifferent.ToLower() == ("y") || (userDifferent.ToLower() == "yes"))
    {
        userResponse = false;
    }
    else if (userDifferent.ToLower() == ("n") || (userDifferent.ToLower() == "no"))
    {
        userChoice = false;
    }
    else
    {
        Console.WriteLine("Please input 'y' or 'n'");
    }
}