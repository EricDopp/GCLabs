string[] studentNames = new string[10];
studentNames[0] = "Bill Burr";
studentNames[1] = "Michael Myers";
studentNames[2] = "Robert Pattinson";
studentNames[3] = "Kira Yoshikage";
studentNames[4] = "Ryan Gosling";
studentNames[5] = "Stephen Colbert";
studentNames[6] = "Jack Black";
studentNames[7] = "Johnny Cash";
studentNames[8] = "Arthur Maxson";
studentNames[9] = "Jotaro Kujo";

string[] studentHomeTown = new string[10];
studentHomeTown[0] = "Canton, Massachusetts";
studentHomeTown[1] = "Smith's Grove Sanitarium";
studentHomeTown[2] = "London, England";
studentHomeTown[3] = "The northeast section of Morioh, where all the villas are";
studentHomeTown[4] = "London, but not England, Ontario, Canada";
studentHomeTown[5] = "Washington, D.C., I'd expect nothing less";
studentHomeTown[6] = "Santa Monica, California";
studentHomeTown[7] = "Kingsland, Arkansas";
studentHomeTown[8] = "New California";
studentHomeTown[9] = "Somewhere in Japan, I dunno";

string[] studentFavoriteFood = new string[10];
studentFavoriteFood[0] = "mashed potatoes and fuckin' gravy";
studentFavoriteFood[1] = "whatever the Sanitarium was serving";
studentFavoriteFood[2] = "dino nuggets, go figure";
studentFavoriteFood[3] = "a glass of warm milk before going to bed, so that he usually has no problems sleeping until morning where he wakes up, just like a baby, without any fatigue or stress in the morning";
studentFavoriteFood[4] = "dalamari drizzled with lemon juice";
studentFavoriteFood[5] = "Ben & Jerry's AmeriConeDream ice cream";
studentFavoriteFood[6] = "cheeseburgers, he's a man of the people";
studentFavoriteFood[7] = "old iron pot chili, cornbread, peanut butter cookies, pineapple pie, or pan-fried okra";
studentFavoriteFood[8] = "deathclaw steaks chased with alcohol";
studentFavoriteFood[9] = "his mom's cooking";

//Dictionary<string, List<string>> studentDirectory = new Dictionary<string, List<string>>();
//studentDirectory.Add("Bill Burr", new List<string>());
//studentDirectory.Add("Michael Myers", new List<string>());
//studentDirectory.Add("Robert Pattinson", new List<string>());
//studentDirectory.Add("Kira Yoshikage", new List<string>());
//studentDirectory.Add("Ryan Gosling", new List<string>());
//studentDirectory.Add("Stephen Colbert", new List<string>());
//studentDirectory.Add("Jack Black", new List<string>());
//studentDirectory.Add("Johnny Cash", new List<string>());
//studentDirectory.Add("Arthur Maxson", new List<string>());
//studentDirectory.Add("Jotaro Kujo", new List<string>());
//studentDirectory.Add("List", new List<string>() { "Bill Burr, Michael Myers, Robert Pattinson, Kira Yoshikage, Ryan Gosling, Stephen Colbert, Jack Black, Johnny Cash, Arthur Maxson, Jotaro Kujo" });

//I couldn't get the dictionary method to work in time :'(

bool userContinue = true;
bool userContinue2 = true;
bool userContinue3 = true;
bool userContinue4 = true;
bool userContinue5 = true;
bool categoryGood = true;

