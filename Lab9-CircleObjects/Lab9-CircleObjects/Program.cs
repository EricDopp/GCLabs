using Lab9_CircleObjects;

bool userContinue1 = true;
bool userContinue2 = true;

double userRadius = 0;

Console.WriteLine("Welcome to the Circle Tester.");
Console.Write("Enter radius: ");
string userInput = Console.ReadLine();
bool parseSucceeded = double.TryParse(userInput, out userRadius);

while (userContinue1)
{
    if (userRadius <= 0 || (parseSucceeded = false))
    {
        Console.WriteLine("Please input a valid number greater than zero");
        userInput = Console.ReadLine();
        parseSucceeded = double.TryParse(userInput, out userRadius);
    }
    else
    {
        break;
    }
}
Circle.GetRadius(userRadius);
Circle circle = new Circle(userRadius);