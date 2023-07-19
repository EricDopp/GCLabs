Random dice6 = new Random();
int firstD6 = dice6.Next(1, 7);
int secondD6 = dice6.Next(1, 7);
int sumD6 = 0;

sumD6 = firstD6 + secondD6;
if (sumD6 == 2)
{
    Console.WriteLine("Snake Eyes: Two 1s");
}
else if (sumD6 == 3)
{
    Console.WriteLine("Ace Deuce: A 1 and 2");
}
else if (sumD6 == 12)
{
    Console.WriteLine("Box Cars: Two 6s");
}
else if (sumD6 == 7 || sumD6 == 11)
{
    Console.WriteLine("Win: A total of 7 or 11");
}
else if (sumD6 == 2 || sumD6 == 3 || sumD6 == 12)
{
    Console.WriteLine("Craps: A total of 2, 3, or 12");
}
else
    Console.WriteLine();