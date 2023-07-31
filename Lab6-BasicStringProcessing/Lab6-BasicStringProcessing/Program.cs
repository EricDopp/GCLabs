bool userContinue4 = true;
bool userContinue5 = true;
while (userContinue4)
{
    Console.Write("Enter a sentence: ");
    string userInput = Console.ReadLine();
    string[] words = userInput.Split(" ");
    foreach (var word in words)
    {
        System.Console.WriteLine($"{word}");
    }
    Console.WriteLine("Would you like to continue (y/n)?");
    string userInput3 = Console.ReadLine();
    while (userContinue5)
    {
        if (userInput3.ToLower() == "y")
        {
            break;
        }
        else if (userInput3.ToLower() == "n")
        {
            Console.WriteLine("Goodbye!");
            userContinue4 = false;
            userContinue5 = false;
            break;
        }
        else
        {
            Console.WriteLine("Please enter 'y' or 'n'");
            userInput3 = Console.ReadLine();
        }
    }
}

bool userContinue1 = true;
bool userContinue2 = true;
bool userContinue3 = true;
List<string> words2 = new List<string>();
while (userContinue1)
{
    Console.Write("Enter some text: ");
    string userJoin = Console.ReadLine();
    userContinue3 = true;
    while (userContinue3)
    {
        if (userJoin.Trim() == "")
        {
            Console.WriteLine("Invalid entry, please input some text.");
            userJoin = Console.ReadLine();
        }
        else
        {
            words2.Add(userJoin.Trim());
            string sentence = string.Join(" ", words2);
            Console.Write($"You have entered: {sentence}");
            Console.WriteLine("");
            Console.WriteLine("Would you like to continue (y/n)?");
            string userInput2 = Console.ReadLine();
            while (userContinue2)
            {
                if (userInput2.ToLower() == "y")
                {
                    userContinue3 = false;
                    break;
                }
                else if (userInput2.ToLower() == "n")
                {
                    Console.WriteLine("Goodbye!");
                    userContinue1 = false;
                    userContinue3 = false;
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter 'y' or 'n'");
                    userInput2 = Console.ReadLine();
                }
            }
        }
    }
}