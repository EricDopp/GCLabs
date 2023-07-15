using System.Linq.Expressions;

bool userChoice = true;

do
{
    Console.WriteLine("Hello, World!");
    Console.WriteLine("Would you like to continue (y/n)?");
    string userInput = Console.ReadLine();
    if (userInput == "n")
    {
        userChoice = false;
    }
    else;
}
while (userChoice);
