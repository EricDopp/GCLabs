﻿bool userChoice = true;
Console.WriteLine("Hello, World!");
do
{
    Console.WriteLine("Would you like to continue (y/n)?");
    string userInput = Console.ReadLine();
    if (userInput.ToLower() == "n") 
    {
        userChoice = false;
    }
    else if (userInput.ToLower() == "y")
    {
        Console.WriteLine("Hello, World!");
    }
    else
    {
        Console.WriteLine("Please enter 'y' or 'n'.");
    }
}
while (userChoice);

bool userChoice2 = true;

while(userChoice2)
{
    Console.WriteLine("Enter a number: ");
    string userInput2 = Console.ReadLine();
    int userNumber = int.Parse(userInput2);
    for (int i = userNumber; i >= 0; i--)
    {
        Console.Write($" {i}");
    }
    Console.WriteLine();
    for (int i = 0; i <= userNumber; i++)
    {
        Console.Write($" {i}");
    }
    Console.WriteLine();
    Console.WriteLine("Would you like to continue (y/n)?");
    string userInput = Console.ReadLine();
    if (userInput.ToLower() == "n")
    {
        break;
    }
    else if (userInput.ToLower() == "y")
    {
    }
    else
    {
        Console.WriteLine("Please enter 'y' or 'n'.");
    }
}

bool locked = true;
int attempts = 0;

while (locked)
{
    Console.WriteLine("Please enter the key combination");
    string combination = Console.ReadLine();
    if (combination == "13579")
    {
        Console.WriteLine("Welcome!");
        locked = false;
    }
    else
    {
        attempts++;
    }
    if (attempts == 5)
    {
        Console.WriteLine("There were too many incorrect attempts and you have been locked out.");
        break;
        //locked = false; //this seems counterintuitive but also works
    }
}

int attempts2 = 0;
do
{
    Console.WriteLine("Please enter the key combination.  You have 5 attempts remaining.");
    string combination2 = Console.ReadLine();
    if (combination2 == "13579")
    {
        Console.WriteLine("Welcome!");
        break;
    }
    else
    {
        attempts2++;
        Console.WriteLine($"You have {5 - attempts2} attempts remaining.");
    }
}
while (attempts2 < 5);
if (attempts2 == 5)
{
    Console.WriteLine("There were too many incorrect attempts and you have been locked out.");
}