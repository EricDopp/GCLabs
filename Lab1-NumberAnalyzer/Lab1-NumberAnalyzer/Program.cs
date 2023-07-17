Console.WriteLine("Hello, what is your name?");
string userName = Console.ReadLine();
Console.WriteLine("Hello " + userName);
bool userChoice = true;
Console.WriteLine("Please enter a number between 1 and 100, inclusive.");
string userInput = Console.ReadLine();
int userNumber = int.Parse(userInput);
if (userNumber > 100 || userNumber < 0)
{
    Console.WriteLine("Please enter a number berween 1 and 100 bro.");
}
else if (userNumber % 2 == 1 && userNumber < 60)
{
    Console.WriteLine(userNumber + " is odd and less than 60.");
}
else if ((userNumber % 2 == 0) && userNumber < 25)
{
    Console.WriteLine(userNumber + " is even and less than 25.");
}
else if (userNumber % 2 == 0 && userNumber >= 26 && userNumber <= 60)
{
    Console.WriteLine(userNumber + " is even and between 26 and 60 inclusive.");
}
else if (userNumber % 2 == 0 && userNumber > 60)
{
    Console.WriteLine(userNumber + " is even and greater than 60.");
}
else if ((userNumber % 2 == 1) && userNumber > 60)
{
    Console.WriteLine(userNumber + " is odd and greater than 60.");
}
else
    Console.WriteLine("This isn't covered in my lab's requirements!");


while (userChoice)
{
    Console.WriteLine("Would you like to stop?");
    string userAnswer = Console.ReadLine();
    if (userAnswer.ToLower() == "yes")
        userChoice = false;
    else if (userAnswer.ToLower() == "no")
    {
        Console.WriteLine("Please enter a number between 1 and 100, inclusive.");
        userInput = Console.ReadLine();
        userNumber = int.Parse(userInput);
        userChoice = true;
        if (userNumber > 100 || userNumber < 0)
        {
            Console.WriteLine("Please enter a number berween 1 and 100 bro.");
        }
        else if (userNumber % 2 == 1 && userNumber < 60)
        {
            Console.WriteLine(userNumber + " is odd and less than 60.");
        }
        else if ((userNumber % 2 == 0) && userNumber < 25)
        {
            Console.WriteLine(userNumber + " is even and less than 25.");
        }
        else if (userNumber % 2 == 0 && userNumber >= 26 && userNumber <= 60)
        {
            Console.WriteLine(userNumber + " is even and between 26 and 60 inclusive.");
        }
        else if (userNumber % 2 == 0 && userNumber > 60)
        {
            Console.WriteLine(userNumber + " is even and greater than 60.");
        }
        else if ((userNumber % 2 == 1) && userNumber > 60)
        {
            Console.WriteLine(userNumber + " is odd and greater than 60.");
        }
        else
            Console.WriteLine("This isn't covered in my lab's requirements!");
    }
    else
    {
        Console.WriteLine("Please enter, 'Yes' or 'No'");
    }
}