Console.WriteLine("Welcome to Grand Circus! Here we have a bunch of students! Type, 'List' if you would like a list of our students, otherwise, press enter.");
string userList = Console.ReadLine();
if (userList.ToLower() == "list")
{
    foreach (string student in studentNames)
    {
        Console.WriteLine(student);
    }
}
else
{
    Console.WriteLine("Did you mean to type list? (y/n)");
    string userType = Console.ReadLine();
    while (userContinue3)
    {
        if (userType.ToLower() == "y")
        {
            foreach (string student in studentNames)
            {
                Console.WriteLine(student);
            }
            break;
        }
        else if (userType.ToLower() == "n")
        {
            break;
        }
        else
        {
            Console.WriteLine("Please enter 'y' or 'n'");
            userType = Console.ReadLine();
        }
    }
}
Console.WriteLine("Which student would you like to learn more about? Enter a number between 1-10: ");
bool parseGood = int.TryParse(Console.ReadLine(), out int userInput);
while (userContinue)
{
    if (parseGood)
    {
        while (userContinue2)
        {
            if (userInput >= 1 && userInput <= 10)
            {
                Console.Write($"Student {userInput} is {studentNames[userInput - 1]}. What would you like to know? Enter 'hometown' or 'favorite food': ");
                string userKnowMore = Console.ReadLine();
                while (categoryGood)
                {
                    if (userKnowMore.ToLower() == "hometown" || userKnowMore.ToLower() == "home" || userKnowMore.ToLower() == "town")
                    {
                        Console.WriteLine("");
                        Console.Write($"{studentNames[userInput - 1]} is from {studentHomeTown[userInput - 1]}.");
                        Console.WriteLine("");
                        Console.Write("Would you like to learn about another student? Enter 'y' or 'n': ");
                        string userAnother = Console.ReadLine();
                        if (userAnother == "y")
                        {
                            Console.Write("Which student would you like to learn more about? Enter a number between 1-10: ");
                            parseGood = int.TryParse(Console.ReadLine(), out userInput);
                            break;
                        }
                        else if (userAnother == "n")
                        {
                            userContinue = false;
                            userContinue2 = false;
                            break;
                        }
                        else
                        {
                            Console.Write("Please enter 'y' or 'n': ");
                            userAnother = Console.ReadLine();
                        }
                    }
                    else if (userKnowMore.ToLower() == "favorite food" || userKnowMore.ToLower() == "food")
                    {
                        Console.WriteLine("");
                        Console.WriteLine($"{studentNames[userInput - 1]}'s favorite food is: {studentFavoriteFood[userInput - 1]}.");
                        Console.WriteLine("");
                        Console.Write("Would you like to learn about another student? Enter 'y' or 'n': ");
                        string userAnother = Console.ReadLine();
                        if (userAnother == "y")
                        {
                            Console.Write("Which student would you like to learn more about? Enter a number between 1-10: ");
                            parseGood = int.TryParse(Console.ReadLine(), out userInput);
                            break;
                        }
                        else if (userAnother == "n")
                        {
                            Console.WriteLine("Thanks!");
                            userContinue = false;
                            userContinue2 = false;
                            break;
                        }
                        else
                        {
                            Console.Write("Please enter 'y' or 'n': ");
                            userAnother = Console.ReadLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("That category does not exist. Please try again. Enter 'hometown' or 'favorite food': ");
                        userKnowMore = Console.ReadLine();
                    }
                }
            }
            else
            {
                Console.Write("Please input a number between 1-10: ");
                int.TryParse(Console.ReadLine(), out userInput);
            }
        }
    }
    else
    {
        Console.Write("Please input a number between 1-10: ");
        parseGood = int.TryParse(Console.ReadLine(), out userInput);
    }
}
Console.WriteLine("Would you like to search a student by name? (y/n)");
string userByName = Console.ReadLine();
while (userContinue4)
{
    if (userByName.ToLower() == "y")
    {
        Console.WriteLine("Which student would you like to look up? Type their name or type 'list' if you want a list of students to look through.");
        string userInput2 = Console.ReadLine();

        if (userInput2.ToLower() == "bill burr")
        {
            Console.WriteLine($"{studentNames[0]} is from {studentHomeTown[0]} and their favorite food is {studentFavoriteFood[0]}.");
        }
        else if (userInput2.ToLower() == "michael myers")
        {
            Console.WriteLine($"{studentNames[1]} is from {studentHomeTown[1]} and their favorite food is  {studentFavoriteFood[1]}.");
        }
        else if (userInput2.ToLower() == "robert pattinson")
        {
            Console.WriteLine($"{studentNames[2]} is from {studentHomeTown[2]} and their favorite food is {studentFavoriteFood[2]}.");
        }
        else if (userInput2.ToLower() == "kira yoshikage")
        {
            Console.WriteLine($"{studentNames[3]} is from {studentHomeTown[3]} and their favorite food is {studentFavoriteFood[3]}.");
        }
        else if (userInput2.ToLower() == "ryan gosling")
        {
            Console.WriteLine($"{studentNames[4]} is from {studentHomeTown[4]} and their favorite food is {studentFavoriteFood[4]}.");
        }
        else if (userInput2.ToLower() == "stephen colbert")
        {
            Console.WriteLine($"{studentNames[5]} is from {studentHomeTown[5]} and their favorite food is {studentFavoriteFood[5]}.");
        }
        else if (userInput2.ToLower() == "jack black")
        {
            Console.WriteLine($"{studentNames[6]} is from {studentHomeTown[6]} and their favorite food is {studentFavoriteFood[6]}.");
        }
        else if (userInput2.ToLower() == "johnny cash")
        {
            Console.WriteLine($"{studentNames[7]} is from {studentHomeTown[7]} and their favorite food is {studentFavoriteFood[7]}.");
        }
        else if (userInput2.ToLower() == "arthur maxson")
        {
            Console.WriteLine($"{studentNames[8]} is from {studentHomeTown[8]} and their favorite food is {studentFavoriteFood[8]}.");
        }
        else if (userInput2.ToLower() == "jotaro kujo")
        {
            Console.WriteLine($"{studentNames[9]} is from {studentHomeTown[9]} and their favorite food is {studentFavoriteFood[9]}.");
        }
        else if (userInput2.ToLower() == "list")
        {
            Console.WriteLine($"The students include {studentNames[0]}, {studentNames[1]}, {studentNames[2]}, {studentNames[3]}, {studentNames[4]}, {studentNames[5]}, {studentNames[6]}, {studentNames[7]}, {studentNames[8]}, and {studentNames[9]}");
        }
        else
        {
            Console.WriteLine("Sorry, that's not a name in the list");
        }
        Console.WriteLine("Did you want to look up another student or look at the list again? (y/n)");
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
                break;
            }
            else
            {
                Console.WriteLine("Please enter 'y' or 'n'");
                userInput3 = Console.ReadLine();
            }
        }
    }
    else if (userByName.ToLower() == "n")
    {
        Console.WriteLine("Goodbye!");
        break;
    }
    else
    {
        Console.WriteLine("Please enter 'y' or 'n'");
        userByName = Console.ReadLine();
    }
